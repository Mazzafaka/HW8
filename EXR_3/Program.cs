// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


        int rows = GetNum("Введите кол-во строк: ");
        int columns = GetNum("Введите кол-во столбцов: ");
        int[,] array = GetArray(rows, columns);
        PrintArray(array);

        double[] columnAverages = CalculateColumnAverages(array);

        Console.WriteLine("Средние арифметические по столбцам:");
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine($"Столбец {j + 1}: {columnAverages[j]}");
        }
    

    static int GetNum(string message)
    {
        Console.Write(message);
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int[,] GetArray(int rows, int columns)
    {
        int[,] res = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int randomValue = random.Next(1, 100);
                res[i, j] = randomValue;
            }
        }
        return res;
    }

    static void PrintArray(int[,] arr)
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

    static double[] CalculateColumnAverages(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        double[] columnAverages = new double[columns];

        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = (double)sum / rows;
        }

        return columnAverages;
    }

