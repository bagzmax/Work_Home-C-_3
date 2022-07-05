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
// System.Console.WriteLine(IsPalindrome);

int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int i in numbers)
{
    Console.Write(i + " ");
}

string text = Console.ReadLine();
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
    Console.WriteLine("{0} is palindrome", text);
}
else
{
    Console.WriteLine("{0} is not palindrome", text);
}
