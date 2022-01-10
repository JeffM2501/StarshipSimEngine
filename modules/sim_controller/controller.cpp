#include "communications/module.h"
#include "engineering/module.h"
#include "helm/module.h"
#include "medical/module.h"
#include "navigation/module.h"
#include "sciences/module.h"
#include "sim_controller/module.h"

#include "commands.h"

#include "data/data.h"
#include "data/modules.h"
#include "data/common.h"

#include <deque>
#include <limits>

static bool UseLocalModules = true;

std::unordered_map<SimulationCommands, SimEventHandler> SimEventHandlers;

std::deque<SimulationData> PendingInput;

void AddSimulationInput(const SimulationData& data)
{
	PendingInput.emplace_back(std::move(data));
}

void UpdateBackgroundTasks()
{
	if (UseLocalModules)
	{
		UpdatCommunications();
		UpdateEngineering();
		UpdateHelm();
		UpdateMedical();
		UpdateNavigation();
		UpdateSciences();
	}
}

void UpdateOperatorInput()
{
	if (PendingInput.empty())
		return;

	const SimulationData& data = PendingInput.front();
	
	std::unordered_map<SimulationCommands, SimEventHandler>::iterator itr = SimEventHandlers.find(data.Command);
	if (itr != SimEventHandlers.end())
		itr->second(data);

	PendingInput.pop_front();
}

void UpdateDisplay()
{
}

void UpdateSimController()
{
	UpdateBackgroundTasks();
	UpdateOperatorInput();
	UpdateDisplay();
}

void DoInitModule(int moduleId)
{
	auto modules = Data::GetDataWrapper<Data::CommonModules>(Data::DB::CreateStructure(Data::CommonModules::Name, Data::CommonModules::Name, Path::Root())).GetModules();

	auto moduleInfo = modules.GetValue(moduleId);
	if (!moduleInfo.Valid() || moduleInfo.GetInited())
		return;

	moduleInfo.SetInited(true);

	// init the module if we are local
	if (UseLocalModules)
	{
		switch (Data::ModuleID(moduleId))
		{
		case Data::ModuleID::Communications:
			InitCommunications();
			break;

		case Data::ModuleID::Engineering:
			InitEngineering();
			break;

		case Data::ModuleID::Helm:
			InitHelm();
			break;

		case Data::ModuleID::Medical:
			InitMedical();
			break;

		case Data::ModuleID::Navigation:
			InitNavigation();
			break; 
		case Data::ModuleID::Sciences:
			InitSciences();
			break;
		}
	}
}

// input commands
void InitModule(const SimulationData& data)
{
	DoInitModule(data.IntArgs[0]);
}

void InitAllModules(const SimulationData&)
{
	for (int i = 0; i < (int)Data::ModuleID::LastModuleID; i++)
	{
		DoInitModule(i);
	}
}

void InitSimController()
{
	SimEventHandlers[SimulationCommands::InitModule] = InitModule;
	SimEventHandlers[SimulationCommands::InitAllModules] = InitAllModules;

	// setup the global module data
	auto modules = Data::GetDataWrapper<Data::CommonModules>(Data::DB::CreateStructure(Data::CommonModules::Name, Data::CommonModules::Name, Path::Root())).GetModules();

	if (modules.IsEmpty())
	{
		for (int i = 0; i < (int)Data::ModuleID::LastModuleID; i++)
		{
			auto moduleInfo = modules.AddValueDefault(i);
			moduleInfo.SetId(Data::ModuleID(i));
		}
	}

	// set up a universe
	auto universePtr = Data::DB::CreateStructure(Data::Universe::Name, Data::Universe::Name, Path::Root());
	auto universe = Data::GetDataWrapper<Data::Universe>(universePtr);

	universe.SetMaxium(Vector3D{ std::numeric_limits<double>::max(), std::numeric_limits<double>::max(), std::numeric_limits<double>::max() });
	universe.SetMinium(Vector3D{ std::numeric_limits<double>::min(), std::numeric_limits<double>::min(), std::numeric_limits<double>::min() });

	// everything else will be set by script
}
