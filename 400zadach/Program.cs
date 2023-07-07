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

// x = xyz = xyz-z = (xyz-z)/10 = z(xy) = 237

//int resultNumber = 237;
// int number=237;
// int firstDight = number/100;
// int secDight = number/10%10; 
// int lastDight = number%10;
// int numberWithoutLast = number - lastDight;
// int numberDivided10 = numberWithoutLast/10;
// int numberWithNewFirst = lastDight*100 + (numberDivided10/10)*10 + (number - lastDight)/10%10;
// int resultNumber = (number%10)*100 + (((number - (number%10))/10)/10)*10 + ((number - (number%10))/10)%10;


// Console.WriteLine((number%10));
// Console.WriteLine(resultNumber);
// Console.WriteLine(firstDight);
// Console.WriteLine(secDight);


// Home_25. В трехзначном числе x зачеркнули первую цифру. Когда оставшееся число умножили на 10, а произведение сложили с первой цифрой числа x, 
// то получилось число 564. Найти число x.

// res1=564 - x1; x1=564%10; res2= res1/10 if res1%10=0; x1*100 + res2  

// int number = 564;
// int firstDight = number/100;
// int secDight = number/10%10; 
// int lastDight = number%10;

// int x1 = number%10; // младший разряд определяется так
// int res1 = number - x1; // вычли цифру, то есть это младший разряд
// int res2 = res1/10; // обратная операция умножению числа на 10
// int X = x1*100 + res2; // первым разрядом ставим первую цифру числа X
// x1 = X/100; // теперь первую цифру можно вырвзить так
// int x2 = X/10%10; // вторая цифра
// int x3 = X%10; // третья цифра
// Console.WriteLine($"{firstDight}, {secDight}, {lastDight}"); // цифры известного числа 564
// Console.WriteLine($"{x1}, {x2}, {x3}"); // цифры искомого X
// Console.WriteLine($"{X}"); // вывод искомого числа X


/********************************************************************/

// Home_26. В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу слева приписали вторую цифру числа x, 
// то получилось число 546. Найти число x.

// 546 -> x2*100 + x1*10 + x3 -> x1 * 100 + x2 * 10 + x3 * 1 = X 
// x2 = 5 - первая цифра известного числа
// x1 = 4 
// x3 = 6 

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

// 09. Приведение типов данных

// Преобразование может привести к тому, что выражение данного типа будет обрабатываться как имеющее другой тип или может использоваться для выражение без типа для получения типа. Преобразования могут быть неявными или явными, и это определяет, требуется ли явное приведение. Например, преобразование типа int в тип long является неявным, поэтому выражения типа int могут обрабатываться как тип long. Обратное преобразование, от типа long к типу int, является явным, поэтому требуется явное приведение.

// int a = 123;
// long b = a;         // неявное преобразование
// int c = (int) b;    // явное преобразование
// Для встроенных числовых типов неявное преобразование можно выполнить, если сохраняемое значение может уместиться в переменной без усечения или округления. При использовании целочисленных типов это означает, что диапазон исходного типа является надлежащим подмножеством диапазона для целевого типа. Например, переменная типа long (64-разрядное целое число) может хранить любое значение, которое может хранить переменная int (32-разрядное целое число). В следующем примере компилятор неявно преобразует значение num справа в тип long перед назначением bigNum, и значение num в тип double:

// int num = 2147483647;
// long bigNum = num;
// double real = num;
// Тем не менее, если преобразование нельзя выполнить без риска потери данных, компилятор требует выполнения явного преобразования, которое называется приведением. Приведение — это способ явно указать компилятору, что необходимо выполнить преобразование и что вам известно, что может произойти потеря данных или приведение может завершиться сбоем во время выполнения. Чтобы выполнить приведение, укажите тип, в который производится приведение, в круглых скобках перед преобразуемым значением или переменной. В следующей программе выполняется приведение типа double в int. Программа не будет компилироваться без приведения.

