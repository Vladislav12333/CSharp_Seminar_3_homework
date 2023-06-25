// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки A (x1 y1 z1): ");
string[] inputA = Console.ReadLine().Split();

Console.Write("Введите координаты точки B (x2 y2 z2): ");
string[] inputB = Console.ReadLine().Split();

double x1 = double.Parse(inputA[0]);
double y1 = double.Parse(inputA[1]);
double z1 = double.Parse(inputA[2]);

double x2 = double.Parse(inputB[0]);
double y2 = double.Parse(inputB[1]);
double z2 = double.Parse(inputB[2]);

double distance = (Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2));

Console.WriteLine($"Расстояние между точками A({x1}, {y1}, {z1}) и B({x2}, {y2}, {z2}) равно {distance}");