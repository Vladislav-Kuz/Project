Console.Write("Выберите номер задачи:\n"
+ "1 - Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.\n"
+ "2 - Задача 66: Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n"
+ "3 - Задача 68: Программа вычисления функции Аккермана с помощью рекурсии.\n"
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
}



void task1()
{
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Программа, которая выводит все натуральные числа в промежутке от N до 1.");
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int endNumber =1;
Console.WriteLine($"Числа от N={n} до 1: {PrintNumbers(n, endNumber)}");

string PrintNumbers(int start, int end) // start = 1, end = n
{
    if (start == end) return start.ToString();  
    if (start>0) return start + ", " + PrintNumbers(start-1, end);
    else return start + ", " + PrintNumbers(start+1, end);
}

}

void task2()
{
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Программа, которая находит сумму натуральных элементов в промежутке от M до N.");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();  
    if (start < end) return start + ", " + PrintNumbers(start+1, end);
    else return start + ", " + PrintNumbers(start-1, end);
}
Console.WriteLine($"Числа от M={m} до N={n}: {PrintNumbers(m, n)}");
}

void task3()
{
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// формула Роже Петер

Console.WriteLine("Программа вычисления функции Аккермана");
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
Console.WriteLine($"Значение функции Аккермана: {akkerman(m,n)}");
}