// double dblNum = 1234.7;
// int intNum = (int) dblNum;
// System.Console.WriteLine(intNum);
// Неявное преобразование (автоматическое) — преобразованием меньше по размеру типа данных в больший:

// char -> int -> long -> float -> double

// Явное преобразование (ручное, принудительно) — обратное предыдущему преобразование большего типа в меньший:

// double -> float -> long -> int -> char


/********************************************************************/


// 10. Класс Math

// В классе Math собраны все основные математические функции: модуль числа, функция возведение числа в степень, 
// нахождение квадратного корня, выделение целой части, а также две константы E и PI. 
// Для использования его методов нужно указывать Math.метод(). Чтобы не писать постоянно слово Math, перед использованием его методов, 
// необходимо в заголовке нашей программы указать директиву подключения пространства имен класса Math на весь наш класс: using static System.Math;

// //Листинг решения:
// using System;
// using static System.Math;              // указание пространства имен класса Math
// namespace Serg40in {
//   class Program {
//     static void Main (string [] args) {
//         int b = -9;
//         double a = Abs(b);             // используем метод Abs класса Math
//         Console.WriteLine(a);          // выводит на экран число 9 
//   }
//  }
// }
// Методы класса Math:

// Abs(double value): возвращает абсолютное значение для аргумента value

// double result = Math.Abs(-12.4); // 12.4
// Acos(double value): возвращает арккосинус value. Параметр должен иметь значение -1 … 1

// double result = Math.Acos(1); // 0
// Asin(double value): возвращает арксинус value. Параметр value должен иметь значение -1 … 1

// double result = Math.Asin(-1); //-1,5707963267949
// Atan(double value): возвращает арктангенс value

// double result = Math.Atan(1); //0,785398163397448
// BigMul(int x, int y): возвращает произведение x * y в виде объекта long

// double result = Math.BigMul(100, 9340); // 934000
// Ceiling(double value): возвращает наименьшее целое число, которое не меньше value

// double result = Math.Ceiling(2.34); // 3
// Cos(double d): возвращает косинус угла d

// double result = Math.Cos(-1); //0,54030230586814
// Cosh(double d): возвращает гиперболический косинус угла d

// double result = Math.Cosh(-1); //1,54308063481524
// DivRem(int a, int b, out int result): возвращает результат от деления a/b, а остаток помещается в параметр result

// int result;
// int div = Math.DivRem(14, 5, out result);     //result = 4 // div = 2
// Exp(double d): возвращает основание натурального логарифма, возведенное в степень d

// Floor(decimal d): возвращает наибольшее целое число, которое не больше d

// double result = Math.Floor(2.56); // 2
// IEEERemainder(double a, double b): возвращает остаток от деления a на b

// double result = Math.IEEERemainder(26, 4); // 2 = 26-24
// Log(double d): возвращает натуральный логарифм числа d

// Log(double a, double newBase): возвращает логарифм числа a по основанию newBase

// Log10(double d): возвращает десятичный логарифм числа d

// Max(double a, double b): возвращает максимальное число из a и b

// Min(double a, double b): возвращает минимальное число из a и b

// Pow(double a, double b): возвращает число a, возведенное в степень b

// Round(double d): возвращает число d, округленное до ближайшего целого числа

// double result1 = Math.Round(20.56);            // 21
// double result2 = Math.Round(20.46);            // 20
// Round(double a, round b): возвращает число a, округленное до определенного количества знаков после запятой, представленного параметром b

// double result1 = Math.Round(20.567, 2);        // 20,57
// double result2 = Math.Round(20.463, 1);        // 20,5
// Sign(double value): возвращает число 1, если число value положительное, и -1, если значение value отрицательное. Если value равно 0, то возвращает 0

// int result1 = Math.Sign(15);                   // 1
// int result2 = Math.Sign(-5);                   //-1
// Sin(double value): возвращает синус угла value

// Sinh(double value): возвращает гиперболический синус угла value

// Sqrt(double value): возвращает квадратный корень числа value

// double result1 = Math.Sqrt(16); // 4
// Tan(double value): возвращает тангенс угла value

