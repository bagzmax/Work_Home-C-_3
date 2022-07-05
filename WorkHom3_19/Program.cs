// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//14212 -> нет
//23432 -> да

Console.Write ("Введите число элементов массива: ");
int Count = int.Parse (Console.ReadLine()!);
Console.WriteLine();
int[] array = new int [Count];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i}-й элемент массива: ");
    array[i] = int.Parse(Console.ReadLine()!);
}
Console.Write("\nВывод массива: ");
foreach (int i in array)
{
    Console.Write(i);
}
//for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
//System.Console.WriteLine();
//int [] array = {8, 7, 33, 55, 33, 7, 8};
//int step = array.Length;
//int j = step - 1;
bool flag = true;

for (int i = 0; i < array.Length / 2; i++)
{
    if (array[i] != array[array.Length - 1 -i])
    {
       flag = false;
       break;
    } 
}
    if (flag)
    {
       Console.WriteLine("это палиндром");
        //Console.WriteLine($"\nНет совпадения позиций с индексами {i} и {array.Length - 1 -i}" + $" - не палиндром");
      //System.Console.WriteLine($"совпадение позиции с индексом {i} и {j}"); 
      //j -=1; 
    }
    else
    {    
      Console.WriteLine("не палиндром");
        //Console.WriteLine($"\nЕсть совпадение позиций с индексами {i} и {array.Length - 1 -i}" + $" - это палиндром");
        //Console.WriteLine($"не совпали позиции с индексами {i} и {j}");
        //j -=1;
    }


