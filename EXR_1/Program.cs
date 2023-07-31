// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int rows = GetNum("Введите кол-во строк: ");
int columns = GetNum("Введите кол-во столбцов: ");
double[,] array = GetArray(rows, columns);
PrintArray(array);

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] GetArray(int rows, int columns)
    {
        double[,] res = new double[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                double randomValue = random.NextDouble() * 100; 
                res[i, j] = randomValue;
                
            }
        }
        return res;
    }


void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double roundedValue = Math.Round(arr[i, j], 1);
            Console.Write($"{roundedValue} ");
        }
        Console.WriteLine();
    }
}