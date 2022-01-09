#pragma once

#include <string>
#include <map>
#include <memory>
#include <vector>

namespace Data
{
	enum class ItemTypes
	{
		Structure,
		Value,
		Container,
	};

	class Item
	{
	public:
		inline const char* GetName() const
		{ 
			return Name.c_str();
		}

		inline void SetName(const std::string& name)
		{ 
			Name = name.c_str();
		}

		inline ItemTypes GetType() const 
		{
			return ItemType;
		}

		virtual bool IsDirty() const = 0;
		virtual void ResetToDefault() = 0;

		using Ptr = std::shared_ptr<Item>;

	protected:
		ItemTypes ItemType = ItemTypes::Value;
		std::string Name;

		bool Dirty = false;
	};

	class StructureItem : public Item
	{
	public:
		StructureItem() : Item() { ItemType = ItemTypes::Structure; }
		StructureItem(const char* structureName) : Item() 
		{ 
			if (structureName != nullptr)
				StructureName = structureName;
			ItemType = ItemTypes::Structure;
		}

		inline bool IsDirty() const override
		{
			for (std::map<std::string, Item::Ptr>::const_iterator itr = Fields.cbegin(); itr != Fields.cend(); itr++)
			{
				if (itr->second->IsDirty())
					return true;
			}
			return false;
		}

		inline void ResetToDefault() override
		{
			for (auto field : Fields)
				field.second->ResetToDefault();
		}

		std::map<std::string, Item::Ptr> Fields;

		std::string StructureName;

		inline void AddField(Item::Ptr field)
		{
			if (field != nullptr)
				Fields.insert_or_assign(field->GetName(), field);
		}

		inline Item::Ptr GetField(const std::string& name) const
		{
			auto itr = Fields.find(name);
			if (itr == Fields.end())
				return nullptr;

			return itr->second;
		}
	};
	using StructurePtr = std::shared_ptr<StructureItem>;

	template< class T>
	class ValueItem : public Item
	{
	public:
		ValueItem(T defaultValue) : DefaultValue(defaultValue), Value(defaultValue) { }

		inline bool IsDirty() const override
		{
			return Dirty;
		}

		inline void ResetToDefault() override
		{
			Value = DefaultValue;
		}

		const T& GetValue() const { return Value; }
		void SetValue(const T& value) { Value = value; Dirty = true; }

		static inline Item::Ptr Create(const std::string& name, T defaultValue)
		{
			std::shared_ptr<ValueItem<T>> ptr = std::make_shared<ValueItem<T>>(defaultValue);
			ptr->Name = name.c_str();
			return ptr;
		}

	protected:
		T DefaultValue;
		T Value;
	};

	class ContainerItem : public Item
	{
	public:
		ContainerItem() : Item() { ItemType = ItemTypes::Container; }
		ContainerItem(const char* valueType) : Item()
		{
			if (valueType != nullptr)
				ValueType = valueType;
			ItemType = ItemTypes::Container;
		}

		inline bool IsDirty() const override
		{
			for (std::map<std::string, Item::Ptr>::const_iterator itr = Values.cbegin(); itr != Values.cend(); itr++)
			{
				if (itr->second->IsDirty())
					return true;
			}
			return false;
		}

		inline void ResetToDefault() override
		{
			for (auto field : Values)
				field.second->ResetToDefault();
		}

		inline void AddValue (int key, Item::Ptr field)
		{
			if (field != nullptr)
				Values.insert_or_assign(key, field);
		}

		inline void RemoveValue(int key)
		{
			auto itr = Values.find(key);
			if (itr != Values.end())
				Values.erase(itr);
		}

		inline Item::Ptr GetValue(int key) const
		{
			auto itr = Values.find(key);
			if (itr == Values.end())
				return nullptr;

			return itr->second;
		}

		inline Item::Ptr GetValue(const std::string& name) const
		{
			return GetValue(atoi(name.c_str()));
		}

		inline std::vector<int> GetKeys() const
		{
			std::vector<int> keys;
			for (auto& itr : Values)
				keys.push_back(itr.first);

			return keys;
		}

		inline const std::string& GetValueType() const
		{
			return ValueType;
		}

	protected:
		std::map<int, Item::Ptr> Values;

		std::string ValueType;

	};
	using StructurePtr = std::shared_ptr<StructureItem>;

