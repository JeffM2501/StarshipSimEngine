#include "sim_controller/module.h"
#include "commands.h"

#include "data/data.h"

#include <deque>

std::unordered_map<SimulationCommands, SimEventHandler> SimEventHandlers;

std::deque<SimulationData> PendingInput;

void AddSimulationInput(const SimulationData& data)
{
	PendingInput.emplace_back(std::move(data));
}

void UpdateBackgroundTasks()
{

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

// input commands
void InitModule(const SimulationData& data)
{
	GetModuleState(ModuleID(data.IntArgs[0])).Init = true;
}

void InitAllModules(const SimulationData& data)
{
	for(int i = 0; i < int(ModuleID::LastModule); i++)
		GetModuleState(ModuleID(i)).Init = true;
}

void InitSimController()
{
	SimEventHandlers[SimulationCommands::InitModule] = InitModule;
	SimEventHandlers[SimulationCommands::InitAllModules] = InitAllModules;
}
