/*
Задача 47 - branch Task47
Задача 50 - branch Task50
Задача 52 - branch Task52

Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int line = 3, columns = 4;
int[,] matrix = FillMatrix(line, columns);
PrintMatrix(matrix);
ArithmeticMeanColumns(matrix);

int[,] FillMatrix(int line, int columns)
{
    int[,] matrix = new int[line, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
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


double[] ArithmeticMeanColumns(int[,] matrix)
{
    double count = 0;
    double[] array = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            count += matrix[i, j];
        }
        Console.Write($"Arithmetic Mean on {j + 1} Column: ");
        Console.WriteLine("{0:0.0}", array[j] = Convert.ToDouble(count / matrix.GetLength(0)));
        count = 0;
    }
    return array;
}

