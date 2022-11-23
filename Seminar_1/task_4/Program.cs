// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b, не равное a: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c, не равное a и b: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
  if (a > c) Console.WriteLine(a);
  else Console.WriteLine(c);
else 
    if (b > c) Console.WriteLine(b);
    else Console.WriteLine(c);

