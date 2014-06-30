Coolant Test:
License MIT
Copyright 2014 Jeffrey Myers

============

This is a test framework for a starship coolant system.
It works by adding having ship systems create heat as they are powered. Each 
system is connected to the coolant system and can be feed a maximum amount of 
coolant at a time. The coolant removes an amount of heat from the system based 
on how much coolant is flowing into the system and the temperature differential
between the coolant and the system. Heat can only move out of a system if the
coolant is at a lower temperature (TODO, heat system up if coolant is hotter).
As heat is transferred to the coolant system, it is buffered by the amount
of coolant in the system and slowly raises it's temperature.

The coolant system has a heat sink attached to it that removes a fixed amount
of heat over time. The coolant system can have multiple coolant reservoirs
attached. These are extra pools of coolant that can be piped into the 
coolant network for additional cooling. Reservoirs maintain there own
temperature and heat/cool when connected to the system. They can be flushed
to space if desired, a good way to dump a lot of heat. They can also be 
refilled with new coolant at stations. If the main coolant system is low
it can be filled from a reservoir as well.

The test application will show a sample ship with several systems that 
generate heat at different rates. The application shows bars for system
power, temperature, and coolant flow. The user can adjust the power levels
as well as the coolant assigned to each system and see how the coolant
system will respond. The sample ship also includes 2 reservoirs that start
unconnected. Some systems are can activate(beams) and will generate heat when
the activate button is pressed.

The sample ship is saved as an XML file after the first launch and can be
edited for to verify different configurations.

Some of the data constants still need some tweaks but overall the system shows
how a complex coolant system could work.

The code is located on github at 
https://github.com/JeffM2501/StarshipSimEngine/tree/master/ShipTests

It is a C# application that uses .net 3.5 so it should work on windows
and linux using mono. The project file is included for Visual Studio 2013