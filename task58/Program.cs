/*
Задача 58. 
Задать две матрицы. Написать программу, которая будет
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int ConvertStringToInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

int str = ConvertStringToInt("Input the number of strings: ");
int columns = ConvertStringToInt("Input the number of columns: ");
int[,] firstArray = new int[str, columns];
int[,] secondArray = new int[str, columns];
int[,] resultArray = new int[str, columns];

FillArray(firstArray);
PrintArray(firstArray);

Console.WriteLine();

FillArray(secondArray);
PrintArray(secondArray);

Console.WriteLine();

if (firstArray.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Сannot be multiplied ");
}

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

PrintArray(resultArray);