// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число и нажмите Enter");
var n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите Enter");
var n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число и нажмите Enter");
var n3 = int.Parse(Console.ReadLine());

int max = n1;

if (n1 > max) max = n1;
if (n2 > max) max = n2;
if (n3 > max) max = n3;

Console.Write("max = ");
Console.WriteLine(max);