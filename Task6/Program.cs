// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали,
// или напишите, что такого элемента нет.

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
(int, int) Find(int[,] array, int number)//кортеж (tuple) -взврат из функции 2ух значения
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (number == array[i, j])
            {
                return (i, j);
            }
        }
    }
    return (-1, -1);
}

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество колонок");
int[,] arr = Generate2DArray(rows, columns);
Print2DArray(arr);
int numb = ReadInt($"ВВедите число для поиска ");
(int x, int y) = Find(arr, numb);
if (x != -1)
{
    System.Console.WriteLine($"Координаты вашего числа {x + 1}, {y + 1}");
}
else
{
    System.Console.WriteLine("Такого элемента нет в массиве");
}
