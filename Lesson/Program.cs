// Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] newarray = new int[rows, cols];
// FillArray(newarray);
// PrintArray(newarray);
// SwitchArray(newarray);
// Console.WriteLine("Массив после замены строк:");
// PrintArray(newarray);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-9, 10);
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
// void SwitchArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         (array[0, i], array[array.GetLength(0) - 1, i]) = (array[array.GetLength(0) - 1, i], array[0, i]);
//     }
// }



// Задача 55: Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Console.Write("Введите количество строк: ");
// int numRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int numCols = Convert.ToInt32(Console.ReadLine());

// if (numRows!=numCols) {Console.WriteLine("Заменить строки на столбцы невозможно"); return;}
// int [,] array = new int [numRows,numCols];

// FillArray (array);
// PrintArray(array);
// Console.WriteLine("Массив после замены строк:");
// NewArray(array);
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);
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

// void NewArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             (array[i,j], array[j,i]) = (array[j,i],array[i,j]);

//         }
// }


// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} \t");
        Console.WriteLine();
    }
}

void Matrix(int[,] array)
{
    int[] newarray = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            newarray[array[i, j]] += 1;
        }
    }

    for (int i = 0; i < newarray.Length; i++)
    {
        if (newarray[i] == 0)
        {

        }
        else
        {
            Console.Write($"{i} встречается {newarray[i]} раз ");
            Console.WriteLine();
        }
    }
}






Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];


FillArray(array);
PrintArray(array);
Matrix(array);







// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} \t");
        Console.WriteLine();
    }
}

void Matrix(int[,] array)
{
    int[,] newarray = new int[,];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    
        for (int j = 0; j < array.GetLength(1); j++)
        
            if (min > array[i, j])
            {
                min = array[i, j];
                int minindexi = i;
                int minindexj = j;
            }      
    
}



Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];


FillArray(array);
PrintArray(array);