#include "StructureDb.h"
#include <memory>

namespace StructureDb
{
	std::map <std::string, StructureDefCallback> StructureCallbacks;

	void AddStructureDef(const std::string& structureName, StructureDefCallback callbkack)
	{
		StructureCallbacks.insert_or_assign(structureName, callbkack);
	}

	Data::StructurePtr CreateStructure(const std::string& structure, const std::string& name, Data::StructurePtr parent)
	{
		auto itr = StructureCallbacks.find(structure);
		if (itr == StructureCallbacks.end() || itr->second == nullptr)
			return nullptr;

		Data::StructurePtr structurePtr = std::make_shared<Data::StructureItem>(structure.c_str());
		structurePtr->SetName(name);

		if (!itr->second(structure, structurePtr))
			return nullptr;

		parent->Fields.insert_or_assign(name, structurePtr);

		return structurePtr;
	}

	Data::StructurePtr CreateStructure(const std::string& structure, const std::string& name, Data::Path parentPath)
	{
		Data::Item::Ptr parent = Data::GetDataItem(parentPath);
		if (parent == nullptr || parent->GetType() != Data::ItemTypes::Structure)
			return nullptr;

		return CreateStructure(structure, name, std::dynamic_pointer_cast<Data::StructureItem>(parent));
	}
}