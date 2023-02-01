Console.WriteLine("Введите номер четверти");
int a = int.Parse(Console.ReadLine()?? "0");
while (a < 0 || a > 4)
{
    Console.WriteLine("Некорректный ввод");
    a = int.Parse(Console.ReadLine()?? "0");
}
if (a == 1)
{
    Console.WriteLine("Для первой четверти: x (0; +∞), y (0; +∞)");
}
else if (a == 2)
{
    Console.WriteLine("Для второй четверти: x (0; -∞), y (0; +∞)");
}
else if (a == 3)
{
    Console.WriteLine("Для третьей четверти: x (0; -∞), y (0; -∞)");
}
else if (a == 4)
{
    Console.WriteLine("Для четвертой четверти: x (0; +∞), y (0; -∞)");
}