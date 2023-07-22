Console.Write("Выберите номер задачи:\n"
+ "1 - Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию \n\tэлементы каждой строки двумерного массива.\n"
+ "2 - Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая \n\tбудет находить строку с наименьшей суммой элементов.\n"
+ "3 - Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n"
+ "4 - Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел."
+ "Напишите программу, \n\tкоторая будет построчно выводить массив, добавляя индексы каждого элемента.\n"
+ "5 - Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.\n"
);

Console.WriteLine();
Console.Write("Ваш выбор: ");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case (1):
        task1();
        break;
    case (2):
        task2();
        break;
    case (3):
        task3();
        break;
    case (4):
        task4();
        break;
    case (5):
        task5();
        break;
}



void task1()
{
    // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
    //двумерного массива.
    Console.WriteLine();
    Console.WriteLine("Задайте двумерный массив. \nНапишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива");
    Console.WriteLine();

    string inputRows = "Введите количество cтрок: ";
    string inputColumns = "Введите количество cтолбцов: ";
    string inputMinRandom = "Введите минимальное случайное число: ";
    string inputMaxRandom = "Введите максимальное случайное число: ";

    Console.WriteLine("\tСоздайте двумерный массив - ");
    int rows = ParsingInput(inputRows);
    int columns = ParsingInput(inputColumns);
    Console.WriteLine("\tВведите диапазон RND-генератора - ");
    int minRandom = ParsingInput(inputMinRandom);
    int maxRandom = ParsingInput(inputMaxRandom);

    if (maxRandom < minRandom)
    {
        int temp = maxRandom;
        maxRandom = minRandom;
        minRandom = temp;
    }
    else
    if ((maxRandom == minRandom)) Console.WriteLine("Массив будет заполнен одинаковыми числами!");

    int[,] matrix = GetIntRndMatrix(rows, columns, minRandom, maxRandom);
    int lengthOfRow = matrix.GetLength(1);
    int[] rowsArray = new int[lengthOfRow];
    int[,] matrixOut = new int[matrix.GetLength(0), matrix.GetLength(1)];

    Console.WriteLine("Изначально сгенерированный массив: ");
    PrintIntMatrix(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowsArray[j] = matrix[i, j];
        }
        CreateSortedToLow(rowsArray, matrixOut, i);
    }
    Console.WriteLine("Отсортированный по убыванию значений в строках массив: ");
    PrintIntMatrix(matrixOut);
    Console.WriteLine();

    //*****************************************************************************************
    // Метод, который упорядочивает строки, а затем из них формирует элемент двумерного массива
    //*****************************************************************************************
    void CreateSortedToLow(int[] matr, int[,] matrOut, int count)
    {
        for (int i = 0; i < matr.Length; i++)
        {
            for (int j = 0; j < matr.Length - 1 - i; j++)
            {
                if (matr[j] < matr[j + 1])
                {
                    int temp = matr[j];
                    matr[j] = matr[j + 1];
                    matr[j + 1] = temp;
                }
            }
        }
        for (int k = 0; k < matr.Length; k++)
        {
            matrOut[count, k] = matr[k];
        }
    }//END OF METHOD
}//END OF TASK


