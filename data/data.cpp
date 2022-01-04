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