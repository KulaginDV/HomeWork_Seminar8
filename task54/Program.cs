/*
Задача 54. 
Задать двумерный массив. Написать программу, которая 
упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortArrayToDescending(int[,] sortArray)
{
    for (int i = 0; i < sortArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortArray.GetLength(1); j++)
        {
            for (int k = 0; k < sortArray.GetLength(1) - 1; k++)
            {
                if (sortArray[i, k] < sortArray[i, k + 1])
                {
                    int temp = sortArray[i, k + 1];
                    sortArray[i, k + 1] = sortArray[i, k];
                    sortArray[i, k] = temp;
                }
            }
        }
    }
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
SortArrayToDescending(array);
Console.WriteLine();
PrintArray(array);
