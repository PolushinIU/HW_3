// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

int promt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = promt("Введите число: ");
int y1 = promt("Введите число: ");
int z1 = promt("Введите число: ");
int x2 = promt("Введите число: ");
int y2 = promt("Введите число: ");
int z2 = promt("Введите число: ");
int a = x2 - x1;
int b = y2 - y1;
int c = z2 - z1;
double len = Math.Sqrt(a * a + b * b + c * c);
System.Console.WriteLine("Расстояние между ними в 3D пространстве = " + len);
