#pragma once

struct ModuleState
{
	bool Init = false;
	bool Run = false;
};

enum class ModuleID
{
	Communications = 0,
	Engineering,
	Helm,
	Medical,
	Navigation,
	Sciences,
	LastModule,
};

ModuleState& GetModuleState(ModuleID moduleId);