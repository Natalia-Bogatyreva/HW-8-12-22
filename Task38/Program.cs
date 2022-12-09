// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Диапазон любой, ввод (размер, значения) зависит от пользователя.
Console.WriteLine("Введите колличество элементов в одномерном массиве, который хотите создать:");
int a = Convert.ToInt32(Console.ReadLine());
double [] array = new double [a];

void Mass(int a, double[] array)
{
    for (int i=0; i<a; i++)
    {
        Console.WriteLine($"Введите значение {i+1} элемента массива:");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double Min_max(int a, double[] array)
{
    double min = array[0];
    double max = array[0];
    double raz = 0;
    for (int i=0; i<a; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }
    raz = max - min;
    return (raz);
}

Mass(a,array);
Console.WriteLine($"Разница между минимальным и максимальным элементами введенного массива = {Min_max(a, array)}");