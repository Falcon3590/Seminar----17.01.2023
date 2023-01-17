// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void PrintArray(int[,] arr) //  метод вывода массива на консоль. Использую два раза.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

int[,] arr = new int[5, 5];  
Random rnd = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(10, 99);
    }
}

Console.WriteLine();
Console.WriteLine("Вывод генерируемого массива:");
PrintArray(arr);


int[] HelpArr = new int[arr.GetLength(0)];

for (int i = 0; i < arr.GetLength(0); i++) // for в for вместо Array.Sort() в порядке возрастания + переворот.
{

    for (int j1 = 0; j1 < arr.GetLength(1); j1++)
    {
        int MaxNumber = 0;

        int ind = 0;

        for (int j2 = 0; j2 < arr.GetLength(1); j2++)
        {
            if (MaxNumber < arr[i, j2])
            {
                MaxNumber = arr[i, j2];
                ind = j2;
            }

        }

        arr[i, ind] = 0;

        HelpArr[j1] = MaxNumber;
    
    }

    for (int k = 0; k < arr.GetLength(1); k++) // Можно использовать Array.Copy();
    {
        arr[i, k] = HelpArr[k];
    }

}
Console.WriteLine();
Console.WriteLine("Вывод отсортированного массива:");
PrintArray(arr);
