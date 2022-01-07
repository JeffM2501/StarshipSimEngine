// Data.cpp : Defines the functions for the static library.
//

#include "Data.h"

namespace Data
{
	StructurePtr Root;

	Item::Ptr GetDataItem(const Path& path)
	{
		if (Root == nullptr)
			Root = std::make_shared<StructureItem>("Root");

		if (path.Elements.empty())
			return Root;

		StructureItem* structItem = Root.get();

		for (size_t i = 0; i < path.Elements.size(); i++)
		{
			auto itr = structItem->Fields.find(path.Elements[i]);
			if (itr == structItem->Fields.end())
				return nullptr;

			bool end = i == path.Elements.size()-1;
			
			if (!end )
			{
				if (itr->second->GetType() == ItemTypes::Value)
					return nullptr;

				structItem = static_cast<StructureItem*>(itr->second.get());
			}
			else
			{
				return itr->second;
			}
		}

		return nullptr;
	}
}