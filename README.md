StarshipSimEngine
=================
A modern implementation of the simulation system presented in Roger Garrett's
book The Complete STAR SHIP: A Simulation Project.

Overview
=================
This project is an attempt to do a modern implementation of the concepts
presented in the Dilithium Book by Roger Garrett.

Since the book was written in 1978, many of the programming concepts are not
viable or would at least be in-efficient on modern systems, but the core 
concepts presented as part of the simulation are very sound. Some of the ideas
are exceptionally detailed, especially for the capabilities of systems that
existed at the time of writing. Thankfully many of the limitations of the time
have been overcome, specifically with regards to CPU power, Memory, 
and Networking bandwidth, and are no longer limiting factors.

The goal of this project is not centred around graphics of console displays
for StarShip Simulation but the creation of a stable simulation core. This core
will be able to simulate one or more star ships in a universe with significantly
higher granularity then that presented in the book. It will take modern 
computing enhancements into account such as data structures, multi-threading,
networking, and extensibility.

Implementation
=================
The initial implementation will be done as a Managed DLL written in the C# 
language. This library will be compatible with the Microsoft Windows .Net 
platform as well as the cross platform MONO framework.

Data Structures
=================
The data layout defined in the book makes use of a common data block to store
global variables and made heavy use of static arrays. This method is not
optimal for modern languages so the use of data structures and classes
are used.

Data Layout
=================
The data presented in the book has been greatly expanded and built into a set
of data structures. These data structures are stored in a tree to simulate 
proper containment of items.

The Top level tree contains
	Galaxy
		Sectors
			Celestial Bodies
			Vessels
			Free Actors
			
Celestial bodies and vessels derived from an entity class and contains many
of the same things. The main differentiating factor is the Vessels can be
Crewed by players using Command Controllers. 

Actors are mobile objects that can be attached to an Entity and move throughout
it's internal locations as well as exist in free space. Actors represent things
such as Persons, Cargo, and Weapons such as Torpedoes. The internal locations
of an entity is a linked network of spaces that actors use and also contain 
various systems. Systems allow an entity to make changes in it's location,
use or generate various resources, and make changes to actors.

Locations
======
All entities have one or more internal locations. These locations are linked
together to form a tree of spaces that make up each vessel or planet. Each
location has a position, orientation, shape, and a list of connections. Each
Connection has a destination ID and a position where the transition to the new
location happens. This allows for a path generation system to be able to move 
from location to location. Each location also contains a maximum traversal speed
this speed is used by actors moving throughout the ship and can be radially
different for various sections, from very fast for turbo-lifts to very slow
for cramped areas such as the warp coils.


Control Layout
=================
In order to best manage human and AI crews and commanders, there will not be any
special version of a ship for players to use. The same ship entity class will be
used for all crews regardless of how it is run. Entities will have an attached
controller that determines how it's various systems are its actions. For player
ships this controller will contain the various crew stations that are manned
by actual humans and will be the repository for console specific data. AI ships
will use a similar class but will not need to be simulated in as much detail.
This system allows crew members and controllers to be moved from one ship to
another as needed. Examples include, a hostile crew taking control of a shuttle,
A player crew transferring to another ship, including a captured one, or a crew
being split across multiple ships/shuttles for advanced operations.

The player crew controller contains an actor for each human player and attaches
them to stations at specific locations in a ship. Player Actors can move from
station to station as needed, such as transferring from the main bridge to a 
more secure battle bridge.


Unit of Measurement
=================

Scales
======
In order to function on a 64 computer system several units of measure will be 
used for actions at different scales;

Galactic
	Coordinates at the galactic level are defined in light years from the
	galactic centrer. These coordinates are used to define where the local
	coordinate system of a sector is located. In general there are no speed
	values used at this scale as sector or galaxy movement is not simulated.
	
Sector
	Coordinates of items inside a sector are given defined in Kilometres. Normal
	Speeds are defined in Kilometres per Second (KPH). This includes vessels and 
	actors moving in sector space. Speeds may be defined in the FTL Scale of a 
	factor of the Speed of Light (FSL) and may exceed 1.0 for various FTL
	Systems. Solar Systems and other interesting areas may need to be
	defined as multiple sectors in order to provide usable resolution in
	coordinates.
	
Entity
	Coordinates of locations and actors within entities are defined in Meters.
	Speeds are defined in Meters Per Second (MPS)
	

Simulation Optimisation
=================
It may become difficult to simulate all aspects of every ship in the simulation
and optimisations will need to be made. There are several easy changes that can
be made to quickly reduce the processing power and memory required for ships
that do not have human crews.

Actor Packing
======
It is not necessary for these ships to have a complete and expanded crew list
with individual actors. A "Crew Package" actor can be used to represent the
entire crew as simple parametric data. This data can include the crew member
counts, passenger counts, and general flags for AI logic. Some information
about individual crew members may need to be stored, such as the captain's name,
in-case it is needed during interactions with player crews. If a ship is boarded
or otherwise scrutinized at a detailed level, the crew package can be unpacked
into a full set of crew actors. These actors can then follow the standard actor
rules until they are destroyed, captured, or are no longer interacting with
a crewed ship. 

The same can be done for Cargo. A cargo pack can be created that contains simple
parametric counts of items and materials. This pack can be extracted as needed
such as when the ship is destroyed and a portion of the cargo needs to be
converted to debris.

Ship Delta States
======
Similar to Actor Packing, many of the ship systems and internal locations can be
packaged as well. Most non player ships do not deviate from a the design of the 
ship class and can simply reference a static ship layout for it's performance
and system data. Changes an expenditures in the systems can be stored in a
parametric data block, possibly as an actor. This data would be modified as the
ship performed tasks and like the actor packs would be realized as complete
systems as needed. Damage and the use of various stores could be stored as 
as an event list of changes that would be applied when the systems were filled
out. The AI system for a ship with packed data would work to remove usage events
and return to the 'pure' state defined in the ship class when it was able to.

Open Questions
=================

Free Actors and Actor IDs
======
There is a distinct advantage to forcing actors to always be attached to an 
entity. This allows the Actor ID to be unique in the entities name space rather
then the global name space and massively increases the number of actors IDs
that are available. This would require that free floating actors such as 
torpedoes in flight, debris, and EVA crew members be attached to temporary 
entities for use in sector space. Simple entities that represent controlled
flight as well a drifting can be used with a single storage system for the actor
in question. The question comes up about boarding parties from one ship that are
using the internal locations of another ship. Each actor could contains the 
ID of it's parent, or some other system of giving those actors temporary local
IDs could be made(Boarding entity keeps source actors and maps to local actor
IDs?)

Serialization
======
The runtime classes for most things are not suited for serialization since they
are trees of contained items. Serializing the galaxy would write out all 
sub-objects including every sector, ship, planet, person, and cargo into a
single massive file. This obviously will not scale well and needs to be able to 
be broken up into multiple parts. A system must be made to be able to load 
objects from some sort of static definition. This definition can be XML or a 
database record and should simply contains ID references to other systems as 
needed.

TODO:
Ship Controller
Actor Modification Systems
Interior Shapes
Interior Connections and Paths
System Defs
Station class
	