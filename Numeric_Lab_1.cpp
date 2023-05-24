#include <vector>
#include <iostream>
#include <string>
#include <locale.h>
#include <cmath>

using namespace std;

double f(double x)   //x * e^ x = 1;
{
    return x * exp(x) - 1;
}

double f1(double x)   // Первая производная (x + 1) * e ^ x = 0;
{
    return (x + 1) * exp(x);
}

double fi(double x)   //  x = 1 / e^x
{
    return 1 / exp(x);
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



int main()
{
    setlocale(LC_ALL, "Russian"); 
    method_1();
    method_2();
    method_3();
    method_4();
}

