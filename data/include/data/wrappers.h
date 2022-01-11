#pragma once

#include "data/data.h"

namespace Data
{
	template<class T>
	class ContainerWrapper
	{
	public:
		ContainerWrapper(std::shared_ptr<Data::Item> containerData)
			: ContainerData(std::dynamic_pointer_cast<Data::ContainerItem>(containerData))
		{
			Validate();
		}

		inline const std::string& ContainerWrapper<T>::GetContanerType()
		{
			return ContainerData->GetValueType();
		}

		inline void AddValue(int key, T value)
		{
			if (field != nullptr)
				Values.insert_or_assign(key, field);
		}
		
		inline T AddValueDefault(int key)
		{
			auto val = DB::CreateStructure(ContainerData->DataTypeName, key, ContainerData->GetPath());
			Values.insert_or_assign(key, val);

			return T(val);
		}

		inline void RemoveValue(int key)
		{
			auto itr = Values.find(key);
			if (itr != Values.end())
				Values.erase(itr);
		}

		inline T GetValue(int key) const
		{
			auto itr = Values.find(key);
			if (itr == Values.end())
				return nullptr;

			return std::move(T(itr->second));
		}

		inline T GetValue(const std::string& name) const
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

		inline bool IsEmpty()
		{
			return Values.size() == 0;
		}

		inline size_t Size()
		{
			return Values.size();
		}

		inline bool Valid() const { return ContainerData != nullptr; }

		std::map<int, Item::Ptr> Values;

	protected:
		std::shared_ptr<Data::ContainerItem> ContainerData;

		inline void Validate()
		{
			if (ContainerData == nullptr)
				throw("Invalid Container Pointer");
		}
	};

	class StructWrapper
	{
	public:
		StructWrapper(Data::Item::Ptr structPtr);
		bool IsDirty();

		template<class T>
		inline const T& GetField(const std::string& name) const
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
		inline void SetField(const std::string& name, const T& value)
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
		inline T ExtractStructFromField(const std::string& name) const
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
		inline ContainerWrapper<T> ExtractContainerFromField(const std::string& name) const
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

		inline bool Valid() const { return StructData != nullptr; }

		Data::StructurePtr StructData;

	protected:
		void Validate(const char* name);
	};

	template<class T>
	inline T GetDataWrapper(const Path& path)
	{
		T t(ptr);
		return t(Data::GetDataItem(path));
	}

	template<class T>
	inline T GetDataWrapper(Item::Ptr& ptr)
	{
		T t(ptr);
		return t;
	}

	template<class T>
	inline T GetDataWrapper(StructurePtr& ptr)
	{
		T t(std::dynamic_pointer_cast<Item>(ptr));
		return t;
	}
}