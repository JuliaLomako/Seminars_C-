//Задача 1: Написать программу, которая принимает на вход число (N) и выдает сумму числет от 1 до N


//Вариант решения через WHILE

int Sum(int A)
{
    int result = 0;
    int i = 1;
    while (i <= A)
    {
        result = result + i;
        i++;
    }
    return result;
}

Console.WriteLine("Введите целое натуральное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"сумма чисел от 1 до {numA} равна {Sum(numA)}");

// вариант черезе FOR

int Sum(int A)
{
    int result = 0;
    for (int i = 1;i <= A; i++)
    result = result + i;
    return result;
}

Console.WriteLine("Введите целое натуральное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"сумма чисел от 1 до {numA} равна {Sum(numA)}");


//Задача 2: Написать программу, которая принимает на вход число и выдает количество цифр 

void Dlinna(int N)
{
    int l = 1;
    while (Math.Abs(N / 10 > 1)) //ABS работает с обсолютной величиной (если вдруг число отрицательное будет)
    {
        N = N/10;
        l++;
    }
   Console.WriteLine("Количество цифр в введенном числе: " + l);
}

//так же можно через цикл For

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
Dlinna (number);

//Задача 3: Написать программу, которая принимает на вход число и выдает произведение чисел 

//P.S. Так же можно реализовать через For

int Proizvedenie (int N)
{
    int result = 1;
    int i = 1;           // почему здесь 1, а не 0 как в первой задачи - потому, что умножать на 0 нельзя))
    while (i <= N)
    {
        result = result * i;
        i++;
    }
    return result;
}

Console.WriteLine("Введите целое натуральное число: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numN < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"произведение чисел от 1 до {numN} равна {Proizvedenie(numN)}");



//Задача 4: Написать программу, вывести массив из 8-ми эллументов заполнеными цифрами 0 1 в случайном порядке 

void bitArray()
{
    int[] a = new int[8];
    for (int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0,2);
        Console.Write(a[i] + " ");
    }
}  

bitArray();