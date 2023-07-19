// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void ChangeRows(int[,] matr)
{
    int lastRowIndex = matr.GetLength(0) - 1; // Номер последней строчки
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int temp = matr[0, i]; // temp = matr[0,0] => temp = 1
        matr[0, i] = matr[lastRowIndex, i]; // matr[0, 0] = matr[2, 0] => matr[0, 0] = 7
        matr[lastRowIndex, i] = temp; // matr[2, 0] = temp
    }
}
Console.WriteLine("Поменяли 1 и последнюю строчку местами");
ChangeRows(result);
PrintMatrix(result); // Видоизмененная матрица (поменяли 1 и последнюю строчку)


Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.


Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.