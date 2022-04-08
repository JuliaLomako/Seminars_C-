//Задача в Kahoot (ответ: перевернутое число 1234 = 4321 (False))

int x = 1234;
int a1 = x % 10;
int a2 = x / 10 % 10;
int a3 = x / 100 % 10;
int a4 = x / 1000; 
x = a1 * 1000 + a2 * 100 + a3 * 1000 + a4;
Console.WriteLine(x == 1);


//Задача 1: Написать метод принимающий на вход координаты точки в 
//двумерной плоскости и определяющий в какой четверти эта точка будет находится 


int GetQuart(double Xpoint, double Ypoint)
{
    if (Xpoint > 0 && Ypoint > 0) return 1;
    if (Xpoint < 0 && Ypoint > 0) return 2;
    if (Xpoint < 0 && Ypoint < 0) return 3;
    if (Xpoint > 0 && Ypoint < 0) return 4;
    return 0;
}

//Важный момент - метод принимает тип double, а возвращать будет int

double x, y;
int quartNum;

Console.WriteLine("Введите координату X: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
y = Convert.ToDouble(Console.ReadLine());

quartNum = GetQuart(x, y);
if (quartNum == 0) Console.WriteLine("Нельзя определить четверть");
else Console.WriteLine("Данная точка находится в " + quartNum + " четверти");



// Задача 2: Написать программу которая выводит на экран диапозон координат,  
//а принимает на вход номер четверти


void Quart(int chetvert)
{
    if (chetvert == 1) Console.WriteLine("В данной четверти диапозон координат: X > 0, Y > 0");
    if (chetvert == 2) Console.WriteLine("В данной четверти диапозон координат: X < 0, Y > 0");
    if (chetvert == 3) Console.WriteLine("В данной четверти диапозон координат: X < 0, Y < 0");
    if (chetvert == 4) Console.WriteLine("В данной четверти диапозон координат: X > 0, Y < 0");
}

int N;
Console.WriteLine("Введите номер четверти: ");
N = Convert.ToInt32(Console.ReadLine());
Quart(N);


//вариант метода через SWiTCH

void Quart(int ch)
{
    switch (ch)
    {
        case 1: 
        {
            Console.WriteLine("В данной четверти диапозон координат: X > 0, Y > 0");
            break;
        } 
    
        case 2:
        {
            Console.WriteLine("В данной четверти диапозон координат: X < 0, Y > 0");
            break;

        } 
        case 3:
        {

            Console.WriteLine("В данной четверти диапозон координат: X < 0, Y < 0");
            break;
        }
        
        case 4: 
        {
            Console.WriteLine("В данной четверти диапозон координат: X > 0, Y < 0");
            break;
        }
        
        default:
        {
            Console.WriteLine("такой четверти не существует");
            break; 
        }   
    }
    
}

int N;
Console.WriteLine("Введите номер четверти: ");
N = Convert.ToInt32(Console.ReadLine());
Quart(N);


//Задача 3: Написать программу принимающую на вход координаты двух точек и 
//находит расстояние между ними

double GetDistance (double x1, double y1, double x2, double y2)
{
    double xDis = x2 - x1;
    double yDis = y2 - y1;
    return Math.Sqrt(Math.Pow(xDis,2) + Math.Pow(yDis,2)); 
}

double xA, yA, xB,yB;
int distance;

Console.Write("Введите координату X для точки А: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для точки А: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X для точки B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y для точки B: ");
yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetDistance(xA, yA, xB, yB));


//ДОМАШНИЕ ЗАДАЧИ

//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.


int n1; 
int n2;
int n3;
int n4;
int n5;

if(n1 == n5 && n2 == n4)
    {
    Console.WriteLine("число является палиндромом");
    }
else 
    {
        Console.WriteLine("число не является палиндромом");
    }

Console.WriteLine("Введите пятизначное число: ");
Convert.ToInt32(Console.ReadLine());

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.


double findDistans(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDis = x2 - x1;
    double yDis = y2 - y1;
    double zDis = z2 - z1;
    return Math.Sqrt(Math.Pow(xDis,2) + Math.Pow(yDis,2) + Math.Pow(zDis,2));
}

double xA, yA, zA, xB, yB, zB;
double distanse;

Console.Write("Input x of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z of point A");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x of point B: "); 
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y of point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z jf point B: ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(findDistans(xA, yA, zA, xB, yB, zB));



// //Задача 23
// //Напишите программу, которая принимает на вход число (N) и выдаёт 
// //таблицу кубов чисел от 1 до N.



double CubN(double n)
{
    double n = 1;
    double n1 = Math.Pow(n,3); 

    if (n1 == n)
    {
        Console.WriteLine("stop");
    }
    else
    {
        n1++;
        Console.WriteLine();
          
    }
    return n2;
}

Console.Write("Input a number: ");
double numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CubN(numA));