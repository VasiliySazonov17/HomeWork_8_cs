/*
Задача 47 - branch Task47
Задача 50 - branch Task50
Задача 52 - branch Task52

Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int line = 3, columns = 4;
int[,] matrix = FillMatrix(line, columns);
PrintMatrix(matrix);
FindNumberMatrix(matrix, number);


int[,] FillMatrix(int line, int columns)
{
    int[,] matrix = new int[line, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
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


void FindNumberMatrix(int[,] matrix, int number)
{
    int line = number / 10;
    int column = number % 10;
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrix.GetLength(0) < line || matrix.GetLength(1) < column) break;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == matrix[line, column])
            {
                Console.Write($"The number {matrix[i, j]} is on the {i + 1} row {j + 1} column");
                count++;
                break;
            }
        }
        if (count != 0) break;
    }
    if (count == 0) Console.Write($"There's no number {number} in the matrix");
}
