// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}


void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


double ArithmeticalMean(int[,] Array)
{
    double count = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            count += + Array[i, j];
        }
        count = count / Convert.ToDouble(Array.GetLength(0));
        Console.Write($"{count}; ");
        count = 0;
    }
    return count;
}

int[,] generatedArray = generate2DArray(4, 6, 1, 30);
print2DArray(generatedArray);
Console.WriteLine();
double average = ArithmeticalMean(generatedArray);

