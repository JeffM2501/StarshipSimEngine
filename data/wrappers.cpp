#include "data/wrappers.h"

namespace Data
{
	// StructWrapper
	StructWrapper::StructWrapper(Data::StructurePtr structPtr)
		: StructData(structPtr)
	{}

	bool StructWrapper::IsDirty()
	{
		return StructData != nullptr && StructData->IsDirty();
	}


	void StructWrapper::Validate(const char* name)
	{
		if (StructData == nullptr)
			throw("Invalid Structure Pointer");

		if (StructData->DataTypeName != name)
			throw("Incorrect Structure Type");
	}

	template<class T>
	const T& StructWrapper::GetField(const std::string& name) const
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
	void StructWrapper::SetField(const std::string& name, const T& value)
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
	T StructWrapper::ExtractStructFromField(const std::string& name) const
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
	ContainerWrapper<T> StructWrapper::ExtractContainerFromField(const std::string& name) const
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

	// ContainerWrapper
	template<class T>
	ContainerWrapper<T>::ContainerWrapper(std::shared_ptr<Data::ContainerItem> containerData)
		: ContainerData(containerData) 
	{ 
		Validate(); 
	}

	template<class T>
	const std::string& ContainerWrapper<T>::GetContanerType()
	{
		return ContainerData->GetValueType();
	}

	template<class T>
	void ContainerWrapper<T>::AddValue(int key, T value)
	{
		if (field != nullptr)
			Values.insert_or_assign(key, field);
	}

	template<class T>
	void ContainerWrapper<T>::RemoveValue(int key)
	{
		auto itr = Values.find(key);
		if (itr != Values.end())
			Values.erase(itr);
	}

	template<class T>
	T ContainerWrapper<T>::GetValue(int key) const
	{
		auto itr = Values.find(key);
		if (itr == Values.end())
			return nullptr;

		return std::move(T(itr->second));
	}

	template<class T>
	T ContainerWrapper<T>::GetValue(const std::string& name) const
	{
		return GetValue(atoi(name.c_str()));
	}

	template<class T>
	std::vector<int> ContainerWrapper<T>::GetKeys() const
	{
		std::vector<int> keys;
		for (auto& itr : Values)
			keys.push_back(itr.first);

		return keys;
	}

	template<class T>
	void ContainerWrapper<T>::Validate()
	{
		if (ContainerData == nullptr)
			throw("Invalid Container Pointer");
	}

	template<class T>
	T GetDataWrapper(const Path& path)
	{
		return std::move(T(Data::GetDataItem(path)));
	}
}