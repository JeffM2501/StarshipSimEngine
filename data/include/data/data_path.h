#pragma once

#include <vector>
#include <string>

class Path
{
public:
	std::vector<std::string> Elements;

	inline const Path& Append(const std::string& element)
	{
		Elements.emplace_back(element);
		return *this;
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

	Path() {}
	Path(const std::string& element)
	{
		Append(element);
	}

	Path(const Path& path)
	{
		Elements = path.Elements;
	}

	Path(const Path& path, const std::string& element)
	{
		Elements = path.Elements;
		Append(element);
	}

	static const Path& Root();
};