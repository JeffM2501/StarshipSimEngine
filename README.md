StarshipSimEngine
=================

Modern implementation of the the simulation system presented in Roger Garrett's
book The Complete STAR SHIP: A Simulation Project.

Overview
=================
This project is an attempt to do a modern implementation of the concepts
presented in the Dilithium Book by Roger Garrett.

Since the book was written in 1978, many of the programming concepts are not
viable or would at least be in-efficient on modern systems, but the core 
concepts presented as part of the simulation are very sound. Some of the ideas
are exceptionally detailed and nuanced especially for the capabilities of systems
that existed at the time of writing. Thankfully many of the limitations that
existed back then have been overcome, specifically with regards to CPU power, 
Memory, and Networking bandwidth, and are no longer limiting factors.

The goal of this project is not centred around graphics of console displays
for StarShip Simulation but the creation of a stable simulation core. This core
will be able to simulate one or more star ships in a universe with significantly
higher granularity then that presented in the book. It will take modern computing
enhancements into account such as data structures, multi-threading, networking,
and extensibility.

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

Changes
=================

	Personnel and Cargo items
	=================
		Cargo and People data structures share the base class Actor
		Actor Data  Members
			Mass
			Location
			Desired Location
			
		Personnel Data Structure
		=================
		Food and Water Consumptions changed from per hour to fixed amounts on a regular cycle
		
		Cargo Data Structure
		=================
		Additional Cargo Types
			Repair Parts
			Torpedo
		Additional Data Members
			Quantity
			Mass
	
TODO:
Ship Controller
Players as Actors
Stations in sections
Actor Modification Systems
Torpedoes as Actors

	