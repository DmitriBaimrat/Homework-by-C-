System.Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine("Число " + number + " четное");
}
else
{
    System.Console.WriteLine("Число " + number + " нечетное");
}