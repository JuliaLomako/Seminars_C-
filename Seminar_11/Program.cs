//ДОМАШЕЕ ЗАДАНИЕ

// Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая 
// составит массив десятичных представлений чисел массива data с учётом информации из массива info.
// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); 
// третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)
// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }

// выходные данные:
// 1, 7, 0, 

int[] FillArrayInfo(int lenghtArrayinfo)
{
    int[] userArray = new int[lenghtArrayinfo];

    for (int i = 0; i < lenghtArrayinfo; i++)
    {
        Console.Write("Imput: " + i);
    }
    Console.Write("info = { ");

    for (int j = 0; j < lenghtArrayinfo; j++)
    {
        Console.Write($"{userArray[j]} ");
    }
    Console.WriteLine("}");
    Console.WriteLine();

    return userArray;
}

int[] FillArrayData(int lenghtdata)
{
    int[] userArray = new int[lenghtdata];

    for (int i = 0; i < lenghtdata; i++)
    {
        Console.Write("Imput: " + i);
    }
    Console.Write("data = { ");

    for (int j = 0; j < lenghtdata; j++)
    {
        Console.Write($"{userArray[j]} ");
    }
    Console.WriteLine("}");
    Console.WriteLine();

    return userArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine("get: ");
    for
    {
        (int i = 0; i < array.Length - 1; i++)
    }
    Console.Write($"{array[i]}, ");
Console.WriteLine($"{array[array.Length - 1]}");     
}
PrintArray(FillArrayInfo, FillArrayData);