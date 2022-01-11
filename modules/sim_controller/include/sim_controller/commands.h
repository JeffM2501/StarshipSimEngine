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

class SimulationData
{
public:
	SimulationCommands Command = SimulationCommands::Unknown;
	std::vector<int> IntArgs;
	std::vector<float> FloatArgs;
	std::vector<std::string> StringArgs;

	SimulationData(SimulationCommands cmd) : Command(cmd){}
	SimulationData(SimulationCommands cmd, int arg);
	SimulationData(SimulationCommands cmd, float arg);
	SimulationData(SimulationCommands cmd, const std::string& arg);
};

using SimEventHandler = std::function<void(const SimulationData&)>;

extern std::unordered_map<SimulationCommands, SimEventHandler> SimEventHandlers;


void AddSimulationInput(const SimulationData& data);