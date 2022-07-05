// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.



int Prompt(string message){
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArray2(int[] array)
{
    foreach (int element in array)
    {
    System.Console.Write(element + "\t");
    }
}

int SumRowArray(int row, int[,] array)
{
  int sum = 0;
  for (int i = 0; i < array.GetLength(1); i++)
  {
    sum = sum + array[row, i];
  }
return sum;
}

int[] WriteSumInArray(int[,] array)
{
  int[] sumOfRows = new int[array.GetLength(0)];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    sumOfRows[i] = SumRowArray(i, array);
  }
return sumOfRows;
}

int FindMinInArray (int[] array)  
{
int indexMin = 0;
int min = array[0];
for(int i = 0; i < array.Length; i++)
{
  if(array[i] < min) 
  {
  indexMin = i;
  min = array[i];
  }
}
return indexMin;
}

int row = Prompt("Введите количество строк > ");
int column = Prompt("Введите количество столбцов > ");
int min = -10;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
Console.WriteLine("Исходный массив: ");
PrintArray(array);
int[] sumOfRow = WriteSumInArray(array);
Console.WriteLine("массив сумм строк исходного массива: ");
PrintArray2(sumOfRow);
Console.WriteLine();
Console.WriteLine($"строкa массива с наименьшей суммой элементов: {FindMinInArray(sumOfRow)+1}");





