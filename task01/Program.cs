// Задача 1: 
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

int number = 805;
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine ($"{number} кратно 7 и 23");
}
else
{
    Console.WriteLine ($"{number} не кратно 7 и 23");
}