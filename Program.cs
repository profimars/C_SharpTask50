// Задача 50. Напишите программу, которая на вход принимает значение 
// элемента в двумерном массиве, и возвращает позицию этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
//https://github.com/profimars/C_SharpTask50

void CreateArray(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            A[i, j] = rnd.Next(1, 100);
        }
}

void PrintArray(int[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{A[i, j],3}   ");
        Console.WriteLine();
    }
}

void NumberSearch(int[,] A, int k)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    bool find = false;
    int ii = 0;
    int jj = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            if (A[i, j] == k)
            {
                ii = i;
                jj = j;
                find = true;
            }
    }
    if (find == true)
        Console.WriteLine($"Координаты найденного числа i = {ii}; j = {jj}");
    else
        Console.WriteLine("Такого числа в массиве нет");
}

Console.WriteLine("Задайте натуральное число k");
int k = Convert.ToInt32(Console.ReadLine());
int m = 5;
int n = 5;
int[,] A = new int[m, n];
CreateArray(A);
PrintArray(A);
NumberSearch(A, k);
