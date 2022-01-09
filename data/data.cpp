#include "data/data.h"

namespace Data
{
	// Item base class
	const char* Item::GetName() const
	{
		return Name.c_str();
	}

	void Item::SetName(const std::string& name)
	{
		Name = name.c_str();
	}

	ItemTypes Item::GetType() const
	{
		return ItemType;
	}

	// Value Item
	template< class T>
	ValueItem<T>::ValueItem(const char* valueTypeName)
	{
		if (valueTypeName != nullptr)
			DataTypeName = valueTypeName; 
	}
	
	template< class T>
	ValueItem<T>::ValueItem(T defaultValue, const char*)
		: DefaultValue(defaultValue)
		, Value(defaultValue) 
	{ 
		if (valueTypeName != nullptr)
			DataTypeName = valueTypeName; 
	}

	template< class T>
	bool ValueItem<T>::IsDirty() const
	{
		return Dirty;
	}

	template< class T>
	void ValueItem<T>::ResetToDefault()
	{
		Value = DefaultValue;
	}

	template< class T>
	const T& ValueItem<T>::GetValue() const
	{ 
		return Value;
	}

	template< class T>
	void ValueItem<T>::SetValue(const T& value)
	{ 
		Value = value;
		Dirty = true;
	}

	template< class T>
	Item::Ptr ValueItem<T>::Create(const std::string& name, T defaultValue, const char* dataTypeName)
	{
		std::shared_ptr<ValueItem<T>> ptr = std::make_shared<ValueItem<T>>(defaultValue);
		ptr->Name = name.c_str();
		if (dataTypeName != nullptr)
			ptr->DataTypeName = dataTypeName;
		return ptr;
	}

	template< class T>
	Item::Ptr ValueItem<T>::Create(const std::string& name, const char* dataTypeName)
	{
		std::shared_ptr<ValueItem<T>> ptr = std::make_shared<ValueItem<T>>();
		ptr->Name = name.c_str();
		if (dataTypeName != nullptr)
			ptr->DataTypeName = dataTypeName;
		return ptr;
	}

	// StructureItem
	StructureItem::StructureItem()
		: Item()
	{
		ItemType = ItemTypes::Structure;
	}

	StructureItem::StructureItem(const char* structureName)
		: Item()
	{
		if (structureName != nullptr)
			DataTypeName = structureName;
		ItemType = ItemTypes::Structure;
	}

	bool StructureItem::IsDirty() const
	{
		for (std::map<std::string, Item::Ptr>::const_iterator itr = Fields.cbegin(); itr != Fields.cend(); itr++)
		{
			if (itr->second->IsDirty())
				return true;
		}
		return false;
	}

	void StructureItem::ResetToDefault()
	{
		for (auto field : Fields)
			field.second->ResetToDefault();
	}

	void StructureItem::AddField(Item::Ptr field)
	{
		if (field != nullptr)
			Fields.insert_or_assign(field->GetName(), field);
	}

	Item::Ptr StructureItem::GetField(const std::string& name) const
	{
		auto itr = Fields.find(name);
		if (itr == Fields.end())
			return nullptr;

		return itr->second;
	}

	// ContainerItem
	ContainerItem::ContainerItem()
		: Item()
	{ 
		ItemType = ItemTypes::Container;
	}

	ContainerItem::ContainerItem(const char* valueType)
		: Item()
	{
		if (valueType != nullptr)
			DataTypeName = valueType;
		ItemType = ItemTypes::Container;
	}

	bool ContainerItem::IsDirty() const
	{
		for (std::map<int, Item::Ptr>::const_iterator itr = Values.cbegin(); itr != Values.cend(); itr++)
		{
			if (itr->second->IsDirty())
				return true;
		}
		return false;
	}

	void ContainerItem::ResetToDefault()
	{
		for (auto field : Values)
			field.second->ResetToDefault();
	}

	void ContainerItem::AddValue(int key, Item::Ptr field)
	{
		if (field != nullptr)
			Values.insert_or_assign(key, field);
	}

	void ContainerItem::RemoveValue(int key)
	{
		auto itr = Values.find(key);
		if (itr != Values.end())
			Values.erase(itr);
	}

	Item::Ptr ContainerItem::GetValue(int key) const
	{
		auto itr = Values.find(key);
		if (itr == Values.end())
			return nullptr;

		return itr->second;
	}

	Item::Ptr ContainerItem::GetValue(const std::string & name) const
	{
		return GetValue(atoi(name.c_str()));
	}

	std::vector<int> ContainerItem::GetKeys() const
	{
		std::vector<int> keys;
		for (auto& itr : Values)
			keys.push_back(itr.first);

		return keys;
	}

	const std::string& ContainerItem::GetValueType() const
	{
		return DataTypeName;
	}

	// data tree
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

			bool end = i == path.Elements.size() - 1;

			if (!end)
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

	namespace DB
	{
		std::map <std::string, StructureDefCallback> StructureCallbacks;

		void AddStructureDef(const std::string& structureName, StructureDefCallback callbkack)
		{
			StructureCallbacks.insert_or_assign(structureName, callbkack);
		}

		bool IsStructure(const std::string& structureName)
		{
			return StructureCallbacks.find(structureName) != StructureCallbacks.end();
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

		Data::StructurePtr CreateStructure(const std::string& structure, const std::string& name, Path parentPath)
		{
			Data::Item::Ptr parent = Data::GetDataItem(parentPath);
			if (parent == nullptr || parent->GetType() != Data::ItemTypes::Structure)
				return nullptr;

			return CreateStructure(structure, name, std::dynamic_pointer_cast<Data::StructureItem>(parent));
		}

		Data::ContainerPtr CreateConatner(const std::string& containerType, const std::string& name, StructurePtr parent)
		{
			Data::ContainerPtr containerPtr = std::make_shared<Data::ContainerItem>(containerType.c_str());
			containerPtr->SetName(name);

			parent->Fields.insert_or_assign(name, containerPtr);

			return containerPtr;
		}

		Data::ContainerPtr CreateConatner(const std::string& containerType, const std::string& name, Path parentPath)
		{
			Data::Item::Ptr parent = Data::GetDataItem(parentPath);
			if (parent == nullptr || parent->GetType() != Data::ItemTypes::Structure)
				return nullptr;

			return CreateConatner(containerType, name, std::dynamic_pointer_cast<Data::StructureItem>(parent));
		}
	}
}
