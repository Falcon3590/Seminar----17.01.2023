// Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


bool FindElem(int[,,] array3D, int N)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
                if (N == array3D[i, j, k]) return false;

        }
    }
    return true;
}

int[,,] CreateMatrix(int[,,] array3D)
{
    Random rnd = new Random();
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            int k = 0;
            while (k < array3D.GetLength(2))
            {
                int temp = rnd.Next(1, array3D.Length + 1000);

                if (FindElem(array3D, temp))
                {

                    array3D[i, j, k] = temp;

                    k++;
                }
            }
        }
    }
    return array3D;
}

void PrintMatrix(int[,,] matrix)
{

    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)

            {
                Console.Write($"{matrix[i, j, k],5} ({i}, {j}, {k})");
            }
            System.Console.WriteLine();
        }
        Console.WriteLine();
    }
}



Console.Clear();
Console.WriteLine("Введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество уровней");
int m = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[a, n, m];
CreateMatrix(array3D);
PrintMatrix(array3D);