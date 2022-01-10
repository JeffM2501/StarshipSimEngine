#pragma once

#include <vector>
#include <string>

class Path
{
public:
	std::vector<std::string> Elements;

	inline void Append(const std::string& element)
	{
		Elements.emplace_back(element);
	}

	inline const char* Head()
	{
		if (Elements.size() == 0)
			return nullptr;

		return Elements[0].c_str();
	}

	inline const char* Tail()
	{
		if (Elements.size() == 0)
			return nullptr;

		return Elements.rbegin()->c_str();
	}
};