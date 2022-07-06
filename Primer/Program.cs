//var v = 12321;
// var s = v.ToString();
// bool IsPalindrome(string s);
// for (int i = 0; i < s.Length / 2; ++i)
// {
//     if (s[i] != s[s.Length - 1 - i])
//     {
//         return false;
//     }    
//     return true;
// }
// Console.WriteLine(IsPalindrome);

//int[] numbers = { 1, 2, 3, 4, 5 };
// foreach (int i in numbers)
// {
//     Console.Write(i + " ");
// }

Console.Write ("Введите число: ");
string text = Console.ReadLine()!;
int len = text.Length;
bool flag = true;

for (int i = 0; i < len/2; i++)
{
    if (text[i] != text[len - (i + 1)])
    {
        flag = false;
        break;
    }      
}
if (flag)
{
    Console.WriteLine("{0} это палиндром", text);
}
else
{
    Console.WriteLine("{0} это не палиндром", text);
}
