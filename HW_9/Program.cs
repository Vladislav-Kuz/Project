// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int endNumber =1;
// string PrintNumbers(int start, int end) // start = 1, end = n
// {
//     // Базовый случай
//     if (start == end) return start.ToString(); 
//     // Рекурсивный случай - вызвать функцию внутри функции 
//     if (start>0) return start + ", " + PrintNumbers(start-1, end);
//     else return start + ", " + PrintNumbers(start+1, end);
// }

// Console.WriteLine($"Числа от N={n} до 1: {PrintNumbers(n, endNumber)}");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();  
//     if (start < end) return start + ", " + PrintNumbers(start+1, end);
//     else return start + ", " + PrintNumbers(start-1, end);
// }
// Console.WriteLine($"Числа от M={m} до N={n}: {PrintNumbers(m, n)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// формула Роже Петер

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int a, int b)
{
if(a==0) return b+1;
if(b==0) return akkerman(a-1, 1);
return akkerman(a-1, akkerman(a, b-1));
}
Console.WriteLine($"Числа: {akkerman(m,n)}");