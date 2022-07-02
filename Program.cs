/*
Задача 47 - branch Task47
Задача 50 - branch Task50
Задача 52 - branch Task52

Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/

Console.Write("Input quantity lines in matrix: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity columns in matrix: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] randomMatrix = FillMatrix(line, columns);
PrintMatrix(randomMatrix);


double[,] FillMatrix(int line, int columns)
{
    double[,] matrix = new double[line, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / new Random().Next(1, 10);
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0:0.0} ", matrix[i, j]);
        }
        Console.WriteLine();
    }

}