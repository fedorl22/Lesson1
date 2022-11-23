//На входе принимает 2 числа и проверяет является ли перво число квадратом второго.

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b )
{
    Console.Write("YES!");
}
else
{
    Console.Write("NO!");
}
