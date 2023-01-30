// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18.

Console.Write("Введите количество строк и столбцов в матрице: ");
int firstRow = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк и столбцов в матрице: ");
int firstColumn = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк и столбцов в матрице: ");
int secondRow = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк и столбцов в матрице: ");
int secondColumn = int.Parse(Console.ReadLine());


// Console.Write("Введите минимальное число массива: ");
// int minValue = int.Parse(Console.ReadLine());

// Console.Write("Введите максимальное число массива: ");
// int maxValue = int.Parse(Console.ReadLine());

int[,] firstArray = GetArray(firstRow, firstColumn, 0, 10); // minValue, maxValue
int[,] secondArray = GetArray(secondRow, secondColumn, 0, 10); // minValue, maxValue

Console.WriteLine("Первая матрица:");
PrintArray(firstArray);
Console.WriteLine();

Console.WriteLine("Вторая матрица:");
PrintArray(secondArray);
Console.WriteLine();

if (firstRow == secondColumn)
{
    Console.WriteLine("Результат произведения двух матриц:");
    PrintArray(MultiplyMatrix(firstArray, secondArray));
    Console.WriteLine();
}
else Console.WriteLine("Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором.");



void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
int [,] MultiplyMatrix(int[,] arrayA, int[,] arrayB)
    {
      int[,] resultMatrix = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
      for (int i = 0; i < arrayA.GetLength(0); i++)
      {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
          for (int k = 0; k < arrayA.GetLength(1); k++)
          {
            resultMatrix[i, j] += arrayA[i, k] * arrayB[k, j];
          }
        }
      }
      return resultMatrix;
    }