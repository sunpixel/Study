#define _USE_MATH_DEFINES
#include <iostream>
#include <math.h>
#include <iomanip>



// number 12


class labratory_7
{

public:
	double r_answer = 0.34657;
	//double pi = M_PI;				// defines the value of PI
	double result = 0;				// Final result value
	double ctg = 0;
	double eps = 0;					// Value of eps
	int idenitfire = 0;
	double val1 = M_PI / 2;							// top // end
	double val2 = M_PI / 4;							// bot // start
	double div_equaly = 1;							// Default value of how many smaller parts we want
	double number_of_points = div_equaly + 1;		// Defines how many X there are
	double step = (val1 - val2) / div_equaly;		// Value of step till the next part
	double x = val2;								// current value
	double inaccuracy = 0;

private:



	double f_c(double z);
	void step_calculation_formula();
	double calculation();


public:


	void main_body()
	{

		std::cout << "\nPlease enter inaccuracy: ";
		std::cin >> eps;
		std::cout << "\nPlease enter number of divisions: ";
		std::cin >> div_equaly;
		std::cout << "n    Approximate value    Inaccuracy\n";
		while (true)
		{
			std::cout << idenitfire << "    " << calculation() << "          " << inaccuracy << std::endl;
			if (inaccuracy <= eps) break;
		}

		// Approximate value	// Погрешность	// Отношение погрешностей к друг другу

	}


};



double labratory_7::f_c(double z)
{
	double x = cos(z) / sin(z);
	return x;
}

void labratory_7::step_calculation_formula()
{

	std::cout << "\nThis is an extreme measure do not use it, unless asked to explicitly!!!\n";
	double a, b = 0;
	std::cout << "Please enter the starting point... (bottom number)\n";
	std::cin >> a;
	std::cout << "Please enter the ending point... (top number)\n";
	std::cin >> b;
	if (a == 0 and b == 0)
	{
		std::cout << "\n As the length of the step = 0, the default values will be applied\n";
		step = (val1 - val2) / div_equaly;
	}
	else
	{
		std::cout << "\nValue are being applied\n";
		val1 = b;	// top number
		val2 = a;	// bot number
		step = (val1 - val2) / div_equaly;
	}
}

double labratory_7::calculation()
{
	int iter = 0;
	double num1, num2 = 0;
	if (iter == 0)
	{
		num1 = f_c(val2);
		num2 = f_c(val1);
		x = (num1 + num2) / 2;
	}
	else
	{
		x = x + (f_c(val2 + step * iter));
	}
	inaccuracy = x - r_answer;
	iter++;
	return x;
}



class labratory_8
{
public:

	void main_body()
	{

	}

private:

};




bool next()
{
	int a = 0;
	bool cont = false;
	int iter = -1;
	std::cout << "Do you want to continue?\n Type 0 to stop\n Type 1 to continue\n";
	while (not cont)
	{
		std::cin >> a;
		if (a == 0 or a == 1)
		{
			cont = true;
			return (a);
		}
		else if (iter <= 3)
		{
			iter++;
			cont = false;
			std::cout << "\nPlease choose a valid answer: ";
		}
		else {
			cont = true;
			return false;
		}
	}
	return false;
}


void choice()
{
	labratory_7 l7_1;
	labratory_8 l8_1;
	int a;
	bool cont = false;
	while (not cont)
	{
		std::cout << "Please choose which work do u want to review:\n 0 - for lab 7\n 1 - for lab 8\n";
		std::cin >> a;
		if (a == 0) { l7_1.main_body(); if (next()) { cont = false; } else { cont = true; } }
		else if (a == 1) { l8_1.main_body(); if (next()) { cont = false; } else { cont = true; } }
		else { std::cout << "Number you have selected is not in the list.\nPlease try again!\n\n"; continue; }
	}
}

int main()
{
	choice();
	std::cout << "\n-------------------------------\nProgram finished\n";
}
