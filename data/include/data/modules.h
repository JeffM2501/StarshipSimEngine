#pragma once
#include "data/data.h"
#include "data/wrappers.h"
#include <memory>

namespace Data
{

	//Enums
	enum class ModuleID
	{
		Communications = 0,
		Engineering = 1,
		Helm = 2,
		Medical = 3,
		Navigation = 4,
		Sciences = 5,
		LastModuleID = 6
	};


	// Autogen struct ModuleInfo
	class ModuleInfo : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "ModuleInfo";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		ModuleInfo(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("ModuleInfo");}

		const ModuleID& GetId() const;
		void SetId(const ModuleID& value);

		const bool& GetInited() const;
		void SetInited(const bool& value);

		const bool& GetRunning() const;
		void SetRunning(const bool& value);
	};

	// Autogen struct CommonModules
	class CommonModules : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "CommonModules";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		CommonModules(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("CommonModules");}

		ContainerWrapper<ModuleInfo> GetModules() const;
	};

	// Registration function
	void RegisterModulesStructs();

}
