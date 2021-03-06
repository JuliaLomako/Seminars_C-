// Задача 1: Необходимо задать массив из 12 эллементов заполненный случайными числами 
// в промежутке от -9 до + 9, и необходимо найти сумму отрицательных  
// и полодителных чисел (два разных счеткчика)

int[] Mass = new int[12];
int pozN = 0, negN = 0;
for (i = 0; i < 12; i++)
{
    Mass[i] = new Random().Next(-9, 10);
    if (Mass[i] > 0) pozN = Mass[i] + pozN;
    else negN = negN + Mass[i];
    Console.WriteLine(Mass[i]);
}

Console.WriteLine($" сумма + чисел: {pozN}, а сумма - чисел: {negN}");

// Задача 2: Перевернуть элем массива не по порядку а по знаку 
// (если эллемент был отрицательный , меняем на положительный)

int mass = new int[12];
for (int i = 0; i < 12; i++)
{
    mass[i] = new Random().Next(-9, 10);
    Console.WriteLine(mass[i] + " ");
}

Console.WriteLine();
for (int i = 0; i < 12; i++)
{
    Console.WriteLine((mass[i] * (-1)) + " ");
}


// Задача 3: Задать произольный  массив и написать программу которая будет отвечать 
//на вопрос имеется ли это число в массиве (да/нет)

int[] arra = new int[15];
int tumbler = 0;
for (int i = 0; i < 15; i++)
{
    arra[i] = new Random().Next(1, 20);
    Console.Write(arra[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Введите цифру");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 15; i++)
{
    if (arra[i] ==num)
    {
        Console.WriteLine("число найдено");
        tumbler = 1;
        break;
    }
}
if (tumbler ==0) Console.WriteLine("число не найдено");

// Задача 4: Необходимо создать одномерный массив из 123 случайных числе и найти кол-во 
// эллементов которовые лежит в отрездок от 10 до 99 


int[] array = new int[123];
int count = 0;
for (int i = 0; i < 123; i++)
{
    array[i] = new Random().Next(1,1000);
    if (array[i] < 100 && array[i] > 9) count++;
}

Console.WriteLine(count);


// Задача 5: Необходимо найти произвдение пар эллементов в массиве и эти эллемнты 
//необходимо записать новые числа в новый массив

Console.WriteLine("Введите длинну массива");
int num = Convert.ToInt32(Console.ReadLine());
int[]array = new int[num];

int dlina = 1;
if (num % 2 == 0) dlina = 0;
int[] array2 = new int[(num / 2) + dlina];

for(int i = 0; i < num; i++)
{
    array[i] = i + 1;
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < ((num / 2) + dlina); i++)
{
    array2[i] = array[i] * (array[num - i - 1]);
    if (i == num - i - 1) array2[i] = array[i];
    Console.Write(array2[i] + " ");
}



// ДОМАШНИЕ ЗАДАЧИ


// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] ArrayNum(int sizeA)
{
    int[] massiv = new int[sizeA];
    for (int i = 0; i < sizeA; i++)
    {
        massiv[i] = new Random().Next(100, 300);
        Console.Write(massiv[i] + " ");
    }
    return massiv;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt16(Console.ReadLine());
int[] arrySize = ArrayNum(size);
int count = 0;
for (int i = 0; i < size; i++)
{
    if (arrySize[i] % 2 == 0) count++;
}
Console.Write("Выведены все четные числа в массиве");


// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.


int[] Array()
{
    Console.WriteLine("Введите размер массива ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    int[] arrayA = new int[arraySize];
    for(int i = 0; i < arraySize; i++)
        {
        arrayA[i] = new Random().Next(1,100);
        Console.Write(arrayA[i] + " ");
        }
    Console.WriteLine();        
    return  arrayA; 
}
int[] arrayNum = Array();
int sum = 0;
for (int i = 0; i < 100; i += 2) sum += arrayNum[i];
Console.WriteLine("Сумма нечетных элеменнотв равна  " + sum);


// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



double[] Array()
{
    Console.WriteLine("Введите размер массива ");
    int size = Convert.ToInt16(Console.ReadLine());
    double[] num_array = new double[size];
    for (int i = 0; i < size; i++)
    {
        num_array[i] = new Random().NextDouble();
        Console.Write(num_array[i] + " ");
    }
    Console.WriteLine();
    return num_array;
}

double[] array = Array();
double max = double.MinValue, min = double.MaxValue;
foreach (double number in array)
{
    Console.Write("{0} ", number);
    if (number > max) max = number;
    if (number < min) min = number;
}
Console.WriteLine($"разница между мин и макс равна " + (max - min));
