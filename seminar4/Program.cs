//Семинар 4 Домашнее задание 4
/*Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
int Stepen(int num1,int num2)
{
    int mult=1;
    for (int i = 1; i <= num2;i++) mult=mult*num1;
    return mult;
}
Console.Write("Input  number A: ");
int num1= Convert.ToInt32(Console.ReadLine());
Console.Write("Input  number B: ");
int num2= Convert.ToInt32(Console.ReadLine());
Console.Write($"raising the number {num1} to the power of {num2} = {Stepen(num1,num2)}");*/

/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/
int Getsumm(int num)
{
    int sum =0;
    while(num / 10 !=0)
    {
        sum= sum+num % 10;
        num=num / 10;
    }
    sum = sum+num;
    if (sum == 0) sum=num;
    return sum; 
}
Console.Write("Input  number : ");
int num= Convert.ToInt32(Console.ReadLine());
Console.Write($"Тhe sum of the digits in a number: {Getsumm(num)} ");

/* Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
int[] GreateArray(int size)
{
    int[] array = new int[size];
    for( int i =0; i<size; i++)
    {
        Console.Write($"Input  a{i+1} element: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array ;

}
void ShowArray(int[] array )
{
    for(int i=0; i< array.Length; i++)
      Console.Write(array[i] +" ");
    Console.WriteLine();  
}
Console.Write("Input  number  m: ");
int m= Convert.ToInt32(Console.ReadLine());
int[] newarray=GreateArray(m);
ShowArray(newarray );*/