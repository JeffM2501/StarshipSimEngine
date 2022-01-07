#pragma once

#include "Data.h"
#include "StructureDb.h"

#include <memory>

void RegisterTestStructs();

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
	T ExtractStructFromField(const std::string& name)
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
};

class TestStruct2 : public StructWrapper
{
public:
	TestStruct2(Data::StructurePtr structPtr) : StructWrapper(structPtr) { Validate("TestStruct2"); }

	inline const char& GetAChar() const { return GetField<char>("AChar"); }
	inline void SetAChar(const char& value) { return SetField<char>("AChar", value); }

	inline const int& GetBInt() { return GetField<int>("BInt"); }
	inline void SetBInt(const int &value) { return SetField<int>("BInt", value); }

	inline const std::string& GetSomeData() { return GetField<std::string>("SomeData"); }
	inline void SetSomeData(const std::string& value) { return SetField<std::string>("SomeData", value); }

	inline static bool Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<char>::Create("AChar", '2'));
		structureItem->AddField(Data::ValueItem<int>::Create("BInt", 9876));
		structureItem->AddField(Data::ValueItem<std::string>::Create("SomeData", "More Text Data"));

		return true;
	}
	static constexpr const char Name[] = "TestStruct2";
};

class TestStruct : public StructWrapper
{
public:
	TestStruct(Data::StructurePtr structPtr) : StructWrapper(structPtr) { Validate("TestStruct"); }

	inline const float& GetAFloat() const { return GetField<float>("AFloat"); }
	inline void SetAFloat(const float& value) { return SetField<float>("AFloat", value); }

	inline const int& GetAInt() { return GetField<int>("AInt"); }
	inline void SetAInt(const int& value) { return SetField<int>("AInt", value); }

	inline const std::string& GetAString() { return GetField<std::string>("AString"); }
	inline void SetAString(const std::string& value) { return SetField<std::string>("AString", value); }

	inline TestStruct2 GetStructField() { return std::move(ExtractStructFromField<TestStruct2>("StructField")); }

	inline static bool Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<float>::Create("AFloat", 10.0f));
		structureItem->AddField(Data::ValueItem<int>::Create("AInt", 1234));
		structureItem->AddField(Data::ValueItem<std::string>::Create("AString", "Some Text Data"));

		StructureDb::CreateStructure(TestStruct2::Name, "StructField", structureItem);

		return true;
	}
	static constexpr const char Name[] = "TestStruct";

};