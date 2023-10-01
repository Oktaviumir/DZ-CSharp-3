// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int SetNumber(string message)
{
    Console.Write($"Введите колличество {message}: ");
    int num = int.Parse(Console.ReadLine()!);
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

int rows = SetNumber("rows");
int columns = SetNumber("columns");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);

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


int SumLine(int[,] matrix, int i)
{
    int sum = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    return sum;
}

if (rows == columns)
{
    Console.WriteLine("Массив не прямоугольный");
    return;
}
int minSum = 1;
int sum = SumLine(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    if (sum > SumLine(matrix, i))
    {
        sum = SumLine(matrix, i);
        minSum = i + 1;
    }
}

Console.WriteLine();
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");
