Console.WriteLine("Введите порядковый номер дня недели");
int a = int.Parse(Console.ReadLine()?? "0");
while(a > 7 || a < 1)
{
    Console.WriteLine("Введено некорректное число");
    a = int.Parse(Console.ReadLine()?? "0");
}

if (a >=1 && a < 6)
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Выходной день");
}