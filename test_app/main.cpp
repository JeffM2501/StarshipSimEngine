#include <stdio.h>

#include "controller.h"

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