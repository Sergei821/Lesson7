//Задайте двумерный массив. Найдите максимальный элемент массива
//и среднее арифметическое всех элементов массива.


int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}


int[,] Generate2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int SearchMax(int[,] array)
{
    int max = array[0, 0];
    foreach (int item in array)
    {
        if (max < item)
        {
            max = item;
        }
    }
    return max;
}

double Average(int[,] array)
{
    double sum = 0;
    foreach (int item in array)
    {
        sum += item;
    }
    return sum / array.Length;
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество колонок");
int[,] arr = Generate2DArray(rows, columns);
Print2DArray(arr);
System.Console.WriteLine($"Максимальное значение {SearchMax(arr)}");
System.Console.WriteLine($"Среднее арифметическое {Average(arr)}");
