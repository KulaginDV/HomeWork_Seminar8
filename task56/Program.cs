/*
Задача 56. 
Задать прямоугольный двумерный массив. Написать программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void FillArray(int[,] randomArray)
{
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arrayToShow)
{
    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
        {
            Console.Write($"{arrayToShow[i, j]} ");
        }
        Console.WriteLine();
    }
}

void StringWithMinSum(int[,] arrayForSum)
{
    int minString = 0;
    int minSumString = 0;
    int sumString = 0;
    for (int i = 0; i < arrayForSum.GetLength(1); i++)
    {
        minString += arrayForSum[0, i];
    }
    for (int i = 0; i < arrayForSum.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForSum.GetLength(1); j++) sumString += arrayForSum[i, j];
        if (sumString < minString)
        {
            minString = sumString;
            minSumString = i;
        }
        sumString = 0;
    }
    Console.Write($"{minSumString + 1} string");
}

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
StringWithMinSum(array);