#include <stdio.h>

#include "sim_controller/module.h"
#include "data/data.h"
#include "data/data_types.h"

void PrintTabs(int count)
{
	for (int i = 1; i < count; i++)
		printf("\t");
}

std::string ValueToString(Data::Item::Ptr value)
{
	if (value->GetType() != Data::ItemTypes::Value)
		return value->DataTypeName;

	if (value->DataTypeName == "int")
		return std::to_string(std::dynamic_pointer_cast<Data::ValueItem<int>>(value)->GetValue());
	if (value->DataTypeName == "float")
		return std::to_string(std::dynamic_pointer_cast<Data::ValueItem<float>>(value)->GetValue());
	if (value->DataTypeName == "double")
		return std::to_string(std::dynamic_pointer_cast<Data::ValueItem<double>>(value)->GetValue());
	if (value->DataTypeName == "std::string")
		return std::dynamic_pointer_cast<Data::ValueItem<std::string>>(value)->GetValue();
	if (value->DataTypeName == "bool")
		return std::dynamic_pointer_cast<Data::ValueItem<bool>>(value)->GetValue() ? "true" : "false";
	if (value->DataTypeName == "Vector3D")
	{
		const Vector3D& v = std::dynamic_pointer_cast<Data::ValueItem<Vector3D>>(value)->GetValue();
		return "X" + std::to_string(v.X) + " Y" + std::to_string(v.Y) + " Z" + std::to_string(v.Z);
	}
	if (value->DataTypeName == "Vector2D")
	{
		const Vector2D& v = std::dynamic_pointer_cast<Data::ValueItem<Vector2D>>(value)->GetValue();
		return "X" + std::to_string(v.X) + " Y" + std::to_string(v.Y);
	}
	return value->DataTypeName;
}

void DumpDataStructures(int indent, Data::Item::Ptr itemPtr)
{
	PrintTabs(indent);
	printf("%s(%s)\n", itemPtr->GetName(), itemPtr->DataTypeName.c_str());
	PrintTabs(indent);
	indent++;

	switch (itemPtr->GetType())
	{
	case Data::ItemTypes::Structure:
	{
		printf(" [%s]\n", "Structure");
		auto structPtr = std::dynamic_pointer_cast<Data::StructureItem>(itemPtr);
		for (auto field : structPtr->Fields)
		{
			DumpDataStructures(indent, field.second);
		}
	}
	break;

	case Data::ItemTypes::Container:
	{
		printf(" [%s]\n", "Container");
		auto containerPtr = std::dynamic_pointer_cast<Data::ContainerItem>(itemPtr);
		for (auto key : containerPtr->GetKeys())
		{
			DumpDataStructures(indent, containerPtr->GetValue(key));
		}
	}

	case Data::ItemTypes::Value:
	{
		printf(" Value = %s\n", ValueToString(itemPtr).c_str());
	}
	break;
	}
}

int main()
{
	printf("Starship Simulation Project\n");
	printf("Startup\n");

	InitSimController();

	DumpDataStructures(0, Data::GetDataItem(Path::Root()));

	bool running = true;

	while (running)
	{
		UpdateSimController();
	}

	return 0;
}