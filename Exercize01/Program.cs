System.Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    System.Console.WriteLine("Первое число " + a + " больше второго числа " + b);
}
else if (a < b)
{
    System.Console.WriteLine("Первое число " + a + " меньше второго числа "+ b);
}
else
{
    System.Console.WriteLine("Первое число равно второму числу");
}
