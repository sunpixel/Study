// number 12

#include<iostream>
#include<math.h>

double function(float a)
{
	a = 2 * sin(0.6 - a) + 1.5;
	return a * -1;
}


float method_1()
{
	
	double a;
	double b;
	double eps;
	bool correct = false;
	while (not correct) 
	{
		std::cout << "Введите начало отрезка: ";
		std::cin >> a;
		std::cout << "Введите конеч отрезка: ";
		std::cin >> b;
		if (a <= b)
		{
			correct = true;
		}
		std::cout << "Введите желаемую точность: ";
		std::cin >> eps;
		if (abs(a) + abs(b) > eps)
		{
			correct = true;
		}
	}

	// fabs(12) абсолютное значение функции (модуль)

	double c = 0;
	int counter = 0;
	while (fabs(b - a) > eps)
	{
		c = (a + b) / 2;
		if (function(a) * function(c) < 0)
		{
			b = c;
		}
		else if (function(b) * function(c) < 0)
		{
			a = c;
		}
		else
		{
			std::cout << "No root found.\n";
			break;
		}
		counter++;
	}
	std::cout << "x ~= " << c << "\nС точностью " << eps << "\nИ колличеством итераций = " << counter << std::endl;
	return 0;
}



float method_2()
{
	return 0;
}



bool next()
{
	char answer;
	bool loop = true;
	while (loop)
	{
		std::cout << "Желаете продолжить? (y/n)\n";
		std::cin >> answer;
		if (answer == 'n' or answer == 'N')
		{
			return false;
		}
		else if (answer == 'y' or answer == 'Y')
		{
			return true;
		}
		else
		{
			std::cout << "Введенно не верное значение, введите 'y' or 'n' для продолжения.\n";
		}
	}
}



void choice()
{
	int x;
	bool loop = true;
	while (loop)
	{
		std::cout << "Введите номер задания от 1-5 или 0 для завершения программы: ";
		std::cin >> x;
		if (x == 1)
		{
			method_1();
			loop = next();
		}
		else if (x == 2)
		{
			method_2();
			loop = next();
		}
		else
		{
			std::cout << "Выбранного задания не существует. Выберите другое!\n";
		}
	}
	std::cout << "Завершение программы.\n";
}



int main()
{
	setlocale(LC_ALL, "Russian");
	choice();
}
