/*******************************************************************

Домашнее задание №3

*******************************************************************/

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// Есть еще вариант развернуть массив, выдать его в строку и сравнить начальную и конечную строки

/********************************************************************/

// Console.WriteLine("Введите пятизначное число или строку из пяти символов: ");
// string? value = Console.ReadLine()!;
// int res;
// bool flagDight = int.TryParse(value, out res);
// char[] array = value.ToCharArray();
// //char[] array = value.ToArray<char>(); // можно таким методом
// int length = array.Length;
// int i = 0;
// int flag = 0;

// if (length == 5)
// {
//     while (i < length / 2) // Идем до середины массива
//     {
//         if (array[i] != array[(length - i - 1)])
//         {
//             Console.WriteLine("Не палиндром");
//             flag++;
//             break;
//         }
//         i++;
//     }
//     if (flag == 0)
//     {
//         if (flagDight)
//         {
//             Console.WriteLine("Введенное число является палиндромом");
//         }
//         else
//         {
//             Console.WriteLine("Введенная строка символов является палиндромом");
//         }
//     }
// }
// else Console.WriteLine("Введено не пятизначное число (строка)");


/********************************************************************/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("Введите координаты точки А: \n");
// Console.Write("X: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z: ");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки B: \n");
// Console.Write("X: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Z: ");
// int zb = Convert.ToInt32(Console.ReadLine());
// int ox = (xb-xa);
// int oy = (yb-ya);
// int oz = (zb-za);
// double ab = Math.Round(Math.Sqrt ((Math.Pow(ox,2) + Math.Pow(oy,2) + Math.Pow(oz,2))),3);
// Console.WriteLine($"Расстояние между А и В равно: {ab}");


/********************************************************************/


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


// Console.Write("Введите число: \n");
// int N = Convert.ToInt32(Console.ReadLine());

// void Power(int n)
// {
//     Console.WriteLine("**********************");
//     double[] arrayFill = new double[n+1];
//     int i;
//     for (i = 1 ; i< n+1 ; i++)
//     {
//         double result =  Math.Pow(i,3);
//         arrayFill[i] = result;
//         Console.WriteLine($"{i}^3 = {arrayFill[i]} ");
//     }
// }

// Power(N);


// Для усложенения: модифицировать программу из 19 задания и сделать так, чтобы проверялись не только цифры, но и строчки.
// Или любую задачку из 400 задач по C#: https://serg40in.ru/reshaem-400-zadach-na-c/


/*******************************************************************

07. Анализ цифр числа
Задачи № 21 -  № 23 из 400 задач по C# 

*********************************************************************/


// Home_21. Дано трехзначное число. Найти:

// а) число единиц в нем;

// б) число десятков в нем;

// в) сумму его цифр;

// г) произведение его цифр.

// Решить в одной программе.

// Console.Write("Введите трехзначное число: ");
// string? stringNumber = Console.ReadLine()!;
// int number;

// bool isNumber = int.TryParse(stringNumber, out number);
// if (stringNumber.Length == 3 && isNumber){
// Console.WriteLine($"Во введенном числе {number}: ");
// // вычисления
// int firstDight = number/100;
// int secDight=number/10%10;
// int thirdDight=number%10;
// int sum = firstDight + secDight + thirdDight;
// int mult = firstDight * secDight * thirdDight;
// // вывод в консоль
// Console.WriteLine($"число единиц: {thirdDight}");
// Console.WriteLine($"число десятков: {secDight}");
// Console.WriteLine($"сумма цифр: {sum}");
// Console.WriteLine($"произведение цифр: {mult}");
// }
// else
// {
//     if (stringNumber.Length != 3){
//     Console.WriteLine("Это не трехзначное число");
//     }
//     if (!isNumber){
//     Console.WriteLine("Это не число");
//     }
// }

/********************************************************************/

// Home_22. Дано трехзначное число.

// а) Найти число, полученное при прочтении его цифр справа налево.

// б) В нем зачеркнули первую слева цифру и приписали ее в конце. Найти полученное число.

// в) В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.

// г) Найти число, полученное при перестановке первой и второй цифр заданного числа.

// д) Найти число, полученное при перестановке второй и третьей цифр заданного числа.

// Решить в одной программе.


// Console.Write("Введите трехзначное число: ");
// string? stringNumber = Console.ReadLine()!;
// Console.WriteLine();
// int number;
// bool isNumber = int.TryParse(stringNumber, out number);
// if (stringNumber.Length == 3 && isNumber){
// Console.WriteLine($"Для введенного числа {number}: ");
// Console.WriteLine();
// // вычисления