void task2()
{
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
    // которая будет находить строку с наименьшей суммой элементов.

    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

    Console.WriteLine();
    Console.WriteLine("Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    Console.WriteLine();

    string inputRows = "Введите количество cтрок: ";
    string inputColumns = "Введите количество cтолбцов: ";
    string inputMinRandom = "Введите минимальное случайное число: ";
    string inputMaxRandom = "Введите максимальное случайное число: ";

    Console.WriteLine("\tСоздайте двумерный массив - ");
    int rows = ParsingInput(inputRows);
    int columns = ParsingInput(inputColumns);
    Console.WriteLine("\tВведите диапазон RND-генератора - ");
    int minRandom = ParsingInput(inputMinRandom);
    int maxRandom = ParsingInput(inputMaxRandom);
    if (maxRandom < minRandom)
    {
        int temp = maxRandom;
        maxRandom = minRandom;
        minRandom = temp;
    }
    else
    if ((maxRandom == minRandom)) Console.WriteLine("Массив будет заполнен одинаковыми числами!");
    if (columns <= 0 || rows <= 0)
    {
        Console.WriteLine("Размер массива не может быть нулем!");
        return;
    }
    int[,] matrix = GetIntRndMatrix(rows, columns, minRandom, maxRandom);
    int[] summary = new int[matrix.GetLength(0)];
    Console.WriteLine("Изначально сгенерированный массив: ");
    PrintIntMatrix(matrix);
    summary = ResultSum(matrix);
    int flagToReturn = 0;
    int minSum = CalcMinSumOfRows(summary, flagToReturn);
    flagToReturn = 1;
    int minSumIndex = CalcMinSumOfRows(summary, flagToReturn);
    Console.WriteLine($"Суммы строк: \n{string.Join("; ", summary)}");
    Console.WriteLine($"Минимальная сумма элементов получена в строке {minSumIndex + 1} и равна {minSum}");
    Console.WriteLine();


    //*****************************************************************************************
    // Метод получения значения суммы в строках
    //*****************************************************************************************
    int[] ResultSum(int[,] mas)
    {    // получение набора сумм строк
        int[] sumMas = new int[mas.GetLength(0)];
        int[] sumRows = new int[mas.GetLength(1)];
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            sumRows[0] = mas[i, 0];
            for (int j = 1; j < mas.GetLength(1); j++)
                sumRows[j] = mas[i, j] + sumRows[j - 1];
            sumMas[i] = sumRows[mas.GetLength(1) - 1];
        }
        return sumMas;
    }//END OF METHOD


    //*****************************************************************************************
    // Метод получения значения минимальной суммы и номера, содержащей эту сумму, строки
    //*****************************************************************************************
    int CalcMinSumOfRows(int[] rowSummary, int flag)
    {
        int min = rowSummary[0];
        int index = 0;
        for (int k = 1; k < rowSummary.Length; k++)
        {
            if (rowSummary[k] < min)
            {
                min = rowSummary[k];
                index = k;
            }
        }
        if (flag == 0) return min;
        else return index;
    }//END OF METHOD
}//END OF TASK
//*****************************************************************************************


