/*
Задача 60. 
Сформировать трёхмерный массив из неповторяющихся двузначных
чисел. Написать программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void FillArray(int[,,] randomArray)
{
    int count = 10;
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            for (int k = 0; k < randomArray.GetLength(2); k++)
            {
                randomArray[k, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex(int[,,] arrayToShow)
{
    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arrayToShow.GetLength(2); k++)
            {
                Console.Write($"{arrayToShow[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintIndex(array);