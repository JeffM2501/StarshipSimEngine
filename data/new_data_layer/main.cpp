#include <stdio.h>

#include "Test.h"


void DumpStructure(Data::StructurePtr structPtr, int indent)
{
	for (auto field : structPtr->Fields)
	{
		for (int i = 0; i < indent; i++)
			printf("  ");

		printf("%s ", field.second->GetName());

		if (field.second->GetType() == Data::ItemTypes::Value)
		{
			printf("Value\n");
		}
		else
		{
			Data::StructurePtr fieldStruct = std::dynamic_pointer_cast<Data::StructureItem>(field.second);
			printf("Structure %s\n", fieldStruct->StructureName.c_str());
			DumpStructure(fieldStruct, indent + 1);
		}
	}
}

int main()
{
	RegisterTestStructs();

	Data::Path root;

	auto stucture = StructureDb::CreateStructure(TestStruct::Name, "test", root);

	DumpStructure(stucture, 0);

	TestStruct test(stucture);

	if (test.IsDirty())
		printf("dirty = true\n");

	printf("float = %f\n", test.GetAFloat());
	test.SetAFloat(1234.0f);
	printf("float = %f\n", test.GetAFloat());

	if (test.IsDirty())
		printf("dirty = true\n");

	return 0;
}