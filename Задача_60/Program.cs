// Задача 60. ...Сформируйте трёхмерный массив . Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int[,,] matrix3D = new int[2, 2, 2];
int minValue = 1;
int maxValue = 100;


void Print(int[,,] arr)
{
    Random rand = new Random();
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = rand.Next(minValue, maxValue + 1);
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

Print(matrix3D);
