// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Диапазон трехзначных чисел (int), ввод случайный.
Console.WriteLine("Введите колличество элементов в массиве, который будет заполнен случайными трехначными положительными числами:");
int a = Convert.ToInt32(Console.ReadLine());
int [] array = new int [a];

Console.WriteLine("Введите минимальное положительное трехзначное значение, которое может принимать элемент массива:");
int min = Convert.ToInt32(Console.ReadLine());
while (min < 100 || min > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число, попробуйте еще раз:");
    min = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите максимальное положительное трехзначное значение, которое может принимать элемент массива:");
int max = Convert.ToInt32(Console.ReadLine());
while (min < 100 || min > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число, попробуйте еще раз:");
    max = Convert.ToInt32(Console.ReadLine());
}

void Massive_Random(int a, int min, int max, int[] array)
{
    for (int i=0; i<a; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
}

int Mass_even(int a, int[] array)
{
    int num = 0;
    for (int i=0; i<a; i++)
    {
        if (array[i] % 2 == 0)
        {
            num++;
        }
    }
    return num;
}

Massive_Random(a,min,max,array);
Console.WriteLine($"В массиве {string.Join(",",array)} - {Mass_even(a,array)} четных чисел");
