// Напишите программу, которая на вход принимает одно число N, а на выходе -N до N



Console.WriteLine("Введите число N: ");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = -count; i < count+1; i++)
{
      Console.WriteLine(i);
}



