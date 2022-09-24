#include <iostream>                                             // Основная библиотека C++ для вывода работы с консолью
#include <string>                                               // 
#include <vector>                                               // 
#include <sstream>                                              // 

void tokenize(std::string const& str, const char delim,         // Функция выполняющая разделение текста по строкам. Была скоипрованна со StackOverflow
    std::vector<std::string>& out)
{
    size_t start;
    size_t end = 0;

    while ((start = str.find_first_not_of(delim, end)) != std::string::npos)
    {
        end = str.find(delim, start);
        out.push_back(str.substr(start, end - start));
    }
}

void Excersise_1()
{
    std::cout << "Задание 1\n";     // Вывод данных о номере задания
    std::string s = "Пустое вы сердечным ты*Она, обмолвясь, заменила*И все счастливые мечты*В душе влюбленной возбудила.*Пред ней задумчиво стою,*Свести очей с нее нет силы;*И говорю ей : как вы милы!*И мыслю : как тебя люблю!\n";
    const char delim = '*';         // Выбор разделительного символа
    std::vector<std::string> out;   // Преобразование строки
    tokenize(s, delim, out);        // Вызов функции 
    for (auto& s : out)             // Авто перевыбор типа данных переменной и дальнейший вывод ответа 
    {
        std::cout << s << std::endl;
    }
}

void Excersise_2()  // Не возвратная фунция VOID исполльняющая 2 задание
{
    double temp;                                                // Инициализация переменной типа Double 
    std::cout << "Задание 2\n";                                 // Вывод данных о номере задания.
    std::cout << "Введите температуру в C°: " << std::endl;     // Отправка запроса ппользователю
    std::cin >> temp;                                           // Получение данных от пользователя
    std::cout << "Ответ: " << temp * 9 / 5 + 32 << std::endl;   // Ввыод итогового результата
}


void Excersise_3()   // Не возвратная фунция VOID исполльняющая 3 задание
{
    std::cout << "Задание 3\n";                                 // Вывод данных о номере задания.
    int a, b, c, d;                                             // Инифиализация переменных типа int
    double k, l;
    std::cout << "Введите значение первой дроби,\n";            // Отправить запрос пользователю на получение данных
    std::cin >> a;                                              // Получить данные от пользователя
    std::cout << "---\n";                                       // нарисовать разделяющую дробь
    std::cin >> b;                                              // Получить данные от пользователя
    std::cout << "Введите значение второй дроби,\n";            // Отправить заппрос на получение данных
    std::cin >> c;                                              // Получить данные от пользователя
    std::cout << "---\n";                                       // Нарисовать раделяющую дробь
    std::cin >> d;                                              // Получить данные от пользователя
    std::cout << a << "/" << b << "   "                         // Вывести дроби в более красивом виде
        << c << '/' << d << std::endl;                          // 
    std::cout << "\n";                                          // Сделать отступ на строку
    k = (a * d + b * c);
    l = b * d;
    std::cout << k << "/" << l << " ответ в десятичных единицах: " << k / l << std::endl;       // Вывод итогового результата
}

void Excersice_4()     // Не возвратная фунция VOID исполняющая 4 задание.
{
    std::cout << "Задание 4\n";                                         // Вывод данных о номере задания.
    int x;                                                              // Инициализация переменной типа int
    std::cout << "Выберете вариант ввода 1 или 2: \n";                  // Вывод инструкций 
    std::cout << "1-ый вариант ввод как в старой системе (7.12.3)   (ВРЕМЕННО НЕ РАБОЧИЙ)\n";
    std::cout << "2-ой вариант вводд поочередно каждого из значений\n";
    std::cin >> x;                                                      // Получение данных от пользователя

    //if (x == 1)                                                         // Прооверка выбра способа пользователем
    //{
    //    int a, b, c, n;                                                 // Инифиализация переменных типпа int
    //    std::string s;                                                  // Инициализация переменной S типа string
    //    std::cout << "Введите значение через '.'. (Пример: 7.19.2)";    // Инструкции для пользователя
    //    std::cin >> s;                                                  // Получение данных от пользователя
    //    std::istringstream is(s);                                       // данные отсутсвуют
    //    while (is >> n)                                                 // Проверка
    //    {
    //        std::cout << n;                                             // Вывод данных
    //    }
    //}

    if (x == 2)                                                         // Проверка выбора пользхователя
    {
        int a, b;                                                       // Инициализация переменных типа int
        double c;                                                       // Инициализация переменной типа double, для работы с дробными числами
        std::cout << "Введите коллчиество фунтов: ";                    // Отправка запроса пользователю
        std::cin >> a;                                                  // Введение данных о колличестве фунтов
        std::cout << "Введите коллчиество шиллингов: ";                 // Отправка запроса пользователю
        std::cin >> b;                                                  // Введение данных о колличестве шиллингов
        std::cout << "Введите коллчиество пенсов: ";                    // Отправка запроса пользователю
        std::cin >> c;                                                  // Введение данных о колличестве пенсов
        b = b * 12;
        c = c + b;
        c = c / 2.4;                                                    // Получение колличества фунтов в 10-ной системе
        std::cout << "Десятичных фунтов: " << a << "." << int(c) << std::endl;       // Вывод данных.
    }

    else                                                                // В случае не существуещего выбора прекращает выполнение программы
    {
        NULL;
    }
}

void Excersise_5()
{
    std::cout << "Задание 2\n";                                         // Вывод данных о номере задания.
    int old_pound, shilling, penny;                                     // Инициализация переменных типа int
    double pound;                                                       // Инициализация переменных типа double
    std::cout << "Введите колличество фунтов в десятичной системе: ";   // Запрос пользователю на получение данных
    std::cin >> pound;                                                  // Получение данных от пользователя
    old_pound = pound;                                                  // Преобразование из десятичной системы в старую английскую
    penny = int(pound * 100) % 100 * 2.4;
    shilling = penny / 12;
    penny = penny % 12;
    std::cout << "Фунты: " << old_pound << " Шиллинги: " << shilling << " Пенни: " << penny << std::endl;   // Вывод результат
}


void Choice()  // Не возвратная фунция для осуществления выбора задания по номеру.
{
    int x;
    std::cout << "Пожалуйсто выберите задание 1-5\n";
    std::cin >> x;

    if (x == 1)     // Выюор задания 1
    {
        Excersise_1();  // Вызов функции
    }

    if (x == 2)     // Выбор задания 2
    {
        Excersise_2();  // Вызов функции
    }

    if (x == 3)     // Выбор задания 3
    {
        Excersise_3();  // Вызов функции
    }

    if (x == 4)     // Выбор задания 4
    {
        Excersice_4();  // Вызов функции
    }

    if (x == 5)     // Выбор задания 5
    {
        Excersise_5();  // Вызов функции
    }

    else            // В случае не существуещего выбора прекращает выполнение программы
    {
        NULL;
    }
}

int main()
{
    setlocale(LC_ALL, "Russian");   // Установка Русского языка
    Choice();                       // Вызов функции
}
