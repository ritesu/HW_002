Console.WriteLine("Введите трехзначное число");
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