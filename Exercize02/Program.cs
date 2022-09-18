System.Console.Write("Введите первое число ");
int number1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());

System.Console.Write("Введите третье число ");
int number3 = int.Parse(Console.ReadLine());

int max = 0;

if (number1 > max)
{
    max = number1;
}
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

System.Console.WriteLine("Первое число " + number1 + ", второе " + number2 + " и третье " + number3 + ", максимальное из них: " + max);
