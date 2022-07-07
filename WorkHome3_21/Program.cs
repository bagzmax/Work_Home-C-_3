// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double ax, ay, az, bx, by, bz;

System.Console.Write("Введите координаты точки ax: ");
ax = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координаты точки ay: ");
ay = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координаты точки az: ");
az = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координаты точки bx: ");
bx = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координаты точки by: ");
by = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координаты точки bz: ");
bz = Convert.ToDouble(Console.ReadLine());

void printGipotenuza(double ax, double ay, double az, double bx, double by, double bz)
{
    double deltaX = ax - bx;
    double deltaY = ay - by;
    double deltaZ = az - bz;
    double distance = Math.Round(Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ), 2);
    System.Console.WriteLine("Расстояние между точками в 3D пространстве: " + distance);
}
printGipotenuza(ax, ay, az, bx, by, bz);
