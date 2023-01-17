/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30" */

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


