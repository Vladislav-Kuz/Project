/*************************************************************************

Домашнее задание №4

*************************************************************************/

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine();
// Console.WriteLine("Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную (и не очень) степень B.");
// Console.WriteLine();
// Console.Write("Введите число, кторое нужно возвести в степень: A = ");
// double a = double.Parse(Console.ReadLine()!);
// Console.Write("Введите число, кторое является степенью A: B = ");
// double b = int.Parse(Console.ReadLine()!);
// double result = Power(a, b);
// Console.Write($"{a} ^ {b} = {result}");

// double Power(double x, double y)
// {
//     double res = 1;
//     if (y < 0)
//     {
//         x = 1 / x;
//         y = -1 * y;
//     }
//     if (y >= 0)
//     {
//         for (int i = 0; i < y; i++) res *= x;
//     }
//     return res;
// }



/*************************************************************************/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine();
// Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в нем.");
// Console.WriteLine();
// Console.Write("Введите число: ");
// string? strNumber = Console.ReadLine()!;
// string? strToConvert = strNumber; // переменная для проведения вычислений
// bool resParsing = int.TryParse(strToConvert, out var number); // флаг численного значения вводимой строки
// int result = 0;
// int count = 0;
// if (resParsing == true)
// {
//     if (number < 0) // обработчик ситуации, когда число отрицательное
//     {
//         int invertNumber = -1 * number;
//         strToConvert = invertNumber.ToString();
//     }

//     count = strToConvert.Length;
//     int[] array = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = int.Parse(strToConvert[i].ToString());
//         result += array[i]; // здесь суммируем элементы массива
//     }
//     Console.WriteLine($"Сумма {count}-х разрядов числа {number} равна {result}");
// }
// else Console.WriteLine("Это не число");



/*************************************************************************/


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Или массив из 8 элементов вводится с консоли (каждый элемент вводит человек)


// Console.WriteLine();
// Console.Write($"Программа, которая получает длину и элементы массива с консоли и выводит их на экран.\nВ случае, если пользователь 3 раза не ввел значение элемента массива, в элемент подставляется случайное число от 10 до 1000 включительно\n");
// Console.WriteLine();
// Console.Write($"Введите количество элементов в массиве: ");
// string strLength = Console.ReadLine()!;
// bool lengthParsing = int.TryParse(strLength, out var number);   // флаг численного значения вводимой строки
// int tryCount = 0;
// if (lengthParsing == true)
// {
//     Console.WriteLine("Введите элементы массива: ");
//     string[] array = new string[number];
//     for (int i = 0; i < number; i++)
//     {
//         Console.Write($"A[{i + 1}]: ");     // нумерация условная, для пользователя, 0-й элемент отображен как 1-й элемент массива
//         string element = Console.ReadLine()!;
//         if (element != string.Empty)        // условие для нормального заполнения элементов массива
//         {
//             array[i] = element;
//             tryCount = 0;
//         }
//         else 
//         {
//             int tryMax = 3;                 // число попыток ввода
//             if (tryCount < tryMax)          // условие для возможности повторного ввода
//             {
//                 Console.Write($"Повторите ввод: ");
//                 i--;
//                 tryCount++;
//             }
//             else                            // условие. если n-раз не введен элемент
//             {
//                 string randomElement = Convert.ToString(new Random().Next(10, 1001));   // генерируем число от 10 до 1000 включительно
//                 array[i] = randomElement;   // после 3-х попыток ввода кладем в элемент случайное число
//                 Console.WriteLine($"вы не ввели элемент A[{i+1}], подставляю случайный A[{i+1}] = {randomElement}"); // нумерация условная, для пользователя, 0-й элемент отображен как 1-й элемент массива
//                 tryCount = 0;
//             }
//         }
//     }
//     Console.WriteLine($"Вы создали массив A[{number}] = [{string.Join("; ", array)}]");
// }
// else Console.Write($"Это должно быть число");



/*************************************************************************/

// Задача 29: Та же задача, только с использованием способа, когда его размер увеличивается по мере ввода элементов (нагуглено)

// Console.WriteLine();
// Console.Write($"Программа, которая получает элементы массива с консоли и выводит их на экран.\n");
// Console.WriteLine();

// string[] array; 
// int count = 0;                              // количество элементов
// string element;
// string[] previosArray; 
// Console.WriteLine("Введите элементы массива(любая строка): ");
// array = new string[count];                  // пока массив для count=0 элементов
// do                                          // постпроверка для того, чтобы в конце среагировать по факту ввода пустого элемента
// {
//     Console.Write($"A[{count + 1}]: ");  
//     element = Console.ReadLine()!;
//     if (element != string.Empty)
//     {
//         count++;
//         previosArray = new string[count];   // создаем массив, в котором на 1 элемент больше
//         for (int i = 0; i < previosArray.Length - 1; i++)   // копируем старый массив в новый
//             previosArray[i] = array[i]!;
//         previosArray[count - 1] = element;  // добавляем последнюю введенную строку в массив previosArray
//         array = previosArray;               // дополняем array последним элементом 
//     }
// } while (element != string.Empty);
// Console.WriteLine($"Вы создали массив A[{array.Length}] = [{string.Join("; ", array)}]");



/*************************************************************************/