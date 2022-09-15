/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); ++i)
    {
        for (int j = 0; j < arr.GetLength(1); ++j)
        {
            Console.Write("  " + arr[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(m, n);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < array.GetLength(1) - 1; z++)
        {
            if (array[i, z] < array[i, z + 1])
            {
                int temp = 0;
                temp = array[i, z];
                array[i, z] = array[i, z + 1];
                array[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(array);
void Array2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}


/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой 
строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
 */
int[,] GetArray(int m, int n) {
    int[,] array = new int[m, n];
    for (int i = 0; i < m ; ++i) {
        for (int j = 0; j < n ; ++j) {
        array[i, j] = new Random().Next(1, 10);   
        }
    }  
    return array;
    }
void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0) ; ++i) 
    {
        for (int j = 0; j < array.GetLength(1) ; ++j)
        {
        Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }
}
Console.Write("Vvedite kolichestvo strok");
int rows = int.Parse(Console.ReadLine());
Console.Write("Vvedite kolichestvo stolbcov");
int colums = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, colums);
PrintArray(array);

int sum = 0;
int isum = 0;
int min = 10000;
int rowsmin = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum <= min)
    {
        min = sum;
        rowsmin = i + 1;

    }
        sum = isum;
}
Console.WriteLine(rows + " строка с наименьшей суммой элементов");
Console.WriteLine("");
    



/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int Array(string array2)
{
    Console.Write(array2);
    return int.Parse(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = Array ("Введите размерность матриц: ");
int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];
FillArray(matrix1);
FillArray(matrix2);
int[,] matrix3 = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Матрица - 1");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица - 2");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц 1*2");
PrintArray(matrix3);

 

/* Задача 60.Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] GetArray(int m, int n, int p) {
    int[,,] array = new int[m, n, p];
    for (int i = 0; i < m ; ++i) {
        for (int j = 0; j < n ; ++j) 
        {
            for (int k = 0; k < p ; ++k)
            {
            array[i, j, k] = new Random().Next(1, 10);
            }   
        }
    }  
    return array;
    }
void PrintArray(int[,,] array2) {
    for (int i = 0; i < array2.GetLength(0) ; ++i) 
    {
        for (int j = 0; j < array2.GetLength(1) ; ++j)
        {
            for (int k = 0; k < array2.GetLength(1) ; ++k)
            {
                Console.Write($"[{i},{j},{k}] {array2[i, j, k]}");
            }
        Console.WriteLine();
        }
    }
}
Console.Write("Vvedite kolichestvo strok array: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Vvedite kolichestvo stolbcov array: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Vvedite kolichestvo height array: ");
int p = int.Parse(Console.ReadLine());
int[,,] array = GetArray(m, n, p);
PrintArray(array);
Console.WriteLine();


/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int rows = 4;
int colums = 4;
int[,] array = new int[rows, colums];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}
WriteArray(array);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}