// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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