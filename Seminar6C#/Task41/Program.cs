﻿// See https://aka.ms/new-console-template for more information
//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int[] AddArrayM (int M) 
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < M; i++)
    {
        if (i == M - 1) Console.Write($"{array[i]} -> ");
        else Console.Write($"{array[i]}, "); 
    }
    return array;
}

int NotNullNumsCounter(int[] array) 
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            counter++;
        }
    }
    Console.Write(counter);
    return counter;
}

NotNullNumsCounter(AddArrayM(5));