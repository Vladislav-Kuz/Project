Console.Write("Выберите номер задачи:\n"
+ "1 - Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами\n"
+ "2 - Задача 50: Программа, которая на вход принимает позиции элемента в двумерном массиве,\n"
+ "\tи возвращает значение этого элемента или же указание, что такого элемента нет.\n"
+ "3 - Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

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
}

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
}

//*********************************************************/
// 2. Метод генерации матрицы случайных вещественных чисел
double[,] GetRandomMatrix(int row, int column, int powerIndex)
{
    double[,] matrix = new double[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double randomNumber = Math.Round((Math.Pow(10, powerIndex) * new Random().NextDouble()), 3);
            matrix[i, j] = randomNumber;
        }
    }
    return matrix;
}

//*********************************************************/
// 3. Метод печати вещественного массива
void PrintDoubleMatrix(double[,] matrix)
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

}

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
}

//*********************************************************/
// 4. Метод генерации челочисленного массива случайных чисел
int[,] GetIntRndMatrix(int row, int column, int minRandom, int maxRandom)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 02; j < matrix.GetLength(1); j++)
        {
            int randomNumber = new Random().Next(minRandom, maxRandom + 1);
            matrix[i, j] = randomNumber;
        }
    }
    return matrix;
}

//**********************************************************/

//**********************************************************/
//**********************************************************/
// Решения задач
//**********************************************************/
void task1()
{
    Console.WriteLine();
    Console.WriteLine("Задайте двумерный массив размером m×n, заполненный случайными вещественными числами\n");
    Console.WriteLine();

    string inputM = "Введите количество cтрок: ";
    string inputN = "Введите количество cтолбцов: ";
    string inputDigits = "Введите максимальное кол-во разрядов случайных чисел: ";
    int mRows = Math.Abs(ParsingInput(inputM));
    int nColumns = Math.Abs(ParsingInput(inputN));
    int numberOfDigits = Math.Abs(ParsingInput(inputDigits));
    PrintDoubleMatrix(GetRandomMatrix(mRows, nColumns, numberOfDigits));
}

//*********************************************************/
//
//*********************************************************/

void task2()
{
    Console.WriteLine();
    Console.WriteLine("Программа, которая на вход принимает позиции элемента в двумерном массиве,\n" +
    "и возвращает значение этого элемента или же указание, что такого элемента нет.\n");
    Console.WriteLine();
    string inputRows = "Введите количество cтрок: ";
    string inputColumns = "Введите количество cтолбцов: ";
    string inputPointRow = "Задайте номер строки искомого элемента: ";
    string inputPointColumn = "Задайте номер столбца икомого элемента: ";

    Console.WriteLine("\tСоздайте двумерный массив - ");
    int rows = Math.Abs(ParsingInput(inputRows));
    int columns = Math.Abs(ParsingInput(inputColumns));

    Console.WriteLine("\tВведите позицию(индексы) искомого элемента - ");
    int rowIndexInput = Math.Abs(ParsingInput(inputPointRow));
    int columnIndexInput = Math.Abs(ParsingInput(inputPointColumn));
    int minRandom = 10; 
    int maxRandom = 100;

    int[,] matrixToWork = GetIntRndMatrix(rows, columns, minRandom, maxRandom);
    Console.WriteLine($"В созданном двумерном массиве:\n");
    PrintIntMatrix(matrixToWork);
    Console.WriteLine();
    if (rowIndexInput < matrixToWork.GetLength(0) && columnIndexInput < matrixToWork.GetLength(1))
    {
        Console.WriteLine($"\tA[{rowIndexInput},{columnIndexInput}] = {matrixToWork[rowIndexInput, columnIndexInput]}.");
        Console.WriteLine();
    }
    else Console.WriteLine("Элемента с указанной позицией в массиве нет!\n");
}

//*********************************************************/
//
//*********************************************************/

void task3()
{
    Console.WriteLine();
    Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
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

    int[,] matrixToSum = GetIntRndMatrix(rows, columns, minRandom, maxRandom);
    int sumLength = matrixToSum.GetLength(1);
    int[] sumColumn = new int[sumLength];
    double[] meanColumn = new double[sumLength];

    if (matrixToSum.GetLength(0) > 0 && matrixToSum.GetLength(1) > 0)
    {
        Console.WriteLine($"В созданном двумерном массиве:\n");
        PrintIntMatrix(matrixToSum);
        Console.WriteLine();
        CountMean(matrixToSum);
    }
    else
        Console.WriteLine("В массиве нет элементов!");

    //***********************************************************//
    // Метод вычисления среднего арифметического //
    //***********************************************************//
    void CountMean(int[,] matrix)
    {
        for (int i = 0; i < matrixToSum.GetLength(1); i++)
        {
            for (int j = 0; j < matrixToSum.GetLength(0); j++)
            {
                sumColumn[i] += matrixToSum[j, i];
            }
            meanColumn[i] = Math.Round(((Convert.ToDouble(sumColumn[i])) / matrixToSum.GetLength(0)), 3);
        }
        Console.WriteLine($"Среднее арифметическое каждого из столбцов:\n{string.Join("; \n", meanColumn)}.");
    }
    //*************************** end of method ****************************//
}

//*********************************************************/
//
//*********************************************************/
