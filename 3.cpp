#include <iostream>
#include <string>

struct employee
{
	int employee_number;
	float income;
};

struct fraction
{
	int num1, num2;
};

struct Time
{
	int hours, minutes, seconds;
};

int excersise_1()
{
	employee e1, e2, e3;
	std::cout << "Введите данные о сотруднике номер и заработок: ";
	std::cin >> e1.employee_number >> e1.income;
	std::cout << "Введите данные о сотруднике номер и заработок: ";
	std::cin >> e2.employee_number >> e2.income;
	std::cout << "Введите данные о сотруднике номер и заработок: ";
	std::cin >> e3.employee_number >> e3.income;
	std::cout << "Зарабаток: " << e1.income << "Номер сотрудника: " << e1.employee_number << std::endl;
	std::cout << "Зарабаток: " << e2.income << "Номер сотрудника: " << e2.employee_number << std::endl;
	std::cout << "Зарабаток: " << e3.income << "Номер сотрудника: " << e3.employee_number << std::endl;
	return 0;
}

int excersise_2()
{
	char x;
	std::cout << "Введите значение: ";
	std::cin >> x;
	switch (x)
	{
	case 'a':
		std::cout << "accountant\n";
		break;
	case 'e':
		std::cout << "executive\n";
		break;
	case 'l':
		std::cout << "laborer\n";
		break;
	case 's':
		std::cout << "secretary\n";
		break;
	case 'm':
		std::cout << "manager\n";
		break;
	case 'r':
		std::cout << "researcher\n";
		break;
	default:
		std::cout << "Значение отсутствует в реестре.";
		break;
	}
	return 0;
}

int excersise_3()
{
	fraction num1, num2;
	float number1, number2;
	std::cout << "Введите значение дроби: \n";
	std::cin >> num1.num1;
	std::cout << "----\n";
	std::cin >> num1.num2;
	std::cout << "Введите значение дроби: \n";
	std::cin >> num2.num1;
	std::cout << "----\n";
	std::cin >> num2.num2;
	std::cout << num1.num1 << "/" << num1.num2 << "\n" << num2.num1 << "/" << num2.num2 << std::endl;
	number1 = num1.num1 * num2.num2 + num1.num2 * num2.num1;
	number2 = num1.num2 * num2.num2;
	std::cout << number1 << "/" << number2 << '\n' << number1 / number2 << std::endl;;
	return 0;
}

int excersise_4()
{
	Time t1;
	long totalsecs;
	std::string time;
	std::cout << "Введите время в формате '00:00:00': ";
	std::cin >> time;
	t1.hours = std::stoi(time.substr(0,2));
	t1.minutes = std::stoi(time.substr(3, 5));
	t1.seconds = std::stoi(time.substr(6, 8));
	totalsecs = t1.hours * 3600 + t1.minutes * 60 + t1.seconds;
	std::cout << "Всего секунд: " << totalsecs << '\n';
	return 0;
}

int excersise_5()
{
	Time t1;
	long totalsecs = 0;
	std::string time;
	for (int iter = 1; iter <= 2; iter++)
	{
		std::cout << "Введите время в формате '00:00:00': ";
		std::cin >> time;
		t1.hours = std::stoi(time.substr(0, 2));
		t1.minutes = std::stoi(time.substr(3, 5));
		t1.seconds = std::stoi(time.substr(6, 8));
		totalsecs += t1.hours * 3600 + t1.minutes * 60 + t1.seconds;
	}
	t1.seconds = totalsecs % 3600 % 60;
	t1.minutes = totalsecs % 3600 / 60;
	t1.hours = totalsecs / 3600;
	time.clear();
	time += std::to_string(t1.hours);
	time += ":";
	time += std::to_string(t1.minutes);
	time += ":";
	time += std::to_string(t1.seconds);
	std::cout << time << std::endl;
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
	int x, result;
	bool loop = true;
	while (loop)
	{
		std::cout << "Введите номер задания от 1-5 или 0 для завершения программы: ";
		std::cin >> x;
		if (x == 1)
		{
			result = excersise_1();
			loop = next();
		}
		else if (x == 2)
		{
			result = excersise_2();
			loop = next();
		}
		else if (x == 3)
		{
			result = excersise_3();
			loop = next();
		}
		else if (x == 4)
		{
			result = excersise_4();
			loop = next();
		}
		else if (x == 5)
		{
			result = excersise_5();
			loop = next();
		}
		else if (x == 0)
		{
			loop = false;
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
