// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbers(int N)
{
    if (N>1)
    {
        Console.Write($"{N}, ");
        N--;
        PrintNumbers(N);
    }
    else if(N==1)
         Console.Write($"{N}.");
    
    else return;
}

Console.WriteLine("Программа выводит натуральные числа от N до 1, используя рекурсию функции");
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write($"N = {N} -> ");
PrintNumbers(N);