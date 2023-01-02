//Семинар 3 Домашнее задание 3
/* Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.*/

bool Polindrom(int number)
{
    int num = number;
    int rezult = 0;
    while (num > 0)
    {
        rezult = (rezult * 10 + num % 10);
        num = num /10;        
    }
    return rezult == number;
}
Console.Write("Input  number: ");
int number= Convert.ToInt32(Console.ReadLine());
if (Polindrom(number)) Console.WriteLine("The number is a palindrome");
else Console.Write("Number is not a palindrome");

 /*Задача 2. Напишите программу, которая принимает на вход координаты двух точек
  и находит расстояние между ними в 3D пространстве.
double DistanceBetweenPoints(double x1,double y1,double z1,double x2,double y2,double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)); 
    distance = Math.Round(distance,2);
    return distance;
}    
Console.Write("enter point 1 coordinates x:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter point 1 coordinates y:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter point 1 coordinates z:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter point 2 coordinates x:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter point 2 coordinates y:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter point 2 coordinates z:");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"distance between points:{DistanceBetweenPoints(x1,y1,z1,x2,y2,z2)}");*/


 /*Задача 3. Напишите программу, которая принимает на вход число (N)
  и выдаёт таблицу кубов чисел от 1 до N.

double СubeNumber(int current)
{
    double num = Math.Pow(current,3);
    return num;
}
Console.Write("Input  number N: ");
int number= Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= number)
{  
    Console.Write(СubeNumber(current) + ", ");
    current ++;
}*/