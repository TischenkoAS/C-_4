// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!)!;

Console.WriteLine($"Произведение чисел равно {GetMulty(num)}.");

int GetMulty(int number)
{
    int temp = 1;
    for (int count = 1; count <= number; count++)
    {
        temp *= count;
    }
    return temp;
}