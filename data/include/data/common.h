#pragma once
#include "data/data.h"
#include "data/wrappers.h"
#include "data/systems.h"
#include <memory>

namespace Data
{

	//Enums
	enum class CelstialClassifications
	{
		Unknown = 0,
		Star = 1,
		Singularity = 2,
		ParticleCloud = 3,
		TimeWarp = 4,
		Planet = 5,
		Moon = 6,
		Nova = 7,
		LastCelstialClassifications = 8
	};

	enum class LifeformTypes
	{
		None = 0,
		Humanoid = 1,
		Vegitation = 2,
		Aquatic = 3,
		Self = 4,
		LastLifeformTypes = 5
	};

	enum class RadiationType
	{
		None = 0,
		Light = 1,
		Radiation = 2,
		LastRadiationType = 3
	};


	// Autogen struct PositionalData
	class PositionalData : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "PositionalData";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		PositionalData(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("PositionalData");}

		const Vector3D& GetLocation() const;
		void SetLocation(const Vector3D& value);

		const Vector3D& GetVelocity() const;
		void SetVelocity(const Vector3D& value);

		const double& GetSpeed() const;
		void SetSpeed(const double& value);
	};

	// Autogen struct LifeformData
	class LifeformData : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "LifeformData";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		LifeformData(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("LifeformData");}

		const uint64_t& GetQuantity() const;
		void SetQuantity(const uint64_t& value);

		const LifeformTypes& GetLifeformType() const;
		void SetLifeformType(const LifeformTypes& value);

		const int& GetIntelligence() const;
		void SetIntelligence(const int& value);
	};

	// Autogen struct PhysicalData
	class PhysicalData : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "PhysicalData";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		PhysicalData(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("PhysicalData");}

		const double& GetRadius() const;
		void SetRadius(const double& value);

		const double& GetMass() const;
		void SetMass(const double& value);

		const RadiationType& GetType() const;
		void SetType(const RadiationType& value);

		const double& GetIntensity() const;
		void SetIntensity(const double& value);
	};

	// Autogen struct CelestialObject
	class CelestialObject : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "CelestialObject";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		CelestialObject(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("CelestialObject");}

		const int& GetID() const;
		void SetID(const int& value);

		const std::string& GetName() const;
		void SetName(const std::string& value);

		const bool& GetCharted() const;
		void SetCharted(const bool& value);

		const CelstialClassifications& GetClassification() const;
		void SetClassification(const CelstialClassifications& value);

		class PositionalData GetPosition() const;

		class PhysicalData GetPhysical() const;

		class LifeformData GetLifeforms() const;

		ContainerWrapper<DefensiveSystem> GetDefenses() const;

		ContainerWrapper<OffsensiveWeaponsSystem> GetOffensiveWeapons() const;

		const bool& GetFiredUpon() const;
		void SetFiredUpon(const bool& value);

		const bool& GetPeaceTreatyOffered() const;
		void SetPeaceTreatyOffered(const bool& value);

		const bool& GetPeaceTreatyRequest() const;
		void SetPeaceTreatyRequest(const bool& value);
	};

	// Autogen struct Sphere
	class Sphere : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "Sphere";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		Sphere(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("Sphere");}

		const Vector3D& GetCenter() const;
		void SetCenter(const Vector3D& value);

		const double& GetRadius() const;
		void SetRadius(const double& value);
	};

	// Autogen struct Universe
	class Universe : public Data::StructWrapper
	{
	public:
		static constexpr const char Name[] = "Universe";
		static bool Create(const std::string& stucture, Data::StructurePtr structureItem);

		Universe(Data::Item::Ptr structPtr) : StructWrapper(structPtr) { Validate("Universe");}

		const Vector3D& GetMaxium() const;
		void SetMaxium(const Vector3D& value);

		const Vector3D& GetMinium() const;
		void SetMinium(const Vector3D& value);

		ContainerWrapper<CelestialObject> GetObjects() const;

		class Sphere GetRomulonEmpire() const;

		class Sphere GetKlingonEmpire() const;
	};

	// Registration function
	void RegisterCommonStructs();

}
