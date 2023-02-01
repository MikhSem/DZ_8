// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 9);
Console.WriteLine ("Массив до сортировки");
PrintArray(array);
Console.WriteLine ();
Console.WriteLine ("Массив после сортировки");
SortArray (array);
PrintArray(array);
*/


// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
/*
int[,] array = GetArray(4, 4, 0, 9);
PrintArray(array);
Console.WriteLine();
NumberRowMinSumElements(array);
*/


// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите количество строк в первой матрице: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первой матрице: ");
int columns1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ();

Console.Write("Введите количество строк во второй матрице: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во второй матрице: ");
int columns2 = int.Parse(Console.ReadLine()!);
Console.WriteLine ();


int[,] firstArray = GetArray(rows1, columns1, 1, 9);
Console.WriteLine ("Первая матрица");
PrintArray(firstArray);
Console.WriteLine ();

int[,] secondArray = GetArray(rows2, columns2, 1, 9);
Console.WriteLine ("Вторая матрица");
PrintArray(secondArray);

if (firstArray.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Перемножить матрицы невозможно ");
    return;
}

int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];

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

Console.WriteLine ();
Console.WriteLine ("Результат перемножения матриц:");
PrintArray(resultArray);


/*

// ------------------- Вывод номера строки с наименьшей суммой задача 2 -------------------
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Минимальная сумма элементов в строке № {minSumRow + 1}");
}

*/


/*
// ------------------- Сортировка массива задача 1 -------------------
void SortArray(int[,] array)
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
*/
// ------------------- Методы наполнения/печати -------------------
int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
        
    }

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}