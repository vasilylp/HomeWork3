// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//_________________________________________________________


System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = 1;

while(x < n && x > 0)
{
    
    System.Console.Write($"{Math.Pow(x,3)},");
    x++;
}
System.Console.Write($"{Math.Pow(n,3)}"); 