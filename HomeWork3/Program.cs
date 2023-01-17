// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MultiplicationMatrix(int[,] arr, int[,] arr2, int n)
{ // метод находит произведение двух матриц. n размер квадратных матриц.
    int[,] ResultMatrix = new int[n, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int q = 0; q < arr.GetLength(0); q++)
        {
            int sum = 0;
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                sum += arr[i, j] * arr2[j, q];
            }
            ResultMatrix[i, q] = sum;
        }
    }

    Console.WriteLine("Произведением двух матриц №1 и №2 = ");
    PrintArray(ResultMatrix);
}

void PrintArray(int[,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],2} \t"); // {0:D1} чтобы массивы красиво выводились =)
        }
        Console.WriteLine();
    }
}
int n = 3;
int[,] arr = new int[n, n];
int[,] arr2 = new int[n, n];
Random rnd = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(1, 10);
        arr2[i, j] = rnd.Next(1, 10);
    }
}

Console.WriteLine();
Console.WriteLine("Два генерируемых массива:");
Console.WriteLine();
Console.WriteLine("Массив №1:");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Массив №2:");
PrintArray(arr2);
Console.WriteLine();
MultiplicationMatrix(arr, arr2, n);
Console.WriteLine();