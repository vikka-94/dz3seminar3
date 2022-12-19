//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите х1: ");
int x1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите y1: ");
int y1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите c1: ");
int c1 = int.Parse (Console.ReadLine()!);

Console.WriteLine("Введите x2: ");
int x2 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите y3: ");
int y2 = int.Parse (Console.ReadLine()!);
Console.WriteLine("Введите z3: ");
int c2 = int.Parse (Console.ReadLine()!);
double distance = 0;

distance = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(c2-c1, 2)!);
Console.WriteLine(Math.Round(distance,2)!);
