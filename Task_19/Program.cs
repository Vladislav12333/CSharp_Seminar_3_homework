// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int one = number / 10000;
int two = (number % 10000) / 1000;
int three = (number % 1000) / 100;
int four = (number % 100) / 10;
int five = number % 10;

if (one == five && two == four)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
