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
		T AddValueDefault(int key);
		void RemoveValue(int key);

		T GetValue(int key) const;
		T GetValue(const std::string& name) const;
		std::vector<int> GetKeys() const;

		bool IsEmpty();
		size_t Size();


		inline bool Valid() const { return ContainerData != nullptr; }

	protected:
		std::shared_ptr<Data::ContainerItem> ContainerData;

		void Validate();
	};

	class StructWrapper
	{
	public:
		StructWrapper(Data::StructurePtr structPtr);
		bool IsDirty();

		template<class T>
		const T& GetField(const std::string& name) const;

		template<class T>
		void SetField(const std::string& name, const T& value);

		template<class T>
		T ExtractStructFromField(const std::string& name) const;

		template <class T>
		ContainerWrapper<T> ExtractContainerFromField(const std::string& name) const;

		inline bool Valid() const { return StructData != nullptr; }

		Data::StructurePtr StructData;

	protected:
		void Validate(const char* name);
	};

	template<class T>
	T GetDataWrapper(const Path& path);

	template<class T>
	T GetDataWrapper(const Item::Ptr& ptr);
}