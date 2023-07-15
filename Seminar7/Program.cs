// // Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// // m = 3, n = 4.
// // 1 4 8 19
// // 5 -2 33 -2
// // 77 3 8 1

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество cтолбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int minRandom = 0;
// int maxRandom = 10; 
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);
// // Создается таблица из rows строчек и columns столбцов; minRandom - 0, maxRandom = 10
// PrintMatrix(array2D);

// // Матрица - прямоугольная таблица размером m(строчки) на n(cтолбцов)
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; // [кол-во_строк, кол-во_столбцов]
//     for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
//     {
//         // i, k, m, n, j
//         for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
//     {
//         // i, k, m, n, j
//         for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
//         {
//             Console.Write(matrix[i, j] + "\t"); // Tab между элементами матрицы
//         }
//         Console.WriteLine();
//     }
// }




// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; // [кол-во_строк, кол-во_столбцов]
//     for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
//     {
//         // i, k, m, n, j
//         for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
//     {
//         // i, k, m, n, j
//         for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
//         {
//             Console.Write(matrix[i, j] + "\t"); // Tab между элементами матрицы
//         }
//         Console.WriteLine();
//     }
// }



// Задача 49: Задайте двумерный массив. Найдите элементы,
//  у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

 Console.Write("Введите количество строк: ");
 int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int minRandom = 0;
int maxRandom = 10; 
int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);
// Создается таблица из rows строчек и columns столбцов; minRandom - 0, maxRandom = 10
PrintMatrix(array2D);

// Матрица - прямоугольная таблица размером m(строчки) на n(cтолбцов)
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; // [кол-во_строк, кол-во_столбцов]
    for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
    {
        // i, k, m, n, j
        for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
    {
        // i, k, m, n, j
        for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
        {
            Console.Write(matrix[i, j] + "\t"); // Tab между элементами матрицы
        }
        Console.WriteLine();
    }
}

int[,] ChangeMatrix(int[,]matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++) // m, цикл по строчкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// n, цикл по столбцам
        {
            if(i%2==0 && j%2==0)
            {
                matrix[i,j]*=matrix[i,j];
            }
        }
        Console.WriteLine();
    }
}

PrintMatrix(ChangeMatrix(array2D));