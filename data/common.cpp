#include "data/common.h"

namespace Data
{

	// Autogen structPositionalData
	bool PositionalData::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<Vector3D>::Create("Location", "Vector3D"));
		structureItem->AddField(Data::ValueItem<Vector3D>::Create("Velocity", "Vector3D"));
		structureItem->AddField(Data::ValueItem<double>::Create("Speed", 0, "double"));

		return true;
	}

	const Vector3D& PositionalData::GetLocation() const { return GetField<Vector3D>("Location"); }
	void PositionalData::SetLocation(const Vector3D& value) { return SetField<Vector3D>("Location", value); }

	const Vector3D& PositionalData::GetVelocity() const { return GetField<Vector3D>("Velocity"); }
	void PositionalData::SetVelocity(const Vector3D& value) { return SetField<Vector3D>("Velocity", value); }

	const double& PositionalData::GetSpeed() const { return GetField<double>("Speed"); }
	void PositionalData::SetSpeed(const double& value) { return SetField<double>("Speed", value); }

	// Autogen structLifeformData
	bool LifeformData::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<uint64_t>::Create("Quantity", 0, "uint64_t"));
		structureItem->AddField(Data::ValueItem<LifeformTypes>::Create("LifeformType", "LifeformTypes"));
		structureItem->AddField(Data::ValueItem<int>::Create("Intelligence", 0, "int"));

		return true;
	}

	const uint64_t& LifeformData::GetQuantity() const { return GetField<uint64_t>("Quantity"); }
	void LifeformData::SetQuantity(const uint64_t& value) { return SetField<uint64_t>("Quantity", value); }

	const LifeformTypes& LifeformData::GetLifeformType() const { return GetField<LifeformTypes>("LifeformType"); }
	void LifeformData::SetLifeformType(const LifeformTypes& value) { return SetField<LifeformTypes>("LifeformType", value); }

	const int& LifeformData::GetIntelligence() const { return GetField<int>("Intelligence"); }
	void LifeformData::SetIntelligence(const int& value) { return SetField<int>("Intelligence", value); }

	// Autogen structPhysicalData
	bool PhysicalData::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<double>::Create("Radius", 0, "double"));
		structureItem->AddField(Data::ValueItem<double>::Create("Mass", 0, "double"));
		structureItem->AddField(Data::ValueItem<RadiationType>::Create("Type", "RadiationType"));
		structureItem->AddField(Data::ValueItem<double>::Create("Intensity", 0, "double"));

		return true;
	}

	const double& PhysicalData::GetRadius() const { return GetField<double>("Radius"); }
	void PhysicalData::SetRadius(const double& value) { return SetField<double>("Radius", value); }

	const double& PhysicalData::GetMass() const { return GetField<double>("Mass"); }
	void PhysicalData::SetMass(const double& value) { return SetField<double>("Mass", value); }

	const RadiationType& PhysicalData::GetType() const { return GetField<RadiationType>("Type"); }
	void PhysicalData::SetType(const RadiationType& value) { return SetField<RadiationType>("Type", value); }

	const double& PhysicalData::GetIntensity() const { return GetField<double>("Intensity"); }
	void PhysicalData::SetIntensity(const double& value) { return SetField<double>("Intensity", value); }

	// Autogen structCelestialObject
	bool CelestialObject::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<int>::Create("ID", "int"));
		structureItem->AddField(Data::ValueItem<std::string>::Create("Name", "std::string"));
		structureItem->AddField(Data::ValueItem<bool>::Create("Charted", false, "bool"));
		structureItem->AddField(Data::ValueItem<CelstialClassifications>::Create("Classification", "CelstialClassifications"));
		DB::CreateStructure(PositionalData::Name, "Position", structureItem);
		DB::CreateStructure(PhysicalData::Name, "Physical", structureItem);
		DB::CreateStructure(LifeformData::Name, "Lifeforms", structureItem);
		DB::CreateContainer(DefensiveSystem::Name, "Defenses", structureItem);
		DB::CreateContainer(OffsensiveWeaponsSystem::Name, "OffensiveWeapons", structureItem);
		structureItem->AddField(Data::ValueItem<bool>::Create("FiredUpon", false, "bool"));
		structureItem->AddField(Data::ValueItem<bool>::Create("PeaceTreatyOffered", false, "bool"));
		structureItem->AddField(Data::ValueItem<bool>::Create("PeaceTreatyRequest", false, "bool"));

		return true;
	}

	const int& CelestialObject::GetID() const { return GetField<int>("ID"); }
	void CelestialObject::SetID(const int& value) { return SetField<int>("ID", value); }

	const std::string& CelestialObject::GetName() const { return GetField<std::string>("Name"); }
	void CelestialObject::SetName(const std::string& value) { return SetField<std::string>("Name", value); }

	const bool& CelestialObject::GetCharted() const { return GetField<bool>("Charted"); }
	void CelestialObject::SetCharted(const bool& value) { return SetField<bool>("Charted", value); }

	const CelstialClassifications& CelestialObject::GetClassification() const { return GetField<CelstialClassifications>("Classification"); }
	void CelestialObject::SetClassification(const CelstialClassifications& value) { return SetField<CelstialClassifications>("Classification", value); }

	PositionalData CelestialObject::GetPosition() const { return std::move(ExtractStructFromField<PositionalData>("Position")); }

	PhysicalData CelestialObject::GetPhysical() const { return std::move(ExtractStructFromField<PhysicalData>("Physical")); }

	LifeformData CelestialObject::GetLifeforms() const { return std::move(ExtractStructFromField<LifeformData>("Lifeforms")); }

	ContainerWrapper<DefensiveSystem> CelestialObject::GetDefenses() const { return std::move(ExtractContainerFromField<DefensiveSystem>("Defenses")); }

	ContainerWrapper<OffsensiveWeaponsSystem> CelestialObject::GetOffensiveWeapons() const { return std::move(ExtractContainerFromField<OffsensiveWeaponsSystem>("OffensiveWeapons")); }

	const bool& CelestialObject::GetFiredUpon() const { return GetField<bool>("FiredUpon"); }
	void CelestialObject::SetFiredUpon(const bool& value) { return SetField<bool>("FiredUpon", value); }

	const bool& CelestialObject::GetPeaceTreatyOffered() const { return GetField<bool>("PeaceTreatyOffered"); }
	void CelestialObject::SetPeaceTreatyOffered(const bool& value) { return SetField<bool>("PeaceTreatyOffered", value); }

	const bool& CelestialObject::GetPeaceTreatyRequest() const { return GetField<bool>("PeaceTreatyRequest"); }
	void CelestialObject::SetPeaceTreatyRequest(const bool& value) { return SetField<bool>("PeaceTreatyRequest", value); }

	// Autogen structSphere
	bool Sphere::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<Vector3D>::Create("Center", "Vector3D"));
		structureItem->AddField(Data::ValueItem<double>::Create("Radius", "double"));

		return true;
	}

	const Vector3D& Sphere::GetCenter() const { return GetField<Vector3D>("Center"); }
	void Sphere::SetCenter(const Vector3D& value) { return SetField<Vector3D>("Center", value); }

	const double& Sphere::GetRadius() const { return GetField<double>("Radius"); }
	void Sphere::SetRadius(const double& value) { return SetField<double>("Radius", value); }

	// Autogen structUniverse
	bool Universe::Create(const std::string& stucture, Data::StructurePtr structureItem)
	{
		structureItem->AddField(Data::ValueItem<Vector3D>::Create("Maxium", "Vector3D"));
		structureItem->AddField(Data::ValueItem<Vector3D>::Create("Minium", "Vector3D"));
		DB::CreateContainer(CelestialObject::Name, "Objects", structureItem);
		DB::CreateStructure(Sphere::Name, "RomulonEmpire", structureItem);
		DB::CreateStructure(Sphere::Name, "KlingonEmpire", structureItem);

		return true;
	}

	const Vector3D& Universe::GetMaxium() const { return GetField<Vector3D>("Maxium"); }
	void Universe::SetMaxium(const Vector3D& value) { return SetField<Vector3D>("Maxium", value); }

	const Vector3D& Universe::GetMinium() const { return GetField<Vector3D>("Minium"); }
	void Universe::SetMinium(const Vector3D& value) { return SetField<Vector3D>("Minium", value); }

	ContainerWrapper<CelestialObject> Universe::GetObjects() const { return std::move(ExtractContainerFromField<CelestialObject>("Objects")); }

	Sphere Universe::GetRomulonEmpire() const { return std::move(ExtractStructFromField<Sphere>("RomulonEmpire")); }

	Sphere Universe::GetKlingonEmpire() const { return std::move(ExtractStructFromField<Sphere>("KlingonEmpire")); }
	// Registration function
	void RegisterCommonStructs()
	{
		DB::AddStructureDef(PositionalData::Name, PositionalData::Create); 
		DB::AddStructureDef(LifeformData::Name, LifeformData::Create); 
		DB::AddStructureDef(PhysicalData::Name, PhysicalData::Create); 
		DB::AddStructureDef(CelestialObject::Name, CelestialObject::Create); 
		DB::AddStructureDef(Sphere::Name, Sphere::Create); 
		DB::AddStructureDef(Universe::Name, Universe::Create); 
	}

}
