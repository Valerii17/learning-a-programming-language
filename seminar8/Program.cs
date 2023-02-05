//Семинар 8 Домашнее задание 8
/*Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива. */
/*void Greatearray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}*/
/*void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t ");
        Console.WriteLine();
    }
    Console.WriteLine();
}*/
/*void SortArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int max = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, k] > array[i, max]) max = k;
            temp = array[i, j];
            array[i, j] = array[i, max];
            array[i, max] = temp;
        }
    }
}
int[,] array = new int[3, 4];
Greatearray(array);
Show2dArray(array);
SortArray(array);
Show2dArray(array);*/

/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/
/*int NumberRow(int[,] array)
{
    int summin = 100; int mini = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumi = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumi = sumi + array[i, j];

        }
        Console.WriteLine($"Amount per {i} row: {sumi}");
        if (sumi < summin)
        {
            summin = sumi;
            mini = i+1;
        }
    }
    return mini;
}
int[,] array = new int[3, 4];
Greatearray(array);
Show2dArray(array);
Console.WriteLine($"The row with the smallest sum={NumberRow(array)}");*/


/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/
/*int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] multarray = new int[2, 2];
    for (int i = 0; i < multarray.GetLength(0); i++)
    {
        for (int j = 0; j < multarray.GetLength(1); j++)
            for (int k = 0; k < multarray.GetLength(1); k++)
                multarray[i, j] += array1[i, k] * array2[k, j];
    }
    return multarray;
}
int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
Greatearray(array1);
Greatearray(array2);
Show2dArray(array1);
Show2dArray(array2);
int[,] multarray = MatrixMultiplication(array1, array2);
Console.WriteLine("Matrix from the multiplication of two matrices= ");
Show2dArray(multarray); */

/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/
int GetNonrepeatingValues(int[,,] array3d, int min, int max, int i, int j, int k)
{
    int value = default;
    bool exist = true;
    while (exist)
    {
        bool stop = false;
        value = new Random().Next(min, max + 1);
        for (int i1 = 0; i1 < array3d.GetLength(0); i1++)
        {
            if (stop) break;
            for (int j1 = 0; j1 < array3d.GetLength(1); j1++)
            {
                if (stop) break;
                for (int k1 = 0; k1 < array3d.GetLength(2); k1++)
                {
                    if (array3d[i1, j1, k1] == value)
                    {
                        stop = true; break;
                    }
                    if (i1 == i && j1 == j && k1 == k) exist = false;
                }
            }
        }
    }
    return value;
}
int[,,] GetArray3d(int row, int col, int dep, int min, int max)
{
    int[,,] array3d = new int[row, col, dep];
    for (int i = 0; i < array3d.GetLength(0); i++)
        for (int j = 0; j < array3d.GetLength(1); j++)
            for (int k = 0; k < array3d.GetLength(2); k++)
                array3d[i, j, k] = GetNonrepeatingValues(array3d, min, max, i, j, k);
    return array3d;
}
void Show3dArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k=0; k< array3d.GetLength(2); k++)
                Console.Write($"{array3d[i,j,k]}({i},{j},{k})  ");
            Console.WriteLine();   
        }
    }
    Console.WriteLine();
}
int[,,] array3d = GetArray3d(2, 2, 2, 10, 99);
Show3dArray(array3d);

/*Напишите программу, которая заполнит спирально массив 4 на 4.*/
/*int[,] MatrixSpiral(int a, int b)
{
    int[,] array = new int[a, b];
    int k = 1; int i = 0; int j = 0; int istart = 0; int ifinish = 0; int jstart = 0; int jfinish = 0;
    while (k <= a * b)
    {
        array[i, j] = k;
        if (i == istart && j < b - jfinish - 1) j++;
        else if (j == b - jfinish - 1 && i < a - ifinish - 1) i++;
        else if (i == a - ifinish - 1 && j > jstart) j--;
        else i--;
        if ((i == istart + 1) && (j == jstart) && (jstart != b - jstart - 1))
        {
            istart++; ifinish++; jstart++; jfinish++;
        }
        k++;
    }
    return array;
}
Console.Write("Enter the number of roms a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns b: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = MatrixSpiral(a, b);
Show2dArray(array);*/