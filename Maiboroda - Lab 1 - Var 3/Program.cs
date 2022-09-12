// See https://aka.ms/new-console-template for more information

Console.WriteLine("Формула: G = n(y + 3.5) + корень из y");
Console.WriteLine(" ");
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine(" ");

double G = n * (y + 3.5) + Math.Sqrt (y) ;
Console.WriteLine($"{n} * ({y} + 3.5) + {Math.Sqrt (y):F3} = {G:F2}");
