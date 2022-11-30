Console.WriteLine("Введите поочередно любые два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a>b) 
{
    Console.Write("Больше число ");
    Console.WriteLine(a);
}
else
{
    Console.Write("Больше число ");
    Console.WriteLine(b);
}