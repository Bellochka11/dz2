// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру: ");
int a1 = int.Parse(Console.ReadLine()!);
if (a1 >= 1 && a1 <= 5)
{
    Console.WriteLine($"Число {a1} - это не выходной ");
}
else if (a1 >= 6 && a1 <= 7)
{
    Console.WriteLine($"Число {a1} - это  выходной ");
}
else
{
    Console.WriteLine($" Число {a1} - это не день недели ");
}