// Tanh(double value): возвращает гиперболический тангенс угла value

// Truncate(double value): отбрасывает дробную часть числа value, возвращая лишь целое значение

// double result = Math.Truncate(16.89); // 16
// Также класс Math определяет две константы: Math.E и Math.PI.

// Полная справка на странице с документацией:

// https://docs.microsoft.com/ru-ru/dotnet/api/system.math?view=netcore-1.1

// Numbers_18

// Дано положительное действительное число x. Выведите его дробную часть не используя математические действия.

// Пример использования:

// Пример использования:
// Выходные данные 1: Введите вещественное число
// Входные данные  1: 7.938
// Выходные данные 1: Дробная часть числа = 0.938
// Решение:

// Получаем вещественное число, и решаем через приведение к типу (int), или через метод округления, или через метод выделения целой части.

// //Листинг решения задачи numbers_18:
// using System;
// namespace Serg40in {
//   class Program {
//     static void Main(string[] args) {
//     Console.WriteLine("Введите вещественное число");
//     double dbl = double.Parse(Console.ReadLine());
//     Console.Write("Дробная часть числа = " + dbl - (int) dbl);
//     Console.ReadKey(); 
//   } 
//  }
// }
// Или через метод округления до наибольшего целого числа, которое меньше или равно указанному числу — Math.Floor():

// double dbl = double.Parse(Console.ReadLine());
// Console.Write("Дробная часть числа = " + dbl — Math.Floor(dbl));
// Или через метод выделения целой части:

// double dbl = double.Parse(Console.ReadLine());
// Console.Write("Дробная часть числа = " + dbl — Math.Truncate(dbl));
// Повторюсь, иногда требуется выделить целую часть из вещественного числа, то воспользуемся приведением вещественного числа в дробное (int) dbl 
// или эквивалентным действием — методом выделения целой части Math.Truncate(dbl);

// Если необходимо получить точность в вычислении вещественного значения в пределах десятых, сотых и т.д. 
// Используем операцию деление с остатком на 0.01 если нужны сотые, на 0.001 если нужны тысячные:

// double x = 15.1234;     
// x = x  - x % 0.001;        // 15,123
// Numbers_19

// Найти площадь круга заданного радиуса R. В качестве значения числа PI использовать 3.14.

// Пример использования:
// Выходные данные: Введите радиус круга
// Входные данные : 2
// Выходные данные: Площадь круга = 12.56
// Решение:

// Принимаем на вводе значение радиуса. Инициализируем переменную для хранения значения результата нахождения площади круга. 
// В качестве значения PI используем константу Math.PI округленную до сотых.

//Листинг решения задачи numbers_19:
// using System;
// namespace Serg40in {
//   class Program {
//     static void Main(string[] args) {
//     Console.WriteLine("Введите радиус круга в см");
//     int radius = Convert.ToInt32(Console.ReadLine());
//     double square = Math.Round(Math.PI, 2) * radius * radius;
//     Console.WriteLine("Площадь круга = " + Math.Round(square, 3) + " см. кв.");
//     Console.ReadKey(); 
//   } 
//  }
// }
// Или без дополнительной переменной square:
  
// Console.WriteLine("Введите радиус круга в см");
// int radius = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Площадь круга = " + Math.Round(Math.PI, 2) * radius * radius+ " см. кв.");
// Или используем метод Pow класса Math для возведения числа в степень:

// Console.WriteLine("Введите радиус круга в см");
// int radius = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Площадь круга = " + Math.Round(Math.PI, 2) * Math.Pow(radius,2) + " см. кв.");
// Или вообще, все доведем до двух строк решения:

// Console.WriteLine("Введите радиус круга в см");
// Console.Write("Площадь круга = " + 
//               Math.Round(Math.PI, 2) * Math.Pow(double.Parse(Console.ReadLine()), 2) + 
//               " см. кв.");
// Numbers_20

// На вход подается одно целое число — количество бит. Переведите данное количество информации в килобайты. Результат округлить до сотых.

