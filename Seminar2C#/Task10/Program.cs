// See https://aka.ms/new-console-template for more information
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);


