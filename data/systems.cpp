#include "data/systems.h"

namespace Data
{

	// Autogen structSystemDef
	bool SystemDef::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<float>::Create("FunctionalStatus", 1.0f, "float"));
		structureItem->AddField(Data::ValueItem<float>::Create("OperationalStatus", 1.0f, "float"));
		structureItem->AddField(Data::ValueItem<float>::Create("ReliabilityFactor", 1.0f, "float"));
		structureItem->AddField(Data::ValueItem<float>::Create("EnergyRequirement", 0.0, "float"));

		return true;
	}

	const float& SystemDef::GetFunctionalStatus() const { return GetField<float>("FunctionalStatus"); }
	void SystemDef::SetFunctionalStatus(const float& value) { return SetField<float>("FunctionalStatus", value); }

	const float& SystemDef::GetOperationalStatus() const { return GetField<float>("OperationalStatus"); }
	void SystemDef::SetOperationalStatus(const float& value) { return SetField<float>("OperationalStatus", value); }

	const float& SystemDef::GetReliabilityFactor() const { return GetField<float>("ReliabilityFactor"); }
	void SystemDef::SetReliabilityFactor(const float& value) { return SetField<float>("ReliabilityFactor", value); }

	const float& SystemDef::GetEnergyRequirement() const { return GetField<float>("EnergyRequirement"); }
	void SystemDef::SetEnergyRequirement(const float& value) { return SetField<float>("EnergyRequirement", value); }

	// Autogen structDefensiveSystem
	bool DefensiveSystem::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<DefensiveSystemTypes>::Create("SystemType", "DefensiveSystemTypes"));
		DB::CreateStructure(SystemDef::Name, "SystemInfo", structureItem);

		return true;
	}

	const DefensiveSystemTypes& DefensiveSystem::GetSystemType() const { return GetField<DefensiveSystemTypes>("SystemType"); }
	void DefensiveSystem::SetSystemType(const DefensiveSystemTypes& value) { return SetField<DefensiveSystemTypes>("SystemType", value); }

	SystemDef DefensiveSystem::GetSystemInfo() const { return ExtractStructFromField<SystemDef>("SystemInfo"); }

	// Autogen structOffsensiveWeaponsSystem
	bool OffsensiveWeaponsSystem::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<OffsensiveWeaponSystemTypes>::Create("SystemType", "OffsensiveWeaponSystemTypes"));
		DB::CreateStructure(SystemDef::Name, "SystemInfo", structureItem);

		return true;
	}

	const OffsensiveWeaponSystemTypes& OffsensiveWeaponsSystem::GetSystemType() const { return GetField<OffsensiveWeaponSystemTypes>("SystemType"); }
	void OffsensiveWeaponsSystem::SetSystemType(const OffsensiveWeaponSystemTypes& value) { return SetField<OffsensiveWeaponSystemTypes>("SystemType", value); }

	SystemDef OffsensiveWeaponsSystem::GetSystemInfo() const { return ExtractStructFromField<SystemDef>("SystemInfo"); }
	// Registration function
	void RegisterSystemsStructs()
	{
		DB::AddStructureDef(SystemDef::Name, SystemDef::Create); 
		DB::AddStructureDef(DefensiveSystem::Name, DefensiveSystem::Create); 
		DB::AddStructureDef(OffsensiveWeaponsSystem::Name, OffsensiveWeaponsSystem::Create); 
	}

}