// Пример использования:
// Выходные данные 1: Введите целое количество бит
// Входные данные  1: 8192
// Выходные данные 1: 8192 бит = 1 Кбайт
// Решение:


// Получаем значение с консоли, знаем что в одном килобайте 1024 байта, а в байте 8 бит. С помощью математических действий получаем нужный результат: 
// количество бит делим на 8 и делим на 1024. Учитываем что точный результат будет только если переменная для хранения значения результата будет вещественной. 
// Полученный результат округляем методом Round().

// //Листинг решения задачи numbers_20:
//using System;
// namespace Serg40in {
//  class Program {
//     static void Main(string[] args) {
//    

//    Console.WriteLine("Введите целое число бит");
//     double bit=Convert.ToInt32(Console.ReadLine());
//     double Kbyte=bit / 8 / 1024;
//     Console.Write(bit +" бит = " + Math.Round(Kbyte, 2) + " Кбайт");
//     Console.ReadKey(); 
//   }
//  }
// }
// Или сокращаем без использования промежуточных переменных:

// Console.WriteLine("Введите целое число бит");
// double bit=Convert.ToInt32(Console.ReadLine());
// Console.Write(bit +" бит = " + Math.Round(bit / 8 / 1024, 2) + " Кбайт");
// Или используя функцию класса Math:

// Console.WriteLine("Введите целое число бит");
// double bit=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(bit +" бит = " + Math.Round(bit / Math.Pow(2,13), 2) + " Кбайт");
// Numbers_21

// Найти периметр прямоугольного треугольника, с заданными построчно катетами, округленный до тысячных.

// Пример использования:
// Выходные данные: Введите построчно длины двух катетов
// Входные данные : (5.4) (2.1)
// Выходные данные: Периметр прямоугольного треугольника = 13.293
// Решение:

// Получаем построчно два вещественных числа, пользуясь формулой нахождения сторон прямоугольного треугольника a^2 + b^2 = c^2, 
// находим гипотенузу и следом периметр треугольника. Результат округляем то тысячных с помощью метода Math.Round(число, 3).

// //Листинг решения задачи numbers_21:
// using System;
// namespace Serg40in {
//   class Program {
//     static void Main(string[] args) {
//     Console.WriteLine("Введите построчно длины двух катетов");
//     double sideA = Convert.ToDouble(Console.ReadLine());
//     double sideB = Convert.ToDouble(Console.ReadLine());
//     double sideC = Math.Sqrt(sideA*sideA + sideB*sideB);
//     double perimetr = sideA + sideB + sideC;
//     Console.Write("Периметр прямоугольного треугольника = " + Math.Round(perimetr, 3));
//     Console.ReadKey(); 
//   } 
//   }
// }
// Или опять упрощаем, чтобы не вводить новые переменные:

// Console.WriteLine("Введите построчно длины двух катетов");
// double sideA = Convert.ToDouble(Console.ReadLine());
// double sideB = Convert.ToDouble(Console.ReadLine());
// Console.Write("Периметр прямоугольного треугольника = " + 
//                Math.Round(sideA + sideB + Math.Sqrt(sideA * sideA + sideB * sideB), 3));
// Numbers_22

// Найти расстояние между двумя точками c округлением до сотых, с заданными построчно координатами x1, y1, x2, y2.

// Пример использования:
// Выходные данные: Введите построчно координаты первой точки x1 и y1
// Входные данные : (1) (0)
// Выходные данные: Введите построчно координаты второй точки x2 и y2
// Входные данные : (4) (0)
// Выходные данные: Расстояние между точками = 3
// Решение:

// Решение этой задачи почти как и прошлой про периметр прямоугольного треугольника, нужно будет найти проекцию гипотенузы — расстояние от одной точки до другой, 
// но на вход мы получаем не длины катетов, а координаты расположения точек(вершин) на плоскости. Используем формулу:

// a=|x2-x1|; b=|y2-y1|