	class Path
	{
	public:
		std::vector<std::string> Elements;
	};
	Item::Ptr GetDataItem(const Path& path);

	template<class T>
	class ContainerWrapper
	{
	public:
		ContainerWrapper(std::shared_ptr<Data::ContainerItem> containerData) : ContainerData(containerData) { Validate(); }

		inline const std::string& GetContanerType()
		{
			return ContainerData->GetValueType();
		}

		inline void AddValue(int key, T value)
		{
			if (field != nullptr)
				Values.insert_or_assign(key, field);
		}

		inline void RemoveValue(int key)
		{
			auto itr = Values.find(key);
			if (itr != Values.end())
				Values.erase(itr);
		}

		inline Item::Ptr GetValue(int key) const
		{
			auto itr = Values.find(key);
			if (itr == Values.end())
				return nullptr;

			return itr->second;
		}

		inline Item::Ptr GetValue(const std::string& name) const
		{
			return GetValue(atoi(name.c_str()));
		}

		inline std::vector<int> GetKeys() const
		{
			std::vector<int> keys;
			for (auto& itr : Values)
				keys.push_back(itr.first);

			return keys;
		}

	protected:
		std::shared_ptr<Data::ContainerItem> ContainerData;

		ItemTypes ContainerType = ItemTypes::Value;

		inline void Validate()
		{
			if (ContainerData == nullptr)
				throw("Invalid Container Pointer");

			if (StructureDb::IsStructure(ContainerData->GetValueType()))
		}
	};

	class StructWrapper
	{
	public:
		StructWrapper(Data::StructurePtr structPtr) : StructData(structPtr) {}

		inline bool IsDirty()
		{
			return StructData != nullptr && StructData->IsDirty();
		}

	protected:
		Data::StructurePtr StructData;

		void Validate(const char* name)
		{
			if (StructData == nullptr)
				throw("Invalid Structure Pointer");

			if (StructData->StructureName != name)
				throw("Incorrect Structure Type");
		}

		template<class T>
		const T& GetField(const std::string& name) const
		{
			if (StructData == nullptr)
			{
				throw("Invalid Structure Pointer");
			}

			auto itr = StructData->Fields.find(name);
			if (itr == StructData->Fields.end())
				throw("Unknown field");

			if (itr->second->GetType() != Data::ItemTypes::Value)
				throw("Invalid field type");

			std::shared_ptr<Data::ValueItem<T>> valuePtr = std::dynamic_pointer_cast<Data::ValueItem<T>>(itr->second);

			return valuePtr->GetValue();
		}

		template<class T>
		void SetField(const std::string& name, const T& value)
		{
			if (StructData == nullptr)
			{
				throw("Invalid StructPtr");
			}

			auto itr = StructData->Fields.find(name);
			if (itr == StructData->Fields.end())
				throw("Unknown field");

			if (itr->second->GetType() != Data::ItemTypes::Value)
				throw("Invalid field type");

			std::shared_ptr<Data::ValueItem<T>> valuePtr = std::dynamic_pointer_cast<Data::ValueItem<T>>(itr->second);

			valuePtr->SetValue(value);
		}

		template<class T>
		T ExtractStructFromField(const std::string& name) const
		{
			if (StructData == nullptr)
			{
				throw("Invalid StructPtr");
			}

			auto itr = StructData->Fields.find(name);
			if (itr == StructData->Fields.end())
				throw("Unknown field");

			if (itr->second->GetType() != Data::ItemTypes::Structure)
				throw("Invalid field type");

			std::shared_ptr<Data::StructureItem> fieldPtr = std::dynamic_pointer_cast<Data::StructureItem>(itr->second);

			return std::move(T(fieldPtr));
		}

		template <class T>
		ContainerWrapper<T> ExtractContainerFromField(const std::string& name) const
		{
			if (StructData == nullptr)
			{
				throw("Invalid StructPtr");
			}

			auto itr = StructData->Fields.find(name);
			if (itr == StructData->Fields.end())
				throw("Unknown field");

			if (itr->second->GetType() != Data::ItemTypes::Container)
				throw("Invalid field type");

			std::shared_ptr<Data::ContainerItem> containerPtr = std::dynamic_pointer_cast<Data::ContainerItem>(itr->second);

			return std::move(ContainerWrapper<T>(containerPtr));
		}
	};

}
