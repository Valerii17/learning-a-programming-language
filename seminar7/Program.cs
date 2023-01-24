//Семинар 7 Домашнее задание 7
/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GreateRandom2dArray(int rows, int columns)
{
    double[,] array = new double[rows,columns];
    for( int i =0; i < rows; i++)
        for(int j =0; j < columns; j++)
        array[i,j]=Math.Round(new Random().Next(-10,10)+ new Random().NextDouble(),2);
    
    return array ;

}
void Show2dArray(double[,] array )
{
    for(int i=0; i< array.GetLength(0); i++)
    {
        for(int j=0; j< array.GetLength(1); j++)
            Console.Write(array[i,j] +"\t ");
        Console.WriteLine();
    } 
    Console.WriteLine();  
}
Console.Write("enter the number of roms m: ");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("enter the number of columns n: ");
int n= Convert.ToInt32(Console.ReadLine());
double[,] newarray = GreateRandom2dArray(m,n);
Show2dArray(newarray);*/

/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
void Greatearray(int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
        for(int j=0; j<array.GetLength(1);j++)
            array[i,j]=new Random().Next(1,10);
}
void Show2dArray(int[,] array )
{
    for(int i=0; i< array.GetLength(0); i++)
    {
        for(int j=0; j< array.GetLength(1); j++)
            Console.Write(array[i,j] +"\t ");
        Console.WriteLine();
    } 
    Console.WriteLine();  
} 
 Console.Write("Enter row index: ");
int indexrow= Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column index: ");
int indexcolumn= Convert.ToInt32(Console.ReadLine());
int[,] array = new int[3,4];
Greatearray(array);
Show2dArray(array);
if(indexrow < array.GetLength(0) && indexcolumn < array.GetLength(1)) 
Console.Write($"value with index:{indexrow},{indexcolumn} = {array[indexrow,indexcolumn]}");
else Console.Write($"there is no value with this index:{indexrow},{indexcolumn} ");*/

/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/
void Greatearray(int[,] array)
{
    for(int i=0; i<array.GetLength(0);i++)
        for(int j=0; j<array.GetLength(1);j++)
            array[i,j]=new Random().Next(1,10);
}
void Show2dArray(int[,] array )
{
    for(int i=0; i< array.GetLength(0); i++)
    {
        for(int j=0; j< array.GetLength(1); j++)
            Console.Write(array[i,j] +"\t ");
        Console.WriteLine();
    } 
    Console.WriteLine();  
} 
int[,] array = new int[3,4];
Greatearray(array);
Show2dArray(array);
double[] Average (int[,] array)
{
    double[] arrayaverage =new double[array.GetLength(1)];
    for (int j=0; j< array.GetLength(1);j++)
    {
        double sum = 0;
        for(int i=0; i < array.GetLength(0);i++)
        {
            sum = sum+ array[i,j];
        }

    arrayaverage[j] = Math.Round(sum / array.GetLength(0),2);
    }
    return arrayaverage;
}
Console.Write($"Average of column values: ");
double[] newarrayaverage= Average(array);
for (int j=0; j<array.GetLength(1);j++)
{
    Console.Write( newarrayaverage[j] +"; ");
}