// получим длины катетов, а потом теоремой Пифагора находим нужное нам расстояние, и для вывода в консоль округлим результат решения до сотых методом Round():

// sqrt(c) = a*a + b*b

// //Листинг решения задачи numbers_22:
// using System;
// namespace Serg40in {
//   class Program {
//     static void Main(string[] args) {
//         Console.WriteLine("Введите построчно координаты первой точки x1 и y1");
//         double x1 = Convert.ToDouble(Console.ReadLine());
//         double y1 = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Введите построчно координаты второй точки x2 и y2");
//         double x2 = Convert.ToDouble(Console.ReadLine());
//         double y2 = Convert.ToDouble(Console.ReadLine());
//         double a = Math.Abs(x2 - x1);
//         double b = Math.Abs(y2 - y1);
//         double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
//         Console.WriteLine("Расстояние между точками = " + Math.Round(c,2));
//         Console.ReadKey(); 
//   } 
//  }
// }
// Или опять сократим, главное, чтобы код легко читался!

// Console.WriteLine("Введите построчно координаты первой точки x1 и y1");
// double x1 = Convert.ToDouble(Console.ReadLine());
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите построчно координаты второй точки x2 и y2");
// double x2 = Convert.ToDouble(Console.ReadLine());
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Расстояние между точками = " + 
//                    Math.Round(Math.Sqrt(Math.Pow(Math.Abs(x2 - x1), 2) + 
//                    Math.Pow(Math.Abs(y2 - y1), 2)), 2));
// Используем методы Math, такие как Abc() — нахождения модуля числа и Round() — для округления. Находим модуль числа обязательно, 
// иначе значения разности может быть отрицательным и получится некорректный ответ.

// Numbers_23

// Дано три числа. Найдите самое большее число, самое маленькое число и сумму максимального и минимального числа. 
// Для решения использовать только методы класса Math.

// Пример использования:
// Выходные данные 1: Введите построчно три числа
// Входные данные  1: (12.4) (4) (32.89)
// Выходные данные 1: Максимальное число = 32.59
// Выходные данные 1: Минимально число = 4
// Выходные данные 1: Сумма экстремумов = 36.59
// Решение:

// Чтобы найти нам максимальное из трех, необходимо использовать метод Math.Max() с двумя аргументами: первый аргумент — это первое введенное число, 
// а второй аргумент это максимальное из двух других чисел введенных с клавиатуры. Аналогично и для поиска минимального значения, только тут используем Math.Min().

// //Листинг решения задачи numbers_23:
// using System;
// namespace Serg40in {
//   class Program {
//     static void Main (string [] args) {
//     Console.WriteLine("Введите построчно три числа");
//     double num1 = double.Parse(Console.ReadLine());
//     double num2 = double.Parse(Console.ReadLine());
//     double num3 = double.Parse(Console.ReadLine());
//     double max = Math.Max(num1, Math.Max(num2, num3));
//     double min = Math.Min(num1, Math.Min(num2, num3));
//     double summa = max + min;
//     Console.WriteLine("Максимальное число = " + max);
//     Console.WriteLine("Минимальное число = " + min);
//     Console.WriteLine("Сумма экстремумов = " + (min + max));
//     Console.ReadKey();
//   }
//  }
// }
// Numbers_24

// Дано одно натуральное четырехзначное число. Найдите самое большое число, 
// полученное из заданного циклической перестановкой его цифр.

// Пример использования:
// Выходные данные 1: Введите целое четырехзначное число
// Входные данные  1: 5239
// Выходные данные 1: Максимальное число с цикличной перестановкой цифр = 9523

// Пример использования:
// Выходные данные 2: Введите целое четырехзначное число
// Входные данные  2: 1400
// Выходные данные 2: Максимальное число с цикличной перестановкой цифр = 4001
// Решение:

// Получаем целое число, не находя его цифры, мы можем получить первое число со сдвигом с помощью математического выражения: 
// число делим нацело на 10 и прибавляем к нему остаток от деления на 10 умноженный на 1000, 
// и так далее для поиска еще двух чисел, где нужно будет изначально делить нацело на 100 и на 1000. 
// И выбираем максимальное из всех трех чисел с помощью метода Math.Max():

