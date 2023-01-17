// Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// void FillArray(int[] array)
// {
//     Console.Write("[ ");

//     int i = 0;

//     while (i < array.Length)
//     {
//         Random rnd = new Random();
//         int q = rnd.Next(1, 11);
//         if (СheckingForMatch(q, array) == true)
//         {
//             array[i] = q;
//             Console.Write(array[i] + " ");
//             i++;
//         }

//     }

//     Console.Write("]");
// }

// bool СheckingForMatch(int n, int[] arr) // Метод проверяет число на совпадение. Правда/Лож
// {
//     bool run = true;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (n == arr[i])
//         {
//             run = false;
//             break;
//         }

//     }
//     return run;
// }

// Console.Clear();
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];


// FillArray(array);
// PrintArray(array);




// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         int q = rnd.Next(1, 11);
//         if (СheckingForMatch(q, array) == true)
//         {
//             array[i] = q;
//             Console.Write(array[i] + " ");
//             i++;
//         }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j],2} \t");
//         Console.WriteLine();
//     }
// }



int[,,] CreateMatrix (int [,,] array3D) 
{
    Random rnd = new Random();   
    for (int i = 0; i < array3D.GetLength(0); i++) 
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
                {
                    array3D[i,j,k] = rnd.Next(1, 100);
                    
                }
        }
    }
    return array3D;
} 
 
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i, j, k], 5}");            
            }
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
int[,,] array3D = new int [a,n,m];
CreateMatrix(array3D);
PrintMatrix(array3D);