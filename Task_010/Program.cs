Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()?? "0");
while(a > 1000 || a <= 99)
{
    Console.WriteLine("Введено некорректное число");
    a = int.Parse(Console.ReadLine()?? "0");
}
int b = (a / 10) % 10;
Console.WriteLine("Второе число равно");
Console.WriteLine(b);
