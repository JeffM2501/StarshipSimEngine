#pragma once
#include "data/data.h"
#include "data/wrappers.h"
#include <memory>

namespace Data
{

	//Enums
	enum class DefensiveSystemTypes
	{
		None = 0,
		Shield = 1,
		LastDefensiveSystemTypes = 2
	};

	enum class OffsensiveWeaponSystemTypes
	{
		None = 0,
		Phaser = 1,
		PhotonTorpedo = 2,
		CommunicatonDisruptor = 3,
		UltimateDistruct = 4,
		LastOffsensiveWeaponSystemTypes = 5
	};


	// Autogen struct SystemDef
	class SystemDef : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "SystemDef";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		SystemDef(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("SystemDef");}

		const float& GetFunctionalStatus() const;
		void SetFunctionalStatus(const float& value);

		const float& GetOperationalStatus() const;
		void SetOperationalStatus(const float& value);

		const float& GetReliabilityFactor() const;
		void SetReliabilityFactor(const float& value);

		const float& GetEnergyRequirement() const;
		void SetEnergyRequirement(const float& value);
	};

	// Autogen struct DefensiveSystem
	class DefensiveSystem : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "DefensiveSystem";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		DefensiveSystem(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("DefensiveSystem");}

		const DefensiveSystemTypes& GetSystemType() const;
		void SetSystemType(const DefensiveSystemTypes& value);

		class SystemDef GetSystemInfo() const;
	};

	// Autogen struct OffsensiveWeaponsSystem
	class OffsensiveWeaponsSystem : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "OffsensiveWeaponsSystem";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		OffsensiveWeaponsSystem(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("OffsensiveWeaponsSystem");}

		const OffsensiveWeaponSystemTypes& GetSystemType() const;
		void SetSystemType(const OffsensiveWeaponSystemTypes& value);

		class SystemDef GetSystemInfo() const;
	};

	// Registration function
	void RegisterSystemsStructs();

}
