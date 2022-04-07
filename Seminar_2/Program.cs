//Задача 1: Генирируем случайное двузначное число от 10 до 99, 
//на авыходе выводим большую цифру этого числа. Например: 78 - 8 большее число.


int numMax(int num)
{
    int nMax1 = num % 10;
    int nMax2 = num / 10;

    if (nMax1 > nMax2)
    {
        return nMax1;
    }
    else
    {
        return nMax2;
    }

}

int number = new Random().Next(10, 99);
Console.WriteLine("дано двузначное число " + number + " максимальная цифра которго" + numMax(number));

// Задача 2: Программа принимает 3-х значное число - написать программу которая удаляет 
// вторую цифру от числа и выводит то, что осталось. 


int numTri(int num)
{
    int n1 = (num / 100) * 10; 
    int n2 = num % 10;
    return n1 + n2;  
} 

int number = new Random().Next(100, 1000);
Console.WriteLine(number + " --> " + numTri(number));



// Задача 3: Необходимо напистаь программу  которая берет на вход  два числа и опеделяет 
// явлется ли одно число кратное другому. 
// вывод: кратное или нет: 8 и 2 - вывод: числа кратные


void Chastnoe(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine("кратное");
    }
    else
    {
        Console.WriteLine("имеет остаток - " + num1 % num2 + " - числа не кратные друг другу");
    }
}


Console.WriteLine("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Chastnoe(numberA, numberB);


// Задача 4 Написать программу которая принимает на вход одно число, затем принимает еще два числа 
// которые проверяют является ли первое число кратным двум другим одновременно  


void Proverka(int num1, int num2, int num3)
{
    if (num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.WriteLine("первое число является кратным второму и третьему");
    }
    else
    {
        Console.WriteLine("первое число не является кратным второму и третьему");
    }
}

Console.WriteLine("введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите третье число");
int numberС = Convert.ToInt32(Console.ReadLine());
Proverka(numberA, numberB, numberС);