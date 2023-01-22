//Семинар 5 Домашнее задание 5
/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

/*int[] GreateRandomArray(int size , int minValue, int maxValue)
{
    int[] array = new int[size];
    for( int i =0; i<size; i++)
        array[i]=new Random().Next(minValue,maxValue);
    return array ;

}*/
/*void ShowArray(int[] array )
{
    for(int i=0; i< array.Length; i++)
      Console.Write(array[i] +" ");
    Console.WriteLine();  
}*/
/*int Evennumbers(int[] array)
{
    int corrent=0;
    for(int i=0; i < array.Length; i++)
        if(array[i] %2==0) corrent+=1;

    return corrent;
}
Console.Write("Еnter the number of numbers in the array ");
int num= Convert.ToInt32(Console.ReadLine());
int minValue=99;int maxValue=1000;
int[] newarray = GreateRandomArray(num,minValue,maxValue);
ShowArray(newarray);
Console.Write($"The number of even numbers in the array:{Evennumbers(newarray)} ");*/

/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/
/*int SumNumbersOdd(int[] array)
{
    int sum=0;
    for(int i=1; i < array.Length; i+=2)
        sum=sum +array[i];
    return sum;
}
Console.Write("Еnter the number of numbers in the array ");
int num= Convert.ToInt32(Console.ReadLine());
int minValue=0;int maxValue=10;
int[] newarray = GreateRandomArray(num,minValue,maxValue);
ShowArray(newarray);
Console.Write($"sum of numbers in odd positionsy:{SumNumbersOdd(newarray)} ");*/

 /*Задайте массив вещественных чисел. 
 Найдите разницу между максимальным и минимальным элементов массива.*/

double[] GreateRandomDoubleArray(int size , int minValue, int maxValue)
{
    double[] array = new double[size];
    for( int i =0; i<size; i++)
        array[i]=Math.Round(new Random().NextDouble()*100,2);
    return array ;

}
void ShowDoubleArray(double[] array )
{
    for(int i=0; i< array.Length; i++)
      Console.Write(array[i] +"  ");
    Console.WriteLine();  
}
double DifferenceNmbersMaxMin(double[] array)
{
    double maxnumber=array[0];
    double minnumber=array[0];
    for(int i=0; i <array.Length; i++)
    {
        if (array[i]>maxnumber) maxnumber=array[i];
        if (array[i]<minnumber) minnumber=array[i];
    }
    double dif=Math.Round(maxnumber-minnumber,2);
    return dif;
}
Console.Write("Еnter the number of numbers in the array ");
int num= Convert.ToInt32(Console.ReadLine());
int minValue=0;int maxValue=1;
double[] newarray = GreateRandomDoubleArray(num,minValue,maxValue);
ShowDoubleArray(newarray);
Console.Write($"the difference the maximum and minimum:{DifferenceNmbersMaxMin(newarray)} ");