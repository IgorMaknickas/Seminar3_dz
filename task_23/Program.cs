// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
double Result(int iLocal)
{
    return Math.Pow(iLocal, 3);
}
for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Result(i));
}