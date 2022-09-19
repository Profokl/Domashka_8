// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

#nullable disable
Console.WriteLine($"Введите размеры матриц:");
Console.WriteLine($"Введите число строк 1-й матрицы:");
bool isNumberA = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine($"Введите число столбцов 1-й матрицы и строк 2-й:");
bool isNumberB = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine($"Введите число столбцов 2-й матрицы:");
bool isNumberC = int.TryParse(Console.ReadLine(), out int p);
if (!isNumberA || !isNumberB || !isNumberC || m <= 0 || n <= 0 || p<= 0)
{
    Console.WriteLine("Введите целое положительное число");
    return;
}


int[,] firstMartrix = new int[m, n];
CreateRandomArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
CreateRandomArray(secondMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


void CreateRandomArray(int[,]array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100);
        }
    }
}

void PrintArray (int[,] array)
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