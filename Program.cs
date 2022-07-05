// по двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("введите первое число а=");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("введите второе число b=");
int b = int.Parse(Console.ReadLine() ?? "0");
if (a==b*b)
{
    Console.WriteLine("число а является квадратом числа b");
}
else if (b==a*a)
{
    Console.WriteLine("число b является квадратом числа a");
}
else
{
    Console.WriteLine("одно число не являются квадратом другого");
}