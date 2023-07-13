// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = (n/10000)%10;
int b = (n/1000)%10; 
int d = (n/10)%10;
int e = n%10;

while (n < 10000 || n > 999999)
{   
    Console.Write("Введите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

if (a == e && b == d)
    Console.WriteLine("да");
else 
    Console.WriteLine("нет");