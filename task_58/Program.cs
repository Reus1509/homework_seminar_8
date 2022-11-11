// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// (посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void Main()
{
    Console.Clear();
int rows = ReadInt("Введите количество строк первой матрицы: ");
int columns = ReadInt("Введите количество столбцов первой матрицы: ");
int[,] firstArray = new int[rows, columns];
FillArray(firstArray);
PrintArray(firstArray);

Console.WriteLine();

int rows2 = ReadInt("Введите количество строк второй матрицы: ");
int columns2 = ReadInt("Введите количество столбцов второй матрицы: ");
int[,] secondArray = new int[rows2, columns2];
FillArray(secondArray);
PrintArray(secondArray);

if (columns != rows2)
{
    Console.WriteLine();
    Console.WriteLine("Перемножить эти матрицы нельзя.");
}
else
{
    int[,] resultArray = new int[rows, columns2];
    resultArray = MultArray(firstArray, secondArray, resultArray);

    Console.WriteLine();
    Console.WriteLine("Результат перемножения: ");
    PrintArray(resultArray);
}
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return resultArray;
}

Main();