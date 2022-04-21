// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// void FillArrayRandom (int m, int n);
// {
//     int [,] matrix = new int [m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i,j] = new Random().Next(-99, 100);
//             Console.Write($"{matrix[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArrayRandom(2,3);

// Задача 2: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.


// void FillArraySumm(int m, int n);
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = i + j;
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// FillArraySumm(2, 3);


// Задача 3:Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// void FillArray(int m, double n)
// {
//     double[,] matrixArray = new double[m, n];




//ДОМАШНИЕ ЗАДАЧИ

// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(int m, int n)
{
    double[,] matrixArray = new double[m, n];
    
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixArray[i, j] = new Random().NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
                Console.Write("{0,6:F2}", matrixArray[i, j]);
            }
        Console.WriteLine();
        }
}


FillArray(3, 4);


// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}


void SearchElement (int i, int j, int[,] matrix)
{
    if (i >= matrix.GetLength(0) || j >=matrix.GetLength(1))
        Console.WriteLine("Элемент с позициями: " + i + "и" + j + " не  найден");
    else    
        Console.WriteLine("Элемент с позициями: " + i + " " + j + " элемент найден" + matrix[i, j]);
}


FillMatrix(3, 5);
SearchElement();

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:


