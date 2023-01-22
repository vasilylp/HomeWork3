// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//_____________________________________________________________________________

System.Console.WriteLine("Введите координаты числа A через запятую : x,y,z");
var A = Console.ReadLine()!.Split(',').Select(s => int.Parse(s)).ToArray();


System.Console.WriteLine("Введите координаты числа B через запятую : x,y,z");
var B = Console.ReadLine()!.Split(',').Select(s => int.Parse(s)).ToArray();

if (A.Length == 3 && B.Length == 3)
{
    int x1 = A[0];
    int y1 = A[1];
    int z1 = A[2];
    int x2 = B[0];
    int y2 = B[1];
    int z2 = B[2];
    double lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    System.Console.WriteLine($"Длинна отрезка AB : {Math.Round(lenght, 2)}");
}
else
{
    System.Console.WriteLine("Вы ввели некорректные данные, попробуйте еще раз!");
}
