/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int N;
Console.Write($"enter N: ");
int.TryParse(Console.ReadLine()!, out N);

PrintNumbers(N, 1);

void PrintNumbers(int start, int n)
{
    if (start < n)
        return;
    Console.Write($"{start} ");
    PrintNumbers(start - 1, n);
}


