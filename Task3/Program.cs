// Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные,
// и замените эти элементы на их квадраты.


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

int[,] SquareEvens(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i += 2)
    {
        for (int j = 1; j < array.GetLength(1); j += 2)
        {
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}    

int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество колонок");
int[,] arr = Generate2DArray(rows, columns);
Print2DArray(arr);
int[,] arr2 = SquareEvens(arr);
System.Console.WriteLine();
Print2DArray(arr2);