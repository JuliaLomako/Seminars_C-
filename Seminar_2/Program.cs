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
