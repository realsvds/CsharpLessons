// See https://aka.ms/new-console-template for more information
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Задача 29");
Console.Write("Введите ряд из восьми чисел, разделенных запятой: ");
string? seqOfNums = Console.ReadLine();

seqOfNums = seqOfNums + ",";    // Последовательность цифр sequence of number.


string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

int[] ArrayOfNum(string seriesNew)
{ 

  int[] arrayOfNum = new int[1];    // инициализация массива из 1 элементов

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
            
      i++;
    }
    arrayOfNum[j] = Convert.ToInt32(seriesNew1);    // заполняем массив из строки
    if (i < seriesNew.Length-1){
      arrayOfNum = arrayOfNum.Concat(new int[] {0}).ToArray();    
    }
    j++;
  }
  return arrayOfNum;
}

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


string seriesNew = RemovingSpaces(seqOfNums);
int[] arrayOfNum =  ArrayOfNum(seriesNew);
PrintArry(arrayOfNum);

