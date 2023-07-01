/*********************************************************************

07. Анализ цифр числа
Задачи № 21 -  № 27 из 400 задач по C# 


*********************************************************************/
// Метод для ввода данных с переводом из строки в целое число
// //====Console.WriteLine("Введите целое число");
// //====Console.WriteLine("Число " + int.Parse(Console.ReadLine()!));
// //====int parseNumber = int.Parse(Console.ReadLine()!);


/********************************************************************/

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


// //====Console.WriteLine("Введите целое число");
// //====Console.WriteLine("Число " + int.Parse(Console.ReadLine()!));
// //====int parseNumber = int.Parse(Console.ReadLine()!);

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


// Home_24. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x, 
// то получилось число 237. Найти число x.





// Home_25. В трехзначном числе x зачеркнули первую цифру. Когда оставшееся число умножили на 10, а произведение сложили с первой цифрой числа x, 
// то получилось число 564. Найти число x.



/********************************************************************/

// Home_26. В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу слева приписали вторую цифру числа x, 
// то получилось число 546. Найти число x.

// пусть 546=xyz<-yz<-YXZ=456

// int number = 546;
// string stringNumber = Convert.ToString(number);
// Console.WriteLine($"Производим действия с числом {number}: ");
// // получаем цифры числа
// int firstRes = number/100;
// int secRes=number/10%10;
// int thirdRes=number%10;
// // присваиваем цифрам полученного числа цифры изначального по алгоритму
// int secDight = firstRes;
// int firstDight = secRes;
// int thirdDight = thirdRes;
// int result = thirdDight + firstDight*100 + secDight*10;
// // вывод в консоль
// Console.WriteLine($"X =  {result}");


/********************************************************************/

// Home_27. В трехзначном числе x зачеркнули его последнюю цифру. Когда в оставшемся двузначном числе переставили цифры, а затем приписали к ним слева последнюю цифру числа x, 
// то получилось число 654. Найти число x.

// int number = 654;
// string stringNumber = Convert.ToString(number);
// Console.WriteLine($"Производим действия с числом {number}: ");
// // получаем цифры числа
// int firstDight = number/100;
// int secDight=number/10%10;
// int thirdDight=number%10;
// // выполняем алгоритм действий 654 = xyz -> xy -> yx -> zyx
// int stepOne = (firstDight)*10 + secDight; 
// int stepTwo = firstDight + (secDight*10);
// int stepThree = thirdDight*100 + firstDight + (secDight*10);

// // вывод в консоль
// Console.WriteLine($"шаг 1: убрали последнюю цифру: {stepOne}");
// Console.WriteLine($"шаг 2: поменяли местами цифры: {stepTwo}");
// Console.WriteLine($"шаг 3: добавили вперед последнюю цифру {thirdDight}: {stepThree}");
// Console.WriteLine($"X =  {stepThree}");

/********************************************************************/