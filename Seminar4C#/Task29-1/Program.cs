

// See https://aka.ms/new-console-template for more information
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Задача 29");
Console.Write("Введите ряд чисел, разделенных запятой: ");
string? sequensNum = Console.ReadLine();

sequensNum = sequensNum + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces (string series){
  string lineNew1 = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      lineNew1 += series[i];
    }
  }
  return lineNew1;
}

// функция  создания и заполнения массива из строки
int[] ArrayNum(string lineNew1)
{ 
    
  int[] ArrayNum = new int[8];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < lineNew1.Length; i++)
  {
    string lineNew1 = "";

    while (lineNew1[i] != ',' && i < lineNew1.Length)
    {
      lineNew1 += lineNew1[i];
      i++;
    }
    ArrayNum[j] = Convert.ToInt32(lineNew1);    // заполняем массив из строки lineNew1
    if (i < lineNew1.Length-1)
    {
      ArrayNum = ArrayNum.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return ArrayNum;
}

// функция  вывода массива на печать 
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string lineNew1 = RemovingSpaces(sequensNum);

int[] ArrayNum =  ArrayNum(lineNew1);

PrintArry(ArrayNum);

//Console.WriteLine($"[{String.Join("; ", array)}]");




