// See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Задача 19");
Console.Write("Введите число:  ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - Палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - Не палиндром.");
}
if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");