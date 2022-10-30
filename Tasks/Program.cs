// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

int GiveSeconDigit(int number)
{
    number = number / 10;
    int secondDigit = number % 10;
    return secondDigit;
}

bool CheckNumber(int number)
{
    number = number / 100;
    return number > 0 & number < 10;
}


{
    Console.WriteLine("Введите трех значное число");
    int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

    bool result = CheckNumber(threeDigitNumber);
    int secondDigit = GiveSeconDigit(threeDigitNumber);

    if (result)
    {
        Console.WriteLine($"{secondDigit}");
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int GiveThirdDigit(int number)
{
    number = number / 100;
    int thirdDigit = number % 10;
    return thirdDigit;
}
bool CheckThirdDigit(int number)
{
    number = number / 100;
    return number > 0;
}

{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    bool result = CheckThirdDigit(num);
    int thirdDigit = GiveThirdDigit(num);

    if (result)
    {
        Console.WriteLine($"{thirdDigit}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

// Задача 15 - Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool CheckWeeKend(int number)
{
    return number == 6 | number == 7;
}
bool CheckWeeDay(int number)
{
    return number > 0 & number < 8;
}

{
    Console.WriteLine("Введите номер любого дня недели");
    int dayWeek = Convert.ToInt32(Console.ReadLine());

    bool result = CheckWeeKend(dayWeek);
    bool check = CheckWeeDay(dayWeek);

    if(check)
    {
        if (result)
        {
            Console.WriteLine("Выходной");
        }
        else
        {
            Console.WriteLine("Не выходной");
        }
    }   
    else
    {
        Console.WriteLine("Это не день недели");
    }
}