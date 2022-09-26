#include <iostream>



void x_pyramid()
{
	int number, const_number, x_count, space_print;			// Инициализация переменных типа int
	std::cout << "Введите высоту пирамиды: ";				// Вывож текста для получения ответа от пользователя
	bool allow_print;
	std::cin >> const_number;								// Запрос на получение данных
	number = const_number - 1;								// Полчуние колличества " " на первой строке
	while (number >= 0)
	{
		x_count = const_number - number;					// Вычесление колличества X в строке
		space_print = 1;									// Перемнная для понятия сколько пробелов было напечатанно
		allow_print = true;									// Переменная отвечающая за написание пробелов и X на одной строке
		while (allow_print)
		{
			if (space_print <= number)						// Пока колличество пробелов меньше либо равно числу пробелов в строке
			{
				std::cout << ' ';							// Печать пробела
				space_print += 1;							// Добавление 1 к колличеству напечатанных пробелов

			}
			else if (const_number >= space_print)			// Пока колличество символов в строке вообщем больше колличества пробелов 
			{
				std::cout << "X";							// Выводим X
				space_print += 1;							// Добавляем 1 к переменной отвечающей за колличество написанных символов
			}
			else											// В случае если предыдущие условия не могут быть выполнены
			{
				allow_print = false;						// Запрещает продолжение внутренего цикла
				std::cout << '\n';							// Осущевстляет переход на новую строку
			}

		}
		number -= 1;										// Отнимает от колличества пробелов 1
	}
}



void factorial_finder()
{
	int factorial_number, number, iterations = 0;							// Инициализирует переменных типа int
	unsigned long long int factorial;										// Инициализация сверх больших переменных			
	bool count = true;														// Инициализация переменной типа bool (True/False)
	while (count)
	{
		std::cout << "Укажите число для поиска факториала: ";				// Вывод запроса пользователю
		std::cin >> number;													// Получения данных от пользователя

		while (number != 0 or number < 0)									// Пока число не равно 0 и число не меньше 0
		{
			if (iterations == 0 and number != 0 or number < 0)				// 
			{
				factorial_number = number;									// Факториальное число равно числу от пользователя
				factorial = factorial_number * (factorial_number - 1);		// Факториал = факториальное число умнженное на факториальное число - 1
				factorial_number -= 2;										// отнимаем 2 от вакториального числа так как оно уже на 1 меньше нужного
				iterations += 1;											// 
			}
			else if (iterations != 0 and factorial_number >= 2)				// В случае если коллличество итераций не равно 0 и факториальное число больше, либо равно 2
			{
				factorial = factorial * factorial_number;					// факториал равен, факториал умноженный на факториальное число
				factorial_number -= 1;										// уменьшение факториального числа на 1
				iterations += 1;											// увелечение колличества итераций
			}
			else															// если все выше не удовлетворяет условиям, сработает это.
			{
				std::cout << factorial << std::endl;						// 
				iterations = 0;												// Сброс значений переменной
				factorial = 0;												// Сброс значение переменной
				break;														// Выход из цикла
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
	double money, precent;																		// Инициализируем переменные типа double
	int years = 1, const_years;																	// Инициализация переменных типа int (years объявленна для экономии места)
	std::cout << "Пожалуйста введите сумму стартового капитала, " <<							// Отправка запроса пользователлю
		"длительность вклада и процентую ставку\n";
	std::cin >> money;																			// Получение данных от пользователя
	std::cin >> const_years;																	// Получение данных от пользователя
	std::cin >> precent;																		// Получение данных от пользователя
	while (years <= const_years)																// Пока колличество лет что прошли меньше, либо равны колличеству лет указанных пользователем
	{
		money = money + money * (precent / 100);												// Вычесление колличества денег через каждый год
		std::cout << "В конце " << years << "-го года у вас будет " << money << std::endl;		// Вывод суммы на счету пользователя
		years += 1;
	}
	std::cout << "Через " << const_years << " лет вы получите " << money << std::endl;			// Вывод финального результата
}



void bank_mortage()
{

}



void old_pounds_summ()
{
	
}



int main()
{
	setlocale(LC_ALL, "Russian");
	//x_pyramid();
	//factorial_finder();
	//bank_offer();
}
