// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Please write raw size (m) of array: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Please write column size (n) of array: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] randomOfArray = new int[m,n];

void editArray(int m, int n)
{
    int i,j;
    Random randomNew = new Random();
        for (i = 0; i < m; i++)
        {
            for (j = 0; j < n; j++)
            {
            randomOfArray[i,j] = randomNew.Next(1,9);
            }
        }
}

void printArray(int[,] array)
{
    int i,j;
        for (i = 0; i < array.GetLength(0); i++)
        {
        Console.WriteLine();
            for (j = 0; j < array.GetLength(1); j++)
            {
            Console.Write($"{array[i,j]} ");
            }
        Console.WriteLine();
        }
}

editArray(m,n);
Console.WriteLine("\n Original array: ");
printArray(randomOfArray);

// Функция, считающая сумму элементов в строке
int sumRaw(int[,] array, int i)
{
    int sum = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        return sum;
}

int minSum = 1;
int sum = sumRaw(randomOfArray, 0);
    for (int i = 1; i < randomOfArray.GetLength(0); i++)
    {
        if (sum > sumRaw(randomOfArray, i))
        {
            sum = sumRaw(randomOfArray, i);
            minSum = i+1;
        }
    }
Console.WriteLine($"\n The row with the smallest sum of elements: {minSum}");