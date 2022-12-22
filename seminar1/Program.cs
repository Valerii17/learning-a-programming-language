//Семинар 1 Домашнее задание 
/* Задача 1. Напишите программу,которая на вход принимает два числа и выдаёт, какое число большее,
 а какое меньшее.

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)  Console.WriteLine($"Максимальное значение:{num1}, Минимальное значение:{num2}");
else  Console.WriteLine($"Максимальное значение:{num2}, Минимальное значение:{num1}");
*/
/* Задача 2.Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.

Console.Write("Input a first number: ");
int num11 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num22 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num33 = Convert.ToInt32(Console.ReadLine());
if (num11 > num22 && num11 > num33)
Console.WriteLine($"Максимальное значение:{num11}");
if (num22 > num11 && num22 > num33)
Console.WriteLine($"Максимальное значение:{num22}");
else Console.WriteLine($"Максимальное значение:{num33}"); */

/* Задача 3.Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
Console.Write("Input a  number: ");
int num4 = Convert.ToInt32(Console.ReadLine());
if (num4 % 2 == 0) Console.WriteLine($"Число:{num4}  четное");
else Console.WriteLine($"Число:{num4} - нечетное");*/
/* Задача 4.Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.*/
Console.Write("Input a  number > 0: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;
while (current <= number)
{  
    if (current % 2 == 0) Console.Write(current + " ");
    current ++;
}



/*Переменные
int a = 5, b = 4;целочисленные
double b = 23.6; вещественные
bool c = true;false;логические
string d = "World";строка
char e = 'f'; символы
Console.WriteLine("My number is " + a + "and " + b + " is good"); капсунация
Console.WriteLine($"My number is  {a} and {b}  is good");
*/