﻿/* номер 1

double a = 0.1;
double b = 1;
double h = 0.1;


double Factorial(double n)
{
    if (n == 1 || n == 0) return 1;

    return n * Factorial(n - 1);
}


for (double x = a; x <= b; x += h)
{

    var y = Math.Cos(x);
    double Slag = 1;
    int i = 0;
    double S = 0;
    double slag = 0;

    while (Slag >= 0.0001)
    {

        double x1 = Math.Pow(-1, i);
        int p = i * 2;
        double x2 = Math.Pow(x, p);
        double x3 = Factorial(p);

        slag = (x1 * x2 / x3);
        Slag = Math.Abs(slag);

        S = S + slag;

        ++i;
    }

    Console.WriteLine("{0,8:f1}\t{1,8:f5}\t{2,8:f5}\t ",x, y, S);
    // Console.ReadKey();
    // Console.WriteLine($"{S}\t{y}");
}

Console.ReadKey();
*/

/* номер 4


double a = 0.1;
double b = 1;
double h = 0.1;


double Factorial(double n)
{
    if (n == 1 || n == 0) return 1;

    return n * Factorial(n - 1);
}


for (double x = a; x <= b; x += h)
{
    double k = Math.Pow(Math.E, x * x);
    var y = (1 + 2 * x * x) * k;
    double Slag = 1;
    int i = 0;
    double S = 0;
    double slag = 0;

    while (Slag >= 0.0001)
    {

        double x1 = 2 * i + 1;
        int p = i * 2;
        double x2 = Math.Pow(x, p);
        double x3 = Factorial(i);

        slag = (x1 * x2 / x3);
        Slag = Math.Abs(slag);

        S = S + slag;

        ++i;
    }


    Console.WriteLine("{0,8:f1}\t{1,8:f5}\t{2,8:f5}\t ", x, y, S);

}

Console.ReadKey();
Console.ReadKey();
*/