#include "data/data.h"

#include <unordered_map>

std::unordered_map<int, ModuleState> ModuleStates;

void InitData()
{

}

ModuleState& GetModuleState(ModuleID moduleId)
{
	return ModuleStates[int(moduleId)];
}


DataSet RootSet;

DataSet& GetSetForPath(const std::string& path)
{

}

DataVariable::Ptr GetVariable(const DataPath& path, const std::string& name)
{

}

DataVariable::Ptr CreateVariable(const DataPath& path, DataVariable::Ptr variable)
{
	return variable;
}