void task3()
{
    // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18                                                                                      
    //A[0,0] = 1[0,0]*2[0,0]+ 1[0,1]*2[1,0]   A[0,1] = 1[0,0]*2[1,0]+ 1[0,1]*2[1,1]                                                      
    //A[1,0] = 1[1,0]*2[0,0]+ 1[1,1]*2[1,0]   A[0,0] = 1[0,0]*2[1,0]+ 1[0,1]*2[1,1]                                

    Console.WriteLine();
    Console.WriteLine("Программа, которая будет находить произведение двух матриц.");
    Console.WriteLine();

    string inputRows = "Введите количество cтрок: ";
    string inputColumns = "Введите количество cтолбцов: ";
    string inputMinRandom = "Введите минимальное случайное число: ";
    string inputMaxRandom = "Введите максимальное случайное число: ";

    Console.WriteLine("\tСоздайте 1-ый двумерный массив - ");
    int firstMatrixRows = ParsingInput(inputRows);
    int firstMatrixCols = ParsingInput(inputColumns);
    Console.WriteLine();
    Console.WriteLine("Чтобы матрицы могли перемножаться, \nразмер столбца первой матрицы должен быть равен размеру строки второй матрицы!\n");
    Console.WriteLine("\tСоздайте 2-й двумерный массив - ");
    int secMatrixRows = firstMatrixCols;            // в длину строки подставляется длина столбца 1-й матрицы
    Console.WriteLine($"Количество строк: {secMatrixRows}");
    //int secMatrixRows = ParsingInput(inputRows);  // если вдруг нужно вводить длину строки руками 
    int secMatrixCols = ParsingInput(inputColumns);
    //if (firstMatrixCols != secMatrixRows)         // проверка на перемножаемость, 
    //{                                             // если ручной ввод размера строки второй матрицы
    //    Console.WriteLine("Такие матрицы не перемножаются");
    //    return;
    //}
    Console.WriteLine("\tВведите диапазон RND-генератора - ");
    int minRandom = ParsingInput(inputMinRandom);
    int maxRandom = ParsingInput(inputMaxRandom);
    if (maxRandom < minRandom)
    {
        int temp = maxRandom;
        maxRandom = minRandom;
        minRandom = temp;
    }
    else
    if ((maxRandom == minRandom)) Console.WriteLine("Массив будет заполнен одинаковыми числами!");
    if (firstMatrixCols <= 0 || firstMatrixRows <= 0 || secMatrixCols <= 0 || secMatrixRows <= 0)
    {
        Console.WriteLine("Неправильный ввод!");
        return;
    }
    int[,] firstMatrix = GetIntRndMatrix(firstMatrixRows, firstMatrixCols, minRandom, maxRandom);
    int[,] secMatrix = GetIntRndMatrix(secMatrixRows, secMatrixCols, minRandom, maxRandom);
    Console.WriteLine();
    Console.WriteLine("Матрица-множитель №1: ");
    PrintIntMatrix(firstMatrix);
    Console.WriteLine();
    Console.WriteLine("Матрица-множитель №2:");
    PrintIntMatrix(secMatrix);
    int[,] resMatrix = MultiplyMatrix(firstMatrix, secMatrix);
    Console.WriteLine();
    Console.WriteLine("Результат перемножения: ");
    PrintIntMatrix(resMatrix);

    //*****************************************************************************************
    // Метод перемножения матриц
    //*****************************************************************************************
    int[,] MultiplyMatrix(int[,] firstMatr, int[,] secMatr)
    {
        int[,] resultMatr = new int[((byte)firstMatr.GetLength(0)), secMatr.GetLength(1)];
        for (int i = 0; i < firstMatr.GetLength(0); i++)
        {
            for (int j = 0; j < secMatr.GetLength(1); j++)
            {
                for (int k = 0; k < firstMatr.GetLength(1); k++)
                    resultMatr[i, j] += firstMatr[i, k] * secMatr[k, j];
            }
        }
        return resultMatr;
    }//END OF METHOD

}//END OF TASK
//*****************************************************************************************

void task4()
{
    // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    // Массив размером 2 x 2 x 2
    // 66(0,0,0) 25(0,1,0)
    // 34(1,0,0) 41(1,1,0)
    // 27(0,0,1) 90(0,1,1)
    // 26(1,0,1) 55(1,1,1)

    Console.WriteLine();
    Console.WriteLine("программа, которая построчно выводит массив, добавляя индексы каждого элемента.");
    Console.WriteLine();

    string lengthX = "Введите размер по X: ";
    string lengthY = "Введите размер по Y: ";
    string lengthZ = "Введите размер по Z: ";
    int minRandom = 10;
    int maxRandom = 100;
    Console.WriteLine("\tСоздайте 1-ый двумерный массив - ");
    int xLength = ParsingInput(lengthX);
    int yLength = ParsingInput(lengthY);
    int zLength = ParsingInput(lengthZ);
    if (xLength <= 0 || yLength <= 0 || zLength <= 0)
    {
        Console.WriteLine("Неправильный формат данных!");
        return;
    }
    Console.WriteLine();
    Console.WriteLine("Элементы трехмерного массива: ");
    int[,,] result = GetRnd3DMatrix(xLength, yLength, zLength, minRandom, maxRandom);
    Print3DMatrix(result);

    //*****************************************************************************************
    // Метод получения матрицы
    //*****************************************************************************************
    int[,,] GetRnd3DMatrix(int x, int y, int z, int min, int max)
    {
        int[,,] matrix3D = new int[x, y, z];
        for (int i = 0; i < matrix3D.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3D.GetLength(1); j++)
            {
                for (int k = 0; k < matrix3D.GetLength(2); k++)
                {
                    int randomNumber = new Random().Next(min, max);
                    matrix3D[i, j, k] = randomNumber;
                }
            }
        }
        return matrix3D;
    }//END OF METHOD

    //*****************************************************************************************
    // Метод печати матрицы
    //*****************************************************************************************
    void Print3DMatrix(int[,,] matrix)
    {
        if (matrix.GetLength(0) != 0 && matrix.GetLength(1) != 0 && matrix.GetLength(2) != 0)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                        Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
                    Console.WriteLine();
                }
            }
        }
        else Console.WriteLine("Задан пустой массив!");
    }//END OF METHOD
}//END OF TASK


