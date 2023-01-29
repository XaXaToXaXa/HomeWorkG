// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18.

Console.Write("Введите количество строк и столбцов в матрице: ");
int size = int.Parse(Console.ReadLine());

// Console.Write("Введите минимальное число массива: ");
// int minValue = int.Parse(Console.ReadLine());

// Console.Write("Введите максимальное число массива: ");
// int maxValue = int.Parse(Console.ReadLine());

int[,] firstArray = GetArray(size, size, 0, 10); // minValue, maxValue
int[,] secondArray = GetArray(size, size, 0, 10); // minValue, maxValue
int[,] resultArray = new int[size, size];

Console.WriteLine("Первая матрица:");
PrintArray(firstArray);
Console.WriteLine();

Console.WriteLine("Вторая матрица:");
PrintArray(secondArray);
Console.WriteLine();

MultiplyMatrix(firstArray, secondArray, resultArray);

Console.WriteLine("Результат произведения двух матриц:");
PrintArray(resultArray);
Console.WriteLine();

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
void MultiplyMatrix(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < resultArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secondArray[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}