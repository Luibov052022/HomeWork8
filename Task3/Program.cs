// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
int[,] MultiplyArray(int[,] array1, int[,] array2)
{
int row = array1.GetLength(0);
int column = array1.GetLength(1);
var answerArray = new int[row, column];
for(int j = 0; j < row; j++)
{ 
	for(int i = 0; i < column; i++)
	{
		answerArray[j,i] += array1[j,i] * array2[i,j];
	}
}
return answerArray;
}


int rowCol = Prompt("Введите количество строк первой матрицы и столбцов второй> ");
int column = Prompt("Введите количество столбцов первой матрицы> ");
int row = Prompt("Введите количество строк второй матрицы > ");
int min = -10;
int max = 10;
int[,] array1 = GenerateArray(rowCol, column, min, max);
Console.WriteLine("Первая матрица: ");
PrintArray(array1);

int[,] array2 = GenerateArray(row, rowCol, min, max);
Console.WriteLine("Вторая матрица: ");
PrintArray(array2);

int[,] answerArray = MultiplyArray(array1, array2);
Console.WriteLine("произведение двух матриц равно: ");
PrintArray(answerArray);




