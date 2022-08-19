/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */
Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
string number = Console.ReadLine();

if (number.Length == 5)
{
	if (number[0] == number[4] && number[1] == number[3])
	{
		System.Console.WriteLine("Является палиндромом");
	}
	else System.Console.WriteLine("Не является палиндромом");
}
else System.Console.WriteLine("Вы ввели не пятизначное число!");
