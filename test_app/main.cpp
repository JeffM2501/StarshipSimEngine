#include <stdio.h>

#include "sim_controller/module.h"

int main()
{
	printf("Starship Simulation Project\n");
	printf("Startup\n");

	InitSimController();

	bool running = true;

	while (running)
	{
		UpdateSimController();
	}


	return 0;
}