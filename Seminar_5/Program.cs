// Задача 1: Необходимо задать массив из 12 эллементов заполненный случайными числами 
// в промежутке от -9 до + 9, и необходимо найти сумму отрицательных  
// и полодителных чисел (два разных счеткчика)

// int[] Mass = new int[12];
// int pozN = 0, negN = 0;
// for (i = 0; i < 12; i++)
// {
//     Mass[i] = new Random().Next(-9, 10);
//     if (Mass[i] > 0) pozN = Mass[i] + pozN;
//     else negN = negN + Mass[i];
//     //Console.WriteLine(Mass[i]);
// }

// Console.WriteLine($" сумма + чисел: {pozN}, а сумма - чисел: {negN}");

// Задача 2: Перевернуть элем массива не по порядку а по знаку 
// (если эллемент был отрицательный , меняем на положительный)

// int mass = new int[12];
// for (int i = 0; i < 12; i++)
// {
//     mass[i] = new Random().Next(-9, 10);
//     Console.WriteLine(mass[i] + " ");
// }

// Console.WriteLine();
// for (int i = 0; i < 12; i++)
// {
//     Console.WriteLine((mass[i] * (-1)) + " ");
// }


// Задача 3: Задать произольный  массив и написать программу которая будет отвечать 
//на вопрос имеется ли это число в массиве (да/нет)

int[] arra = new int[15];
int tumbler = 0;
for (int i = 0; i < 15; i++)
{
    arra[i] = new Random().Next(1, 20);
    Console.WriteLine(arra[i] + " ");
}
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


// Задача 5: Необходимо найти произвдение пар эллементов в массиве и эти эллемнты 
//необходимо записать новые числа в новый массив