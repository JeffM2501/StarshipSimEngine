#pragma once

#pragma once

#include "data/module_data.h"

#include <string>
#include <list>
#include <map>
#include <memory>

struct Vector2D
{
	double X = 0;
	double Y = 0;
};

struct Vector3D
{
	double X = 0;
	double Y = 0;
	double Z = 0;
};

enum class DataVariableTypes
{
	String,
	Integer,
	FloatingPoint,
	Flag,
	Vector2,
	Vector3,
	List,
	Map,
};

class DataVariable
{
public:
	DataVariable(const char* name, DataVariableTypes dataType = DataVariableTypes::Flag) : Name(name), DataType(dataType) {}

	inline const char* GetName() { return Name.c_str(); }
	inline DataVariableTypes GetType() { return DataType; }

	inline virtual const char* GetValueString() { return nullptr; }
	inline virtual int GetValueInt() { return 0; }
	inline virtual double GetValueFloatingPoint() { return 0; }
	inline virtual bool GetValueFlag() { return false; }
	inline virtual DataVariable* GetValueVariable(int key) { return nullptr; }

	inline virtual bool IsDirty() { return Dirty; }

	inline virtual void RestoreDefault() {}

	inline virtual void SetValue(const char* value) {}
	inline virtual void SetValue(int value) {}
	inline virtual void SetValue(double value) {}
	inline virtual void SetValue(bool value) {}
	inline virtual void SetValue(int index, DataVariable* variable) {}

	using Ptr = std::shared_ptr<DataVariable>;

protected:
	std::string Name;
	DataVariableTypes DataType = DataVariableTypes::Flag;

	bool Dirty = false;
};

class IntVariable : public DataVariable
{
public:
	IntVariable(const char* name) 
		: DataVariable(name, DataVariableTypes::Integer)
	{
	}

	IntVariable(const char* name, int defaultValue)
		: DataVariable(name, DataVariableTypes::Integer)
		, Value(defaultValue)
		, Default(defaultValue)
	{
	}

	inline int GetValueInt() override { return Value; }
	inline void SetValue(int value) override { Dirty = true; Value = value; }

	inline void RestoreDefault() override { Value = Default; Dirty = false; }

protected:
	int Value = 0;
	int Default = 0;
};

class FloatingPointVariable : public DataVariable
{
public:
	FloatingPointVariable(const char* name)
		: DataVariable(name, DataVariableTypes::FloatingPoint)
	{
	}

	FloatingPointVariable(const char* name, double defalt)
		: DataVariable(name, DataVariableTypes::Integer)
		, Value(defalt)
	{
	}

	inline double GetValueFloatingPoint() override { return Value; }
	inline void SetValue(double value) override { Value = value; }

protected:
	double Value = 0;
};

class FlagVariable : public DataVariable
{
public:
	FlagVariable(const char* name)
		: DataVariable(name, DataVariableTypes::Flag)
	{
	}

	FlagVariable(const char* name, bool defalt)
		: DataVariable(name, DataVariableTypes::Flag)
		, Value(defalt)
	{
	}

	inline bool GetValueFlag() override { return Value; }
	inline void SetValue(bool value) override { Value = value; }

protected:
	bool Value = false;
};

class StringVariable : public DataVariable
{
public:
	StringVariable(const char* name)
		: DataVariable(name, DataVariableTypes::String)
	{
	}

	StringVariable(const char* name, const std::string& defalt)
		: DataVariable(name, DataVariableTypes::String)
		, Value(defalt)
	{
	}

	inline const char* GetValueString() override { return Value.c_str(); }
	inline void SetValue(const char* value) override { Value = value; }

protected:
	std::string Value;
};

class ListVariable : public DataVariable
{
public:
	ListVariable(const char* name)
		: DataVariable(name, DataVariableTypes::List)
	{
	}

	inline DataVariable* GetValueVariable(int key) override
	{ 
		if (key < 0 || key >= Values.size())
			return nullptr;

		return Values[key].get();
	}

	template <class T>
	inline T* GetValueVariable(int key)
	{
		if (key < 0 || key >= Values.size())
			return nullptr;

		return static_cast<T*>(Values[key].get());
	}

	inline void AppendVariable(DataVariable::Ptr ptr)
	{
		Values.push_back(ptr);
	}

	inline void RemoveVariable(int key)
	{
		if (key < 0 || key >= Values.size())
			return;

		Values.erase(Values.begin() + key);
	}

	inline size_t GetSize()
	{
		return Values.size();
	}

	inline void Clear()
	{
		Values.clear();
	}

protected:
	std::vector<DataVariable::Ptr> Values;
};

class MapVariable : public DataVariable
{
public:
	MapVariable(const char* name)
		: DataVariable(name, DataVariableTypes::Map)
	{
	}

	inline DataVariable* GetValueVariable(int key) override
	{
		std::map<int, DataVariable::Ptr>::iterator itr = Values.find(key);
		if (itr == Values.end())
			return nullptr;

		return itr->second.get();
	}

	template <class T>
	inline T* GetValueVariable(int key)
	{
		std::map<int, DataVariable::Ptr>::iterator itr = Values.find(key);
		if (itr == Values.end())
			return nullptr;

		return static_cast<T*>(itr->second.get()));
	}

	inline void InsertVariable(int key, DataVariable::Ptr ptr)
	{
		Values.insert_or_assign(key, ptr);
	}

	inline void RemoveVariable(int key)
	{
		std::map<int, DataVariable::Ptr>::iterator itr = Values.find(key);
		if (itr == Values.end())
			return;

		Values.erase(itr);
	}

	inline std::vector<int> GetKeys()
	{
		std::vector<int> keys;
		for (auto itr : Values)
			keys.push_back(itr.first);

		return keys;
	}

	inline void Clear()
	{
		Values.clear();
	}

protected:
	std::map<int, DataVariable::Ptr> Values;
};