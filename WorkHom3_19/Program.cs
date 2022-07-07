// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//14212 -> нет
//23432 -> да


Console.Write("Введите пятизначное число:");
string? number = Console.ReadLine();
if (number!.Length == 5)
{
if (number[0] == number[4] && number[1] == number[3])
{ System.Console.WriteLine("{0} это палиндром", number); }
else
{ System.Console.WriteLine("{0} это не палиндром", number); }  
}
else Console.WriteLine($"Введите правильное число");