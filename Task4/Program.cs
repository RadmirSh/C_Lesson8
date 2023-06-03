// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int length = 4;
int[,] table = new int[length, length];

void writeArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int count = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = count++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = count++;
        for (k = 0; k < n - 1; k++) array[i, j--] = count++;
        for (k = 0; k < n - 1; k++) array[i--, j] = count++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

writeArraySpiral(table, length);  //  Заполняется массив по спирали начиная с 1
printArray(table);