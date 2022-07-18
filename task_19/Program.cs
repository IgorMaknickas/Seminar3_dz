// // Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
Console.WriteLine("Введите число:");
string num = (Console.ReadLine());
char[] str = num.ToCharArray();
Array.Reverse(str);
string revstr = new string(str);

if (num == revstr)
{
    Console.WriteLine("Введенное число Палиндром");
}
else
{
    Console.WriteLine("Введенное число не Палиндром");
}