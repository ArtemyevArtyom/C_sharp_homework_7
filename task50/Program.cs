/*
Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/
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
    Console.Write("\t");
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

void getPositionOfElement(int[,] positionArray, int usernumber)
{


    for (int i = 0; i < positionArray.GetLength(0); i++)
    {
        for (int j = 0; j < positionArray.GetLength(1); j++)
        {
            if (usernumber == positionArray[i, j])
            {
                Console.WriteLine($"Позиция элемента со значением {usernumber} - [{i}, {j}]");
            }
        }
    }

    Console.WriteLine("Такого элемента нет в массиве");
}
Console.Write("Введите позицию элемента");

int usernumber = Convert.ToInt32(Console.ReadLine());
int[,] generateArray = generate2DArray(3, 3, -5, 5);
print2DArray(generateArray);
System.Console.WriteLine();

getPositionOfElement(generateArray, usernumber);