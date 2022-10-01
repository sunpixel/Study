#include <iostream>



void x_pyramid()
{
	std::cout << "Задание #1\n";
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
	std::cout << "Задание #2\n";
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
		if (number == 0)
		{
			std::cout << "Цикл заершен!!";
			count = false;
		}
	}
}



void bank_offer()
{
	std::cout << "Задание #3\n";
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
	std::cout << "Задание #4\n";														// Вывод номера задания
	long double amount, initial_payment, yearly_payment, precent, years;				// Ининицаилизация переменной типа long double
	std::cout << "Введите стоимость квартиры: ";										// Получение данных от пользователя
	std::cin >> amount;
	std::cout << "Введите сумму начального взноса: ";
	std::cin >> initial_payment;
	std::cout << "Введите срок выплаты: ";
	std::cin >> years;
	std::cout << "Введите процентную ставку: ";
	std::cin >> precent;

	amount = amount - initial_payment;													// Определяем сумму для выплат (из общей суммы убираем сумму взноса)
	yearly_payment = amount / years;													// Равномерно делим сумму на все годы
	yearly_payment = yearly_payment + (yearly_payment * (precent / 100));				// Прибавляем к сумме ежегодных выплат процент банка

	std::cout << "Ежегодные выплаты составляют: " << yearly_payment << std::endl;		// Выводим сумму ежегодных платежей
	std::cout << "Общая сумма выплат: " << yearly_payment * years<< '\n';				// Выводим общую сумму к оплате
}



void old_pounds_summ()
{
	std::cout << "Задание #5\n";
	int old_pound, shilling, penny, old_pound2, shilling2, penny2, old_pound3, shilling3, penny3;		// Инициализирование всех переменных
	char next = 'y';																					// Инициализированние переменной типа char, которая будет отвечать за продолжение
	while (next != 'n')
	{
		std::cout << "Введите первое число: ";
		std::cin >> old_pound >> shilling >> penny;
		std::cout << "Введите второе число: ";
		std::cin >> old_pound2 >> shilling2 >> penny2;
		penny3 = penny + penny2;																		// Складываем колличество пении 1-го и 2-го числа
		shilling3 = shilling + shilling2;																// Складываем колличество шиллингов 1-го и 2-го числа
		old_pound3 = old_pound + old_pound2;															// Складываем колличество фунтов 1-го и 2-го числа

		if (penny3 >= 12)																				// Проверяем колличество пенни на прохождение условия
		{
			penny3 = penny3 - 12;																		// Отнимаем от колличества пени 12
			shilling3 += 1;																				// Прибавляем 1 к колличеству шиллингов
		}					

		if (shilling3 >= 20)																			// Проверка коллличества шиллингов на исполлнение условия
		{
			shilling3 = shilling3 - 20;																	// Вычитание шиллингов
			old_pound3 += 1;																			// Добавление фунтов
		}

		std::cout << old_pound3 << "." << shilling3 << "." << penny3 << std::endl;						// Вывод результата

		std::cout << "Продолжить (y/n): ";																// Запрос пользователю
		std::cin >> next;																				// Полчучение ответа от пользователя
	}
}

void choice()
{
	int x;
	bool loop = true;
	while (loop)
	{
		std::cout << "Введите номер задания от 1-5: ";
		std::cin >> x;
		if (x == 1)
		{
			x_pyramid();
			loop = false;
		}
		else if (x == 2)
		{
			factorial_finder();
			loop = false;
		}
		else if (x == 3)
		{
			bank_offer();
			loop = false;
		}
		else if (x == 4)
		{
			bank_mortage();
			loop = false;
		}
		else if (x == 5)
		{
			old_pounds_summ();
			loop = false;
		}
		else
		{
			std::cout << "Выбранного задания не существует. Выберите другое!\n";
		}
	}
}

int main()
{
	setlocale(LC_ALL, "Russian");
	choice();
}
