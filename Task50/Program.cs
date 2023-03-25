/*
Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
и возвращает позицию этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
Console.WriteLine("");

FillArray(array);
PrintArray(array);
FindNum(array);



void FillArray(int[,] array)
    {
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-10,10);
    }

void PrintArray(int[,] array)
    {
    for (int i=0; i<array.GetLength(0);i++)
        {
        for (int j=0; j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
        }
    }

void FindNum(int[,] array)
    {
    int k = 0;
    Console.WriteLine();
    Console.WriteLine("Введите искомое число:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Позиции искомого числа:");
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            {
            if (array[i,j] == num)
                {
                Console.WriteLine($"[{i},{j}]");
                k++;
                }
            }
    if (k==0)
    Console.WriteLine("Такого числа в массиве нет");
    }