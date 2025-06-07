#include <iostream>

# define ORANGE "\033[38;5;208m"
# define RESET "\033[0m"

/*
	Preset params test
*/
static void	drawTitle(const std::string &title, bool colour = false)
{
	if (colour)
		std::cout << ORANGE;
	std::cout << "\t\t" << title << RESET << std::endl;
}

int main(void)
{
	drawTitle("Titulo laranja", 1);
	drawTitle("Titulo sem cor");
	return (0);
}
