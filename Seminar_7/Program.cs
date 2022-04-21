// Задайте двумерный массив размером m×n, заполненный случайными целыми двузначныеми числами.

void NewRandomArray (int m, int n)
{
    int [,] matrix = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix [i, j] = new Random().Next(-99, 100);
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}
NewRandomArray (2, 6);


// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по 
// формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

void FindElementInArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = i + j;
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
FindElementInArray(2, 6);


// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените 
// эти элементы на их квадраты.

void FindBothPositiveElements (int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix [i, j] = new Random().Next(1, 10);
            if (i%2 == 0 && j%2 == 0)
            {
                matrix [i, j] =  matrix[i, j] * matrix[i, j];
            }
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
FindBothPositiveElements (3, 3);


// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.

void SumOfElementsOnMainDiagonal (int m)
{
    int sum = 0;
    int[,] matrix = new int[m, m];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            if (i == j)
            {

                sum = sum + matrix[i, j];
            }
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("The sum is: " + sum);
}

SumOfElementsOnMainDiagonal (3);



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