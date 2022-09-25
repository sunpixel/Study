#include <iostream>



void x_pyramid()
{
	int number, const_number, x_count, space_print;			// Инициализация переменных типа int
	std::cout << "Введите высоту пирамиды: ";				// Вывож текста для получения ответа от пользователя
	bool allow_print;
	std::cin >> const_number;								// Запрос на получение данных
	number = const_number - 1;
	while (number >= 0)
	{
		x_count = const_number - number;
		space_print = 1;
		allow_print = true;
		while (allow_print)
		{
			if (space_print <= number)
			{
				std::cout << ' ';
				space_print += 1;

			}
			else if (const_number >= space_print)
			{
				std::cout << "X";
				space_print += 1;
			}
			else
			{
				allow_print = false;
				std::cout << '\n';
			}
			
		}
		number -= 1;
	}
}



void factorial_finder()
{
	unsigned long long int factorial_number, number, factorial, iterations = 0;
	bool count = true;
	while (count)
	{
		std::cout << "Укажите число для поиска факториала: ";
		std::cin >> number;

		while (number != 0 or number < 0)
		{
			if (iterations == 0 and number != 0 or number < 0)
			{
				factorial_number = number;
				factorial = factorial_number * (factorial_number - 1);
				factorial_number -= 2;
				iterations += 1;
			}
			else if (iterations != 0 and factorial_number >= 2)
			{
				factorial = factorial * factorial_number;
				factorial_number -= 1;
				iterations += 1;
			}
			else
			{
				std::cout << factorial << std::endl;
				iterations = 0;
				factorial = 0;
				break;
			}
		}
		if (number == 0 or number > 0)
		{
			std::cout << "Число не подходит!!!";
			count = false;
		}
	}
}



void bank_offer()
{
	double money, precent;
	int years;
	std::cout << "Пожалуйста введите сумму стартового капитала, " <<
		"длительность вклада и процентую ставку\n";
	std::cin >> money, years, precent;
	
}



int main()
{
	setlocale(LC_ALL, "Russian");
	//x_pyramid();
	//factorial_finder();
	bank_offer();
}