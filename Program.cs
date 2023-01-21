/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
A = 1; B = 15 -> 120
A = 4; B = 8. -> 30" */

int A, B;

int sum = 0;

Console.Write($"enter A: ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write($"enter B: ");
int.TryParse(Console.ReadLine()!, out B);

Console.Write(Summa(A, B));
int start = A;
string Summa(int start, int B)
{
    if (start < B)
    {
        sum = sum + (start + 1);
        Summa(start + 1, B);
    }

    return sum.ToString();

}






















/*

using namespace std;
int  summa(int a, int b)  
   {
      if (a==b) return b;
      else a+summa(b,a);
   }
int main()
{
   int a,b;
   cin>>a>>b;
   cout<<summa(a,b);
  return 0;

  SumFromMToN(M, N);

// вызов функции "сумма чисел от M до N"
void SumFromMToN(int M, int N)
{
    Console.Write(SumMN(M - 1, n));
}
// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
} */