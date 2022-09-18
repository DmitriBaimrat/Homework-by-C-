Console.Clear();
System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

int num = 1;

while (num <= N)
{
  if (num % 2 == 0)
  {
    System.Console.Write(num + ", ");
  }  
  num++;
}
