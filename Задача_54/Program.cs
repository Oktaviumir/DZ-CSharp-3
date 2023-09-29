// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:         В итоге получается вот такой массив:
// 1 4 7 2                         7 4 2 1           
// 5 9 2 3                         9 5 3 2
// 8 4 2 4                         8 4 4 2

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int SetNumber(string message)
{
    Console.Write($"Введите колличество {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns, int minValue = 10, int maxValue = 99)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
            matrix[i, l] = rand.Next(minValue, maxValue + 1);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}


int rows = SetNumber("rows");
int columns = SetNumber("columns");
Console.WriteLine("\nИсходный массив: ");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine("\nОтсортированный массив ");
SortMatrix(matrix);
PrintMatrix(matrix);
