// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int GetSumDigit(int number)
{
    int sum = 0;
    while(number>0)
    {
        sum = sum + number % 10;
        Console.WriteLine(sum); // вывод для себя
        number = number/10;
        Console.WriteLine(number); // вывод для себя
    }
    return sum;
}
Console.WriteLine($"Сумма цифр в числе {num} --> {GetSumDigit(num)}");