#pragma once

#include "data/data_types.h"
#include "data/data_path.h"

#include <functional>
#include <map>
#include <memory>
#include <string>
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
		using Ptr = std::shared_ptr<Item>;

		const char* GetName() const;
		void SetName(const std::string& name);
		ItemTypes GetType() const;

		const Path& GetPath();
		void SetPath(const Path&);

		virtual bool IsDirty() const = 0;
		virtual void ResetToDefault() = 0;

		std::string DataTypeName;

	protected:
		ItemTypes ItemType = ItemTypes::Value;
		std::string Name;
		Path ItemPath;
		bool Dirty = false;
	};

	template<class T>
	class ValueItem : public Item
	{
	public:
		// Value Item
		ValueItem(const char* valueTypeName = nullptr)
		{
			if (valueTypeName != nullptr)
				DataTypeName = valueTypeName;
		}

		ValueItem(T defaultValue, const char* valueTypeName = nullptr)
			: DefaultValue(defaultValue)
			, Value(defaultValue)
		{
			if (valueTypeName != nullptr)
				DataTypeName = valueTypeName;
		}

		inline bool IsDirty() const
		{
			return Dirty;
		}

		inline void ResetToDefault()
		{
			Value = DefaultValue;
		}

		inline const T& GetValue() const
		{
			return Value;
		}

		inline void SetValue(const T& value)
		{
			Value = value;
			Dirty = true;
		}

		static inline Item::Ptr Create(const std::string& name, T defaultValue, const char* dataTypeName = nullptr)
		{
			std::shared_ptr<ValueItem<T>> ptr = std::make_shared<ValueItem<T>>(defaultValue);
			ptr->Name = name.c_str();
			if (dataTypeName != nullptr)
				ptr->DataTypeName = dataTypeName;
			return ptr;
		}

		static inline Item::Ptr Create(const std::string& name, const char* dataTypeName = nullptr)
		{
			std::shared_ptr<ValueItem<T>> ptr = std::make_shared<ValueItem<T>>();
			ptr->Name = name.c_str();
			if (dataTypeName != nullptr)
				ptr->DataTypeName = dataTypeName;
			return ptr;
		}

	protected:
		T DefaultValue;
		T Value;
	};

	class StructureItem : public Item
	{
	public:
		StructureItem();
		StructureItem(const char* structureName);

		bool IsDirty() const override;
		void ResetToDefault() override;

		void AddField(Item::Ptr field);
		Item::Ptr GetField(const std::string& name) const;

		std::map<std::string, Item::Ptr> Fields;
	};
	using StructurePtr = std::shared_ptr<StructureItem>;

	class ContainerItem : public Item
	{
	public:
		ContainerItem();
		ContainerItem(const char* valueType);

		bool IsDirty() const override;
		void ResetToDefault() override;

		void AddValue(int key, Item::Ptr field);
		void RemoveValue(int key);

		Item::Ptr GetValue(int key) const;
		Item::Ptr GetValue(const std::string& name) const;

		std::vector<int> GetKeys() const;

		const std::string& GetValueType() const;

	protected:
		std::map<int, Item::Ptr> Values;
	};
	using ContainerPtr = std::shared_ptr<ContainerItem>;

	using StructureDefCallback = std::function<bool(const std::string& stucture, Data::StructurePtr structureItem)>;
	Item::Ptr GetDataItem(const Path& path);

	namespace DB
	{
		void AddStructureDef(const std::string& structureName, StructureDefCallback callbkack);

		bool IsStructure(const std::string& structureName);

		Data::StructurePtr CreateStructure(const std::string& structure, const std::string& name, StructurePtr parent);
		Data::StructurePtr CreateStructure(const std::string& structure, int key, ContainerPtr parent);
		Data::StructurePtr CreateStructure(const std::string& structure, const std::string& name, Path parentPath);
		Data::StructurePtr CreateStructure(const std::string& structure, int key, Path parentPath);

		Data::ContainerPtr CreateContainer(const std::string& containerType, const std::string& name, StructurePtr parent);
		Data::ContainerPtr CreateContainer(const std::string& containerType, const std::string& name, Path parentPath);
	}
}