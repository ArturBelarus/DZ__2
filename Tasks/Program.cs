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

    bool result10 = CheckNumber(threeDigitNumber);
    int secondDigit = GiveSeconDigit(threeDigitNumber);

    if (result10)
    {
        Console.WriteLine($"{secondDigit}");
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}