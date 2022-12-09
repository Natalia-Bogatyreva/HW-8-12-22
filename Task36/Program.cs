// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Тип массива - int, размерность задает пользователь.

Console.WriteLine("Введите колличество элементов в массиве, который будет заполнен случайными целыми числами:");
int a = Convert.ToInt32(Console.ReadLine());
int [] array = new int [a];
Console.WriteLine("Введите минимальное целое значение, которое может принимать элемент массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное целое значение, которое может принимать элемент массива:");
int max = Convert.ToInt32(Console.ReadLine());

void Massive_Random(int a, int min, int max, int[] array)
{
    for (int i=0; i<a; i++)
    {
        array[i] = new Random().Next(min,max+1);
    }
}

int Mass_sum_odd(int a, int[] array)
{
    int sum = 0;
    int i=1;
    while (i<a)
    {
        sum = sum + array[i];
        i = i+2;
    }
    return sum;
}

Massive_Random(a,min,max,array);
Console.WriteLine($"В массиве {string.Join(",",array)}, сумма числе стоящих на нечетных позициях (первый эелемент массива имеет позицию '0')  = {Mass_sum_odd(a,array)}");