// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число 
//четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.WriteLine("Введите число a: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)
{
    Console.WriteLine("Число нечетное");
}
else
    Console.WriteLine("Число четное");
