#include "data/modules.h"

namespace Data
{

	// Autogen structModuleInfo
	bool ModuleInfo::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<ModuleID>::Create("Id", "ModuleID"));
		structureItem->AddField(Data::ValueItem<bool>::Create("Inited", false, "bool"));
		structureItem->AddField(Data::ValueItem<bool>::Create("Running", false, "bool"));

		return true;
	}

	const ModuleID& ModuleInfo::GetId() const { return GetField<ModuleID>("Id"); }
	void ModuleInfo::SetId(const ModuleID& value) { return SetField<ModuleID>("Id", value); }

	const bool& ModuleInfo::GetInited() const { return GetField<bool>("Inited"); }
	void ModuleInfo::SetInited(const bool& value) { return SetField<bool>("Inited", value); }

	const bool& ModuleInfo::GetRunning() const { return GetField<bool>("Running"); }
	void ModuleInfo::SetRunning(const bool& value) { return SetField<bool>("Running", value); }

	// Autogen structCommonModules
	bool CommonModules::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		DB::CreateContainer(ModuleInfo::Name, "Modules", structureItem);

		return true;
	}

	ContainerWrapper<ModuleInfo> CommonModules::GetModules() const { return ExtractContainerFromField<ModuleInfo>("Modules"); }
	// Registration function
	void RegisterModulesStructs()
	{
		DB::AddStructureDef(ModuleInfo::Name, ModuleInfo::Create); 
		DB::AddStructureDef(CommonModules::Name, CommonModules::Create); 
	}

}
