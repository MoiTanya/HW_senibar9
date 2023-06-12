// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void SummNumbers(int M, int N, int Summ)
{
    if (M<=N)
    {
        Summ = Summ + M;
        M++;
        SummNumbers(M, N, Summ);
    }
    
    else 
    {
        Console.Write($"{Summ}");
        return;
    } 
}

Console.WriteLine("Программа вычисления суммы натуральных элементов в промежутке от M до N");
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int Summ = 0;
Console.Write($"M = {M}; N = {N} -> ");
SummNumbers(M, N, Summ);