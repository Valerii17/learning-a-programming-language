//Семинар 2 Домашнее задание 2
/* Задача 1. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

int SecondNumber(int number)
{
    int num2 = number / 10;
    int rezult = num2 % 10;
    return rezult;
}

Console.Write("Input  number > 99 and <1000: ");
int number= Convert.ToInt32(Console.ReadLine());
if (number > 99) // (number < 1000) 
{
    int newnumber=SecondNumber(number);
    Console.WriteLine($"Second namber :{newnumber}");
}
else Console.Write("Wrong number entered, restart the program: ");

 /*Задача 2. Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/
int ThirdNumber(int number)
{
    if (number / 100 == 0 ) number = -1;
    int current = 1;
    while(number /1000 != 0)
    {
        number = number / 10;
        current ++;
    } 
    number = number % 10; 
    return number;
}
Console.Write("Input  number: ");
int number = Convert.ToInt32(Console.ReadLine());
int newnumber=ThirdNumber(number);
if (newnumber == -1) Console.WriteLine("Third number :absent");
else Console.WriteLine($"Third number :{newnumber}");

 /*Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

bool DayoftheWeek(int number)
{
    if (number == 6 || number ==7) return true;
    else return false;
}
Console.Write("Input  number day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(DayoftheWeek(number));*/