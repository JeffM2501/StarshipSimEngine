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

	class Path
	{
	public:
		std::vector<std::string> Elements;
	};

	Item::Ptr GetDataItem(const Path& path);
}
