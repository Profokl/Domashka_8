// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
#nullable disable

Console.WriteLine("Введите количество строк массива:");
bool isNumberA = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("введите количество столбцов массива:");
bool isNumberB = int.TryParse(Console.ReadLine(), out int n);
if (!isNumberA || !isNumberB || m <= 0 || n <= 0)
{
    Console.WriteLine("Введите целое положительное число");
    return;
}

int[,] array = new int[m, n];
Console.WriteLine();
CreateRandomArray(array);
PrintArray(array);

Console.WriteLine($"Отсортированный массив: ");
SortingArray(array);
PrintArray(array);

void SortingArray(int[,] array)
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

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}