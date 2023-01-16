Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()?? "0");
if (a < 100)
{
    Console.WriteLine("Третьего числа нет");
}
else if (a >= 100 && a < 1000)
{
    int b = a % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(b);
}
else if (a >= 1000 && a < 10000)
{
    int c = (a / 10) % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(c);
}
else if (a >= 10000 && a < 100000)
{
    int d = (a / 100) % 10;
    Console.WriteLine("Третье число равно");
    Console.WriteLine(d);
}