// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите целое число и нажмите Enter");
var n = int.Parse(Console.ReadLine());

if (n % 2 == 0)
    Console.WriteLine("Введённое число является четным");
else
    Console.WriteLine("Введённое число является нечетным");