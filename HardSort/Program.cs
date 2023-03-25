/*
Задача HARD SORT необязательная. Считается за три обязательных
Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры.
Отсортировать элементы по возрастанию слева направо и сверху вниз.

Например, задан массив:
1 4 7 2
5 9 10 3

После сортировки
1 2 3 4
5 7 9 10
*/


Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
Console.WriteLine("");

FillArray(array);
PrintArray(array);
SortArray(array);


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

void SortArray(int[,] array)
    {
    int n = 0;
    int mistake = 1;
    int l = array.GetLength(0) * array.GetLength(1);
    int [] onearray = new int [l];
    int [,] SortArray = new int [rows, cols];

    //Console.WriteLine();
    //Console.WriteLine("Длина одномерного массива: " + l);
    //Console.WriteLine("Одномерный массив: ");
    foreach(int el in array)    // перевод двухмерного массива в одномерный
        {
        //Console.Write($"{el} ");
        onearray [n] = el;
        n++;
        }
    Console.WriteLine();

    while (mistake > 0)   //Упорядочивание элементов массива по возрастанию (hw5 HardStat)
        {
        mistake = 0;
        for (int i = 0; i < array.Length-1; i++)
            {
            if (onearray[i+1] < onearray[i])
                {
                int k = onearray[i+1];
                onearray[i+1] = onearray[i];
                onearray[i] = k;
                mistake++;
                }
            }
        }
    Console.WriteLine();

    /*
    Console.WriteLine("Упорядоченный по возрастанию чисел одномерный массив:");
    for (int i=0;i<onearray.Length;i++)
        Console.Write($"{onearray[i]}  ");
    Console.WriteLine();
    Console.WriteLine();
    */

    n = 0;
    for (int i=0; i<array.GetLength(0);i++)
        for (int j=0; j<array.GetLength(1);j++)
            {
            SortArray[i,j] = onearray[n];
            n++;
            }
    Console.WriteLine("Упорядоченный по возрастанию чисел двумерный массив:");
    PrintArray(SortArray);
    }