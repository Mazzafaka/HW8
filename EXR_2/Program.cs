// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = GetNum("Введите кол-во строк: ");
int columns = GetNum("Введите кол-во столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);

int rowPosition = GetNum("Введите номер строки элемента: ");
int columnPosition = GetNum("Введите номер столбца элемента: ");

int elementValue = GetElementValue(array, rowPosition, columnPosition);
if (elementValue == int.MinValue)
{
    Console.WriteLine("Такого элемента не существует.");
}
else
{
    Console.WriteLine($"Значение элемента: {elementValue}");
}


int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetArray(int rows, int columns)
{
    int[,] res = new int[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int randomValue = random.Next(1, 100); // Заменена ошибка NextI() на Next(1, 100)
            res[i, j] = randomValue;
        }
    }
    return res;
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

int GetElementValue(int[,] array, int row, int column)
{
    if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
    {
        return array[row, column];
    }
    else
    {
        return int.MinValue;
    }
}