// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end) // start = 1, end = n
{
    // Базовый случай
    if (start == end) return start.ToString(); 
    // Рекурсивный случай - вызвать функцию внутри функции 
    return start + ", " + PrintNumbers(start + 1, end);
}

Console.WriteLine($"Числа от 1 до {n}: {PrintNumbers(1, n)}");


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Задача 67: Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//     // Базовый случай
//     if (num == 0) return 0;
//     // Рекурсивный
//     return num % 10 + SumNumbers(num / 10);

// }
// Console.WriteLine($"Cумма цифр в числе {number}: {SumNumbers(number)}");



// // Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// // и возводит число А в целую степень B с помощью рекурсии.
// // A = 3; B = 5 -> 243 (3⁵)
// // A = 2; B = 3 -> 8

// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень В: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int Pow(int num, int rank)
// {
//     // Базовые случаИ (их тут 2)
//     if (rank == 0)  return 1;
//     if (rank == 1)  return num;
//     // Рекурсивный случай
//     return num * Pow(num, rank - 1);
// }

// Console.WriteLine($"{A} в степени {B} = {Pow(A, B)}");
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень В: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int Pow(int num, int rank)
// {
//     // Базовые случаИ (их тут 2)
//     if (rank == 0)  return 1;
//     if (rank == 1)  return num;
//     // Рекурсивный случай
//     return num * Pow(num, rank - 1);
// }
// if(B < 0)
// {
//     System.Console.WriteLine("Степень меньше 0 мы не обрабатываем");
//     return;
// }
// Console.WriteLine($"{A} в степени {B} = {Pow(A, B)}");



