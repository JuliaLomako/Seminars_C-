//Задача 1: Написать программу которая принимает целое число и возвращает квадрат этого числа

//варинат 1

int value = 5;
Console.WriteLine("Квадрат числа равен ");
Console.WriteLine(value * value);


// //варинат 2

int value = 5;
// вводим новую переменную - итоговую
int kvadrat_value = value * value;
Console.Write("Квадрат числа равен ");
Console.WriteLine(kvadrat_value);

//Задача 2: Написать программу которая принимает два числа и проверяет являеся ли первое число квадратом второго

Console.WriteLine("Введите первое целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());
int kvadrat_num = num2 * num2;
if (kvadrat_num == num1)
{
    Console.WriteLine("Первого число является квадратом второго числа");
}
else
{
        Console.WriteLine("Первое число НЕ является квадратом второго числа");
}


//Задача 3: Написать программу которая принимает число и выдает 
//какому дню недели оно соответствует

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 7 && number >= 1)
{
    if (number == 1)
    {
        Console.WriteLine("Понедельник");
    }

    if (number == 2)
    {
        Console.WriteLine("Вторник");
    }

    if (number == 3)
    {
        Console.WriteLine("Среда");
    }

    if (number == 4)
    {
        Console.WriteLine("Четверг");
    }
    
    if (number == 5)
    {
        Console.WriteLine("Пятница");
    }
    
    if (number == 6)
    {
        Console.WriteLine("Суббота");
    }

    if (number == 7)
    {
        Console.WriteLine("Воскресенье");
    }
}
else
{
    Console.WriteLine("Такого дня недели нет");
}


//Задача 4: Написать программу которая на ввод принимает одно число и на выходе 
//выдает от минусового значения этого числа до этого числа

Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

int negNum = num * (-1);
while (negNum <= num)
{
    Console.WriteLine(negNum);
    negNum++;
} 



//ЗАДАЧИ ИЗ ДОМАШНЕГО ЗАДАНИЯ

// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine("число " + numA + " больше числа " + numB);
}
else
{
    Console.WriteLine("число " + numB + " больше числа " + numA);
}



// Задача 2: Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.


Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if(numB > max) max = numB;
if(numC > max) max = numC;

Console.Write("Максимальное число = " + max);



// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).


Console.WriteLine("Введите число");
int n  = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine("число является четным");

}
else
{
    Console.WriteLine("число является НЕ четным");
}


// Задача 4: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int n2 = 2;
while (n2 <= n)
{
    Console.WriteLine(n2);
    n2+=2;
}

