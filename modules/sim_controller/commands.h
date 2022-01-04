#pragma once

#include <functional>
#include <vector>
#include <unordered_map>
#include <string>

enum class SimulationCommands
{
	Unknown,
	InitAllModules,
	InitModule,

};

struct SimulationData
{
	SimulationCommands Command = SimulationCommands::Unknown;
	std::vector<int> IntArgs;
	std::vector<float> FloatArgs;
	std::vector<std::string> StringArgs;
};

using SimEventHandler = std::function<void(const SimulationData&)>;

extern std::unordered_map<SimulationCommands, SimEventHandler> SimEventHandlers;


void AddSimulationInput(const SimulationData& data);