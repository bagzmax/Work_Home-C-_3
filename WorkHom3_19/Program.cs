// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//14212 -> нет
//23432 -> да

Console.Write ("Введите пятизначное число: ");
string number = Console.ReadLine()!;
int len = number.Length;

void CheckingNumber(string number)
{
bool flag = true;

for (int i = 0; i < len/2; i++) {
    if (number[i] != number[len - (i + 1)]) {
        flag = false;
        break;
    }      
}
if (flag) {
    Console.WriteLine("{0} это палиндром", number);
}
else Console.WriteLine("{0} это не палиндром", number);
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введите правильное число");