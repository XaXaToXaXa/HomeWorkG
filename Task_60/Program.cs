// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество элементов оси X: ");
int dimensionX = int.Parse(Console.ReadLine());

Console.Write("Введите количество элементов оси Y: ");
int dimensionY = int.Parse(Console.ReadLine());

Console.Write("Введите количество элементов оси Z: ");
int dimensionZ = int.Parse(Console.ReadLine());

// Console.Write("Введите минимальное число массива: ");
// int minValue = int.Parse(Console.ReadLine());

// Console.Write("Введите максимальное число массива: ");
// int maxValue = int.Parse(Console.ReadLine());


int[,,] array3D = new int[dimensionX, dimensionY, dimensionZ];
CreateArray(array3D, 10, 99);  // minValue, maxValue
PrintArray3D(array3D);

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

void CreateArray(int[,,] array3D, int minValue, int maxValue)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(minValue, maxValue);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(minValue, maxValue);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