void task5()
{
    // Доп:
    // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    // Например, на выходе получается вот такой массив:
    // 01 02 03 04
    // 12 13 14 05
    // 11 16 15 06
    // 10 09 08 07

    Console.WriteLine();
    Console.WriteLine("Напишите программу, которая заполнит массив спирально, элементы - последовательный счетчик от 0.");
    Console.WriteLine();

    string inputRows = "Введите количество cтрок: ";
    string inputColumns = "Введите количество cтолбцов: ";
    Console.WriteLine("\tСоздайте двумерный массив - ");
    int rows = ParsingInput(inputRows);
    int columns = ParsingInput(inputColumns);
    PrintIntMatrix(FillMatrixBySpiral(rows, columns));


    //*****************************************************************************************
    // Метод заполнения матрицы по спирали
    //*****************************************************************************************
    int[,] FillMatrixBySpiral(int m, int n)
    {
        int[,] array = new int[m, n];
        int countElems = 0; // счетчик количества элементов, внесенных в массив
        int countRows = 0; // счетчик циклов для заполнения строк
        int countCols = 0; // счетчик циклов для заполнения столбцов
        while (countElems < (m * n) - 1)
        {
            for (int j = countCols; j < n - 1 - countCols; j++)
            {
                if (countElems < (m * n))
                {
                    int i = countRows;
                    array[i, j] = countElems;
                    countElems++;
                }
            }
            for (int i = countRows; i < m - 1 - countRows; i++)
            {
                if (countElems < (m * n))
                {
                    int j = n - 1 - countCols;
                    array[i, j] = countElems;
                    countElems++;
                }
            }
            for (int j = n - 1 - countCols; j > countCols; j--)
            {
                if (countElems < (m * n))
                {
                    int i = m - 1 - countRows;
                    array[i, j] = countElems;
                    countElems++;
                }
            }
            for (int i = m - 1 - countRows; i > countRows; i--) //+1-countRows
            {
                if (countElems < (m * n))
                {
                    int j = countCols;
                    array[i, j] = countElems;
                    countElems++;
                }
            }
            countRows++;
            countCols++;
        }
        if (m == n && m % 2 != 0)
        {
            array[m / 2, n / 2] = countElems;
            countElems++;
        }
        return array;
    }//END OF METHOD
}//END OF TASK


//*****************************************//
// Функции для совместного использования   //
//*****************************************//
// 1. Метод считывния с консоли численных данных
int ParsingInput(string number)
{
    bool isNumber = false;
    int result = 0;
    while (isNumber == false)
    {
        Console.Write(number);
        string input = Console.ReadLine()!;
        isNumber = int.TryParse(input, out int intRes);
        if (isNumber) result = intRes;
        else
        {
            isNumber = false;
            Console.WriteLine("Ошибка, повторите ввод");
        }
    }
    return result;
}//END OF METHOD

//*********************************************************/
// Метод печати целочисленного массива
void PrintIntMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) != 0 && matrix.GetLength(1) != 0)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Задан пустой массив!");
}//END OF METHOD

//*********************************************************/
// 4. Метод генерации челочисленного массива случайных чисел
int[,] GetIntRndMatrix(int row, int column, int minRandom, int maxRandom)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int randomNumber = new Random().Next(minRandom, maxRandom + 1);
            matrix[i, j] = randomNumber;
        }
    }
    return matrix;
}//END OF METHOD