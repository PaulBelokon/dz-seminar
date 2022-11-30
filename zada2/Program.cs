
Console.WriteLine("Введите поочередно любые три числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
if (a>b) 
{
    if (a>c)
    {
    Console.Write("Больше число ");
    Console.WriteLine(a);
    }
    else
    {
       Console.Write("Больше число ");
       Console.WriteLine(c);
    }
}
else if (b>c)
{
    Console.Write("Больше число ");
    Console.WriteLine(b);
}
  else
  {
    Console.Write("Больше число ");
    Console.WriteLine(c);
  }
