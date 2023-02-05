// Семинар 9 Домашнее задание 9 заключительное
/*Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.*/
/*void ShowNumbers(int n)
{
    Console.Write(n +" ");
    if (n>1) ShowNumbers(n-1);
}
ShowNumbers(10);*/

/*Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/
/*void ShowNumbers2(int m,int n)
{
    Console.Write(m +" ");
    if (m>n) ShowNumbers2(m-1,n);
    if (m<n) ShowNumbers2(m+1,n);
}
ShowNumbers2(15,4);*/

/*Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.*/

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return FunctionAkkerman(m - 1, 1);
    else
      return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}
Console.Write("Enter the number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" A(m.n) = {FunctionAkkerman(n,m)}");