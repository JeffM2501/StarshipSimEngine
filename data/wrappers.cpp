#include "data/wrappers.h"

namespace Data
{
	// StructWrapper
	StructWrapper::StructWrapper(Data::Item::Ptr structPtr)
		: StructData(std::dynamic_pointer_cast<Data::StructureItem>(structPtr))
	{}

	bool StructWrapper::IsDirty()
	{
		return StructData != nullptr && StructData->IsDirty();
	}

	void StructWrapper::Validate(const char* name)
	{
		if (StructData == nullptr)
			throw("Invalid Structure Pointer");

		if (StructData->DataTypeName != name)
			throw("Incorrect Structure Type");
	}
}