//Листинг решения задачи numbers_24:
// using System;
// namespace Serg40in {
//   class Program {
//     static void Main(string[] args) {
//     Console.WriteLine("Введите целое четырехзначное число");
//     int num = Convert.ToInt32(Console.ReadLine());                // вводим 5239
//     int a = num / 10 + num % 10 * 1000;                           // a = 523 + 9*1000 = 9523
//     int b = num / 100 + num % 100 * 100;                          // b = 52 + 39*100 = 3952
//     int c = num / 1000 + num % 1000 * 10;                         // c = 5 + 239*10 = 2395
//     int d = Math.Max(Math.Max(a, b), Math.Max(n, c));             // d = 9523 
//     Console.WriteLine(d);
//     Console.ReadKey(); 
//   } 
//  }
// }
// Numbers_25*

// Дано одно натуральное четырехзначное число. Найдите самое большое число, полученное из заданного перестановкой его цифр. 
// Не использовать массивы, списки, строки, циклы, условные операторы.

// Пример использования:
// Выходные данные 1: Введите целое четырехзначное число
// Входные данные  1: 2135
// Выходные данные 1: Максимальное число с перестановкой цифр = 5321

// Пример использования:
// Выходные данные 2: Введите целое четырехзначное число
// Входные данные  2: 9329
// Выходные данные 2: Максимальное число с перестановкой цифр = 9932
// Решение:

// Находим все цифры числа. И начинаем находить отношение цифр к друг другу:

// — первая цифра — это максимальное из всех;

// — вторая цифра — минимальная из максимальных;

// — третья цифра — максимальная из минимальных;

// — четвертая цифра — это минимальное из всех;

// Но со второй и третьей цифрой может быть подвох с выборкой экстремума, рассмотрим:

// Min(Max(1,3), Max(6, 5)) = будет цифра три, когда нужно было получит пять.

// Поэтому необходимо перекрестно сделать дополнительное сравнение найденных значений.

// //Листинг решения задачи numbers_25:
// using System;
// namespace Serg40in {
//   class Program {
//     static void Main(string[] args) {
//     Console.WriteLine("Введите целое четырехзначное число");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int d1 = number / 1000;
//     int d2 = number / 100 % 10;
//     int d3 = number / 10 % 10;
//     int d4 = number % 10;
//     int x1 = Math.Max(Math.Max(d1, d2), Math.Max(d3, d4));
//     int x2 = Math.Min(Math.Max(d1, d2), Math.Max(d3, d4));
//     int x3 = Math.Max(Math.Min(d1, d2), Math.Min(d3, d4));
//     int x4 = Math.Min(Math.Min(d1, d2), Math.Min(d3, d4));
//     Console.Write("Максимальное число с перестановкой цифр = "); 
//     Console.Write(x1 * 1000 + Math.Max(x2, x3) * 100 + Math.Min(x2, x3) * 10 + x4);
//     Console.ReadKey(); 
//   } 
//  }
// }
// В новых темах мы решим эту через условие, решим через строку, через массив. А пока решаем только теми инструментами которыми умеем.

// Ниже приведены задания по теме для самостоятельного решения:

// Home_31. Написать консольное приложение для форматированного отображения количества информации в высоких единицах измерения приведенных в таблице, 
// при введенном количестве бит.

// 1 байт  = 2^3 бит
// 1 Кбайт = 2^13 бит = 2^10 байт
// 1 Мбайт = 2^23 бит = 2^20 байт = 2^10 Кбайт
// 1 Гбайт = 2^33 бит = 2^30 байт = 2^20 Кбайт = 2^10 Мбайт
// 1 Тбайт = 2^43 бит = 2^40 байт = 2^30 Кбайт = 2^20 Мбайт = 2^10 Гбайт
// 1 Пбайт = 2^53 бит = 2^50 байт = 2^40 Кбайт = 2^30 Мбайт = 2^20 Гбайт = 2^10 Тбайт
// Home_32. Написать консольное приложение для нахождения расстояния между двумя точками в 3х-мерном пространстве, 
// в ответ вывести значение c дробью до тысячных.

