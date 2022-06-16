// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

int promt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int a = promt("введите число: ");
int b = a;
var col = new List<int>();
while (b > 0)
{
    col.Add(b % 10);
    b = b / 10;
}
b = 0;
col.Reverse();
for (int mcol = 0; mcol < col.Count; mcol++)
    b = b + col[mcol] * (int)Math.Pow(10, mcol);
if (a == b)
    Console.WriteLine("Данное число является палидромом");
else
    Console.WriteLine("Данное число не является палидромом");


