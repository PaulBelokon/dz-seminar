﻿
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());


for (int i = 1; i <= number; i++)
{
    int ostatok = i%2;
   if (ostatok==0)
{
    Console.Write("Число четное ");
    Console.WriteLine(i);
}

}