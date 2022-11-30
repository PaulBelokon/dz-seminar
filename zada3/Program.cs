
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int ostatok = number%2;
if (ostatok==0)
{
    Console.Write("Число четное ");
    Console.WriteLine(number);
}
else
{
    Console.Write("Число нечетное ");
    Console.WriteLine(number);
}