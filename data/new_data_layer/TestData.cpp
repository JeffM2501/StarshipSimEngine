#include "TestData.h"


void RegisterTestStructs()
{
	StructureDb::AddStructureDef(TestStruct::Name, TestStruct::Create);
	StructureDb::AddStructureDef(TestStruct2::Name, TestStruct2::Create);
}