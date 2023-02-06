/* 
Specify a two-dimensional array. Write a program that will sort the elements
 of each row of a two-dimensional array in descending order.
 */

/*
int[,] CreateRandom2dArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

void ArangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

ArangeArray(newArray);
Show2dArray(newArray);
*/

/*Specify a rectangular two-dimensional array. 
Write a program that will find the string with the smallest sum of elements.
*/

int[,] CreateRandom2dArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns more then number of rows: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
                   
            array[i,j] = new Random().Next(minValue, maxValue);
        }
        
    }
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
void FindMinSumOfElements(int[,] array)
{
    int minRows = 0;
    int minrowSum = 0;
    int rowSum = 0;
    for (int i = 0; i < newArray.GetLength(1); i++)
    {
        minRows += newArray[0, i];
    }
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++) rowSum += newArray[i, j];
        if (rowSum < minRows)
        {
            minRows = rowSum;
            minrowSum = i;
        }
        rowSum = 0;
    }
    Console.WriteLine($"The minimum sum of elements is in the row: {minrowSum + 1}");
}
Console.WriteLine(0);
Show2dArray(newArray);
FindMinSumOfElements(newArray);



// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int rows = ReadInt("Enter the number of strings: ");
int columns = ReadInt("Enter the number of columns: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];
CrateRandomArray(array);
ShowArray(array);
Console.WriteLine();
CrateRandomArray(secondArray);
ShowArray(secondArray);
Console.WriteLine();
void CrateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
if (array.GetLength(0) != secondArray.GetLength(1))
    {
    Console.WriteLine("Input error: The number of columns in the first matrix should be equal to the number of rows in the second matrix.");
    return;
    }
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}
ShowArray(resultArray);
*/

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] array = new int[2, 2, 2];
void ShowIndex(int[,,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
void CrateArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}
CrateArray(array);
ShowIndex(array);
*/
// Напишите программу, которая заполнит спирально массив 4 на 4.

/*

int[,] array = new int[4, 4];

void CrateSpiralArray(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

CrateSpiralArray(array, 4);
ShowArray(array);
*/
