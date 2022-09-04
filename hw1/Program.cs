// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число и нажмите Enter");
var n1 = Decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число и нажмите Enter");
var n2 = Decimal.Parse(Console.ReadLine());
if (n1 > n2)
    Console.WriteLine("Большее из этих чисел " + n1 + ", меньшее из этих чисел " + n2);
else
    Console.WriteLine("Большее из этих чисел " + n2 + ", меньшее из этих чисел " + n1);