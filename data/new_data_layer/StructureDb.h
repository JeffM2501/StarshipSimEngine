#pragma once

#include "Data.h"

#include <functional>

namespace StructureDb
{
	using StructureDefCallback = std::function<bool(const std::string& stucture, Data::StructurePtr structureItem)>;

	void AddStructureDef(const std::string& structureName, StructureDefCallback callbkack);
	Data::StructurePtr CreateStructure(const std::string& structure, const std::string& name, Data::StructurePtr parent);
	Data::StructurePtr CreateStructure(const std::string& structure, const std::string& name, Data::Path parentPath);
}