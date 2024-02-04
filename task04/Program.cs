// Задача 4: 
// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

int N = 158345;
int i = 1;
int count = 0;
while (i < N)
{
    i = i * 10;
    count++;
}
int [] allDigits = new int[count];
count = 0;
for (int j = i / 10; j >= 1; j = j / 10)
{
    int digit = N / j;
    digit = digit % 10;
    allDigits[count] = digit;
    count++;
}
Console.Write(string.Join(", ", allDigits));