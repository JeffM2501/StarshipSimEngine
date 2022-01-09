#pragma once

#include "data/data.h"

namespace Data
{
	template<class T>
	class ContainerWrapper
	{
	public:
		ContainerWrapper(std::shared_ptr<Data::ContainerItem> containerData);

		const std::string& GetContanerType();
		void AddValue(int key, T value);
		void RemoveValue(int key);

		T GetValue(int key) const;
		T GetValue(const std::string& name) const;
		std::vector<int> GetKeys() const;

	protected:
		std::shared_ptr<Data::ContainerItem> ContainerData;

		std::string ContainerType;

		void Validate();
	};

	class StructWrapper
	{
	public:
		StructWrapper(Data::StructurePtr structPtr);
		bool IsDirty();

	protected:
		void Validate(const char* name);

		template<class T>
		const T& GetField(const std::string& name) const;

		template<class T>
		void SetField(const std::string& name, const T& value);

		template<class T>
		T ExtractStructFromField(const std::string& name) const;

		template <class T>
		ContainerWrapper<T> ExtractContainerFromField(const std::string& name) const;

		Data::StructurePtr StructData;
	};

	template<class T>
	T GetDataWrapper(const Path& path);
}