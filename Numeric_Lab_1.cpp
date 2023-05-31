#include <vector>
#include <iostream>
#include <string>
#include <locale.h>
#include <cmath>

using namespace std;

double f(double x)   // 2sin(x - 0.6) = 1.5 - x
{
    return 2 * sin(x-0.6) - 1.5 + x;
}

double f1(double x)   // Первая производная
{
    return 2 * cos(x - 0.6) + 1;
}

double fi(double x)  
{
    return 1.5 - 2 * sin(x - 0.6);
}



void method_1()
{
    bool bul = true;
    int i = 0;
    double c, res;
    double a = 0; double b = 0; double p = 0;

    while (b <= a)
    {
        cout << "Введите начало отрезка: ";
        cin >> a;
        cout << "Введите конец отрезка: ";
        cin >> b;
        cout << "Введите точность: ";
        cin >> p;
        if (b <= a) cout << "Вы неправильно ввели отрезок" << '\n';
        if (abs(b) + abs(a) < p) cout << "Точность превышает отрезок" << '\n';
        if (f(a) * f(b) >= 0)
        {
            cout << "Единственного корня нет на этом отрезке" << '\n';
            a = 0;
            b = 0;
        }
    }

    c = (a + b) / 2;
    while (true)
    {
        if (f(a) * f(c) < 0)
            b = c;
        else if (f(b) * f(c) < 0)
            a = c;
        i++;
        c = (a + b) / 2;
        if (f(c - p) * f(c + p) < 0) break;
    }
    cout << "x примерно равен " << c << " с точностью " << p << ". \nКоличество итераций: " << i << '\n';
}



void method_2()
{
    double c;
    int i = 0;
    double a = 0; double b = 0; double p = 0;

    while (b <= a)
    {
        cout << "Введите начало отрезка: ";
        cin >> a;
        cout << "Введите конец отрезка: ";
        cin >> b;
        cout << "Введите точность: ";
        cin >> p;
    }

    c = a - (b - a) / (f(b) - f(a)) * f(a);
    while (true)
    {
        if (f(a) * f(c) < 0)
            b = c;
        else if (f(b) * f(c) < 0)
            a = c;

        i++;
        if (f(c - p) * f(c + p) < 0) break;
        c = a - (b - a) / (f(b) - f(a)) * f(a);
    }
    cout << "x примерно равен " << c << " с точностью " << p << ". \nКоличество итераций: " << i << '\n';
}



void method_3()
{
    long double x0 = 0;
    long double x;
    double p;
    int i;

    cout << "Введите начальное приближение корня: ";
    cin >> x0;
    cout << "Введите точность: ";
    cin >> p;

    i = 0;

    while (true)
    {
        x = x0 - f(x0) / f1(x0);
        i++;
        if (f(x - p) * f(x + p) < 0) break;
        x0 = x;
    }
    cout << "x примерно равен " << x << " с точностью " << p << ". \nКоличество итераций: " << i << '\n';
}


void method_4()
{
    long double x0 = 0;
    long double x, p;
    int i = 0;

    cout << "Введите начальное приближение корня: ";
    cin >> x0;
    cout << "Введите точность: ";
    cin >> p;

    i = 0;
    while (true)
    {
        x = fi(x0);
        i++;
        if (f(x - p) * f(x + p) < 0) break;
        x0 = x;
    }
    cout << "x примерно равен " << x << " с точностью " << p << ". \nКоличество итераций: " << i;
}



void choose()
{
    int x = 0;
    std::cout << "Выберите метод: \n" << "1 - Дихотомии\n" << "2 - Хорд\n" << "3 - Ньютона\n" << "4 - Простых итераций\n" << "----------------------\n";
    std::cin >> x;
    switch (x)
    {
    case 1:
        method_1(); // Дихотомии
        break;
    case 2:
        method_2(); // Хорд
        break;
    case 3:
        method_3(); // Ньютона
        break;
    case 4:
        method_4(); // Простых итераций
        break;
    default:
        std::cout << " Значение выбранно не правильно. \n";
        break;
    }
}



int main()
{
    setlocale(LC_ALL, "Russian");
    choose();
    //method_1(); // Дихотомии
    //method_2(); // Хорд
    //method_3(); // Ньютона
    //method_4(); // Простых итераций
}
