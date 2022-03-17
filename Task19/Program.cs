// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 10000;
//Console.WriteLine(firstDigit);

int secondDigit = number / 1000 % 10;
//Console.WriteLine(secondDigit);

int fourthDigit = number / 10 % 10;
//Console.WriteLine(fourthDigit);

int fifthDigit = number % 10;
//Console.WriteLine(fifthDigit);

if (firstDigit == fifthDigit && secondDigit == fourthDigit)
{
    Console.WriteLine(number + " - пятизначный полиндром");
}
else
{
    Console.WriteLine(number + " - не является пятизначным полиндромом");
}