// Home_33. С начала суток часовая стрелка повернулась на y градусов (0 ≤ y < 360, y — вещественное число). 
// Определить число полных часов и число полных минут, прошедших с начала суток.

// Ссылки для самостоятельного изучения по пройденному материалу

// Документация на ввод — вывод данных:

// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.writeline?view=netframework-4.8

// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.read?view=netframework-4.8#System_Console_Read

// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.readline?view=netframework-4.8#System_Console_ReadLine

// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.readkey?view=net-5.0

// Escape последовательности

// https://docs.microsoft.com/ru-ru/cpp/c-language/escape-sequences?view=msvc-160&viewFallbackFrom=vs-2017

// Интерполяция строк

// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/tokens/interpolated

// Документация на типы данных

// https://metanit.com/sharp/tutorial/2.1.php

// https://docs.microsoft.com/ru-ru/dotnet/api/system.int32?view=net-5.0

// https://docs.microsoft.com/ru-ru/dotnet/api/system.double?view=net-5.0

// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/sizeof

// Приведение типов

// https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/types/casting-and-type-conversions

// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/numeric-conversions#implicit-numeric-conversions

// Класс Math

// https://docs.microsoft.com/ru-ru/dotnet/api/system.math?view=net-5.0

// Директивы using

// https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/using-directive

// Звуковой сигнал

// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.beep?view=net-5.0

// Преображение окна консоли

// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.title?view=net-5.0

// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.foregroundcolor?view=net-5.0

// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.backgroundcolor?view=net-5.0

// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.windowheight?view=net-5.0

// https://docs.microsoft.com/ru-ru/dotnet/api/system.console.windowwidth?view=net-5.0

// Итоговые практические задания по пройденным темам

// Practic_1. Консольная шпаргалка

// Постановка задачи: красиво вывести информацию о примитивных типах данных в виде таблице, со следующим содержанием: тип данных, диапазон значений, 
// количество байтов занимаемые этим типом. Оформить в виде таблице, всё аккуратно и красиво.

// Новые знания: типы данных, константы типов MinValue и MaxValue, sizeof

// Practic_2. Консольный калькулятор

// Постановка задачи: написать программу, которая умеет выполнять следующие действия: сложение, вычитание в две стороны, умножение, деление в две стороны, 
// возведение в степень в две стороны. Количество чисел — два числа. Оформить всё аккуратно и красиво.

// Новые знания: типы данных, Escape-последовательности, интерполяция строк

// Practic_3. Консольные наскальные рисунки

// Постановка задачи: Создать консольную программу, которая выводит в консоли определенный рисунок. 
// Пользуйтесь возможностью консоли изменять цвет текста и цвет подложки под текст — за счет этого можно изображать своеобразные «рисунки». 
// Изменить заголовок консольного окна.

// Новые знания: Console.ForegroundColor, Console.BackgroundColor, Console.Title

// Practic_4. Консольные песни

// Постановка задачи: Создать консольную программу, которая выводит в консоли форматированный текст песни и мелодию этой песни. 
// Пользуйтесь возможностью консоли изменять цвет текста и цвет подложки под текст, для вывода звука на консоль воспользуйтесь звуковым сигналом 
// с определенной частотой и длительностью.

// Новые знания: Console.Beep()

// Practic_5. Консольная свободная Задача

// Постановка свободной задачи: поставьте перед собой определенную конкретную задачу, расписав алгоритм (как эта задача будет действовать) и попробуйте решить её. 
// Постарайтесь сделать так, чтобы задача не была сложной (чтобы вы знали, что нужно сделать чтобы решить её), но, в то же время не стандартной. 
// При этом обязательно использовать только те инструменты, которые уже знаете, где условия, циклы, массивы и другие конструкции, которые мы не проходили — не использовать!