// // 1. Разворачивание строки
// string toReverse = stringNumber;
// char[] ReverseNumber = toReverse.ToCharArray();
// Array.Reverse(ReverseNumber);
// string reversed = new string(ReverseNumber);
// int reversedNumber = Convert.ToInt32(reversed);

// //  2. Перенос первой цифры в конец
// string toSwap = stringNumber;
// char temp;
// char[] SwapNumber = toSwap.ToCharArray();
// temp = SwapNumber[0];
// SwapNumber[0] = SwapNumber[1];
// SwapNumber[1] = SwapNumber[2];
// SwapNumber[2] = temp;
// string swapedFirstToLast = new string(SwapNumber);
// int swapedNumberFirstToLast = Convert.ToInt32(swapedFirstToLast);

// // 3. Перенос последней цифры в начало
// char[] SwapNumber2 = toSwap.ToCharArray();
// temp = SwapNumber2[2];
// SwapNumber2[2] = SwapNumber2[1];
// SwapNumber2[1] = SwapNumber2[0];
// SwapNumber2[0] = temp;
// string swapedLastToFirst = new string(SwapNumber2);
// int swapedNumberLastToFirst = Convert.ToInt32(swapedLastToFirst);

// // 4. Перестановка первой и второй цифры
// char[] SwapNumber3 = toSwap.ToCharArray();
// temp = SwapNumber3[0];
// SwapNumber3[0] = SwapNumber3[1];
// SwapNumber3[1] = temp;
// string swapedFirstSecond = new string(SwapNumber3);
// int swapedNumberFirstSecond = Convert.ToInt32(swapedFirstSecond);

// // 5. Перестановка второй и третьей цифры
// char[] SwapNumber4 = toSwap.ToCharArray();
// temp = SwapNumber4[1];
// SwapNumber4[1] = SwapNumber4[2];
// SwapNumber4[2] = temp;
// string swapedSecondThird = new string(SwapNumber4);
// int swapedNumberSecondThird = Convert.ToInt32(swapedSecondThird);


// // вывод в консоль
// Console.WriteLine($"реверс числа: {reversedNumber}");
// Console.WriteLine($"перенос первой цифры в конец: {swapedNumberFirstToLast}");
// Console.WriteLine($"перенос последней цифры в начало: {swapedNumberLastToFirst}");
// Console.WriteLine($"перестановка 1 и 2 цифры: {swapedNumberFirstSecond}");
// Console.WriteLine($"перестановка 2 и 3 цифры: {swapedNumberSecondThird}");

// }
// else
// {
//     if (stringNumber.Length != 3){
//     Console.WriteLine("Это не трехзначное число");
//     }
//     if (!isNumber){
//     Console.WriteLine("Это не число");
//     }
// }


/********************************************************************/


// Home_23. Дано трехзначное число, в котором все цифры различны. Получить шесть чисел, образованных при перестановке цифр заданного числа.



// Console.Write("Введите трехзначное число: ");
// string? stringNumber = Console.ReadLine()!;
// Console.WriteLine();
// int number;
// bool isNumber = int.TryParse(stringNumber, out number);
// if (stringNumber.Length == 3 && isNumber)
// {
//     char[] array = stringNumber.ToCharArray();
//     int length = stringNumber.Length;
//     int firstDight = number / 100;
//     int secndDight = number / 10 % 10;
//     int ThirdDight = number % 10;

//     if (array[0] != array[1] && array[0] != array[2] && array[1] != array[2]) // проверка на одинаковые цифры
//     {
//         int first = firstDight * 100 + secndDight * 10 + ThirdDight;
//         int secnd = firstDight * 100 + secndDight + ThirdDight * 10;
//         int third = firstDight * 10 + secndDight * 100 + ThirdDight;
//         int forth = firstDight * 10 + secndDight + ThirdDight * 100;
//         int fives = firstDight + secndDight * 100 + ThirdDight * 10;
//         int sixes = firstDight + secndDight * 10 + ThirdDight * 100;

//         // вывод в консоль
//         Console.Write($"Из цифр {firstDight}, {secndDight}, {ThirdDight} составляются следующие варианты: \n");
//         Console.Write($"{first}, {secnd}, {third}, {forth}, {fives}, {sixes}");
//         Console.WriteLine();
//     }
//     else Console.Write("В числе есть одинаковые цифры"); // обработка исключений
// }
// else // обработка исключений
// {
//     if (!isNumber)
//     {
//         Console.WriteLine("Это не число");
//     }
//     else
//     if (stringNumber.Length != 3)
//     {
//         Console.WriteLine("Это не трехзначное число");
//     }
// }


/********************************************************************/