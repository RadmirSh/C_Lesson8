Console.WriteLine("Please write the number of the task: 1-4");

int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 1:
        task1();
        break;

    case 2:
        task2();
        break;

    case 3:
        task3();
        break;

    case 4:
        task4();
        break;

    default:
        break;
}

void task1()
{
int[,] arrayTable = new int[3, 5];
writeArrayRandom(arrayTable);    // Заполняю массив случайными значениями 
printArray(arrayTable);
sortDesc(arrayTable);   // Сортирую массив по убыванию
Console.WriteLine();
printArray(arrayTable);

void writeArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 29);
        }
    }
}

void sortDesc(int[,] array)   
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void printArray(int[,] array)  
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
}

void task2()
{
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
}

void task3()
{
Console.WriteLine("Please write matrix sizes and range of random values)");
int m = InputNumbers("Please write raw size of first matrix: ");
int n = InputNumbers("Please write column size of first matrix: ");
int k = InputNumbers("Please write column size of second matrix: ");
int range = InputNumbers("Please write range of random values: between 1 and 99 ⇒");

int[,] firstMartrix = new int[m, n];
makeArray(firstMartrix);
Console.WriteLine($"First matrix:");
printArray(firstMartrix);

int[,] secomdMartrix = new int[n, k];
makeArray(secomdMartrix);
Console.WriteLine($"Second matrix:");
printArray(secomdMartrix);

int[,] resultMatrix = new int[m,k];

multiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Multiplication of first and second matrixes:");
printArray(resultMatrix);

void multiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void makeArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void printArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
}

void task4()
{
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
}