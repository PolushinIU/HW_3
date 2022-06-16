// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
int promt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int number = promt("Введите число: ");
int count = 0;
while (count < number)
{
    count++;
    System.Console.WriteLine(count * count * count);
}