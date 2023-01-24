//Семинар 6 Домашнее задание 6
/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int Greatenumbers(int m)
{
    int corrent = 0;
    for( int i =0; i<m; i++)
    {
        Console.Write($"Input  {i+1} element: ");
        int element=Convert.ToInt32(Console.ReadLine());
        if (element >0) corrent++;
    }
    return corrent ;
}
Console.Write("Enter the number of elements: ");
int number=Convert.ToInt32(Console.ReadLine());
Console.Write($"Number of elements >0 :{Greatenumbers(number)} ");*/

/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/
double lineintersection(double k1,double k2,double b1,double b2)
{
    double x=(b2-b1)/(k1-k2);         
    return x;
}
Console.Write("Input  number  k1: ");
double k1= Convert.ToDouble(Console.ReadLine());
Console.Write("Input  number  k2: ");
double k2= Convert.ToDouble(Console.ReadLine());
Console.Write("Input  number  b1: ");
double b1= Convert.ToDouble(Console.ReadLine());
Console.Write("Input  number  b2: ");
double b2= Convert.ToDouble(Console.ReadLine());
if (k1 == k2 && b1==b2) Console.Write("lines match !! ");
else if (k1 == k2) Console.Write("lines are parallel !! ");
else
{
    double resultx=lineintersection(k1, k2, b1, b2);
    double resulty=k1*resultx+b1;
    Console.Write($"point of intersection of two lines: ({resultx};{resulty})");
}
