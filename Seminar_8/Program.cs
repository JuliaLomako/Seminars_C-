//Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


//Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.


//Задаач 3: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых 
//расположен наименьший элемент



//ДОМАШНИЕ ЗАДАЧИ

// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    tem = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = tem;
                }
            }
        }
    }
    Console.WriteLine();
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = FillArray(3, 4);
SortArray(matrix);
PrintArray(matrix);


// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinSum(int[,] array)
{
    int minNumSum = int.MaxValue;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summa += array[i, j];

        }
        Console.WriteLine($"строка {i + 1}: {summa}");
        if (summa < minNumSum)
        {
            minNumSum = summa;
            result = i;
        }
    }
    Console.WriteLine($"строка с наименьшей суммой элементов {result + 1}.");
}


// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)


int[,,] TreeDimensionalArray(int matrix)
{
    int num = 1;
    Random rnd = new Random();
    int number = rnd.Next(5, 10);
    Console.WriteLine();
    int[,,] array3D = new int[matrix, matrix, matrix];
    for (int i = 0; i < matrix; i++)
    {
        for (int j = 0; j < matrix; j++)
        {
            for (int k = 0; k < matrix; k++)
            {
                array3D[i, j, k] = number + number * num;
                num++;
            }
        }
    }
    return array3D;
}

void PrintTreeDimensionalArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + $"({i},{j},{k}) ");
            }
            Console.WriteLine("");
        }
    }
}

// Задача 4: Заполните спирально массив 4 на 4.
// На выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int[,] GetSpire(int n)
{
    int[,] spireArray = new int[n, n];
    int i = 0;
    count = 1;
    while (i < (int)n / 2)
    {
        for (j = i; j < n - 1 - i; j++)
            spireArray[i, j] = count++;
        for (n = i; n < n - 1 - i; n++)
            spireArray[n, j] = count++;
        for (k = j; k > i; k--)
            spireArray[n, k] = count++;
        for (m = n; m > i; m--)
            spireArray[m, k] = count++;
        i++;
    }
    if (n % 2 != 0) spireArray[i, i] = count;
    return spireArray;
}

