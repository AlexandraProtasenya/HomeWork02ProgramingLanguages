// Задача 3: 
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int number = 12; // 10 <= number <= 99
if (number > 9 && number < 100)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
         Console.WriteLine(secondDigit);
    }
}
else
{
    Console.WriteLine($"Число {number} не вхродит в указанный диапазон");
}