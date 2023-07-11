// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//1. сеачала спрашиваем сколько чисел введет пользователь
//2. вводим числа (сразу в массив)
//3. в цикле смотрим, если число >0, увеличиваем счетчик
//4. выводим счетчик (можно и массив)


 //----------------------------------------------//
 // Тело программы                               //
 //----------------------------------------------//

// Console.WriteLine("Задача: посчитать, сколько чисел больше 0 ввёл пользователь");
// Console.WriteLine();
// Console.Write("Сколько элементов массива вы будете вводить? ");
// string strNumber = new string (Console.ReadLine());
// bool resParseLength = int.TryParse(strNumber, out int NumberOfElements);
// if (resParseLength)
// {
//     int[] userArray = GetArray(NumberOfElements);    
//     int res = CountPositiveSumm(userArray);
//     Console.Write($"В массиве: {string.Join("; ", userArray)} количество положительных чисел: {res}");
// }
// else Console.Write("Введены некорректные данные");

//  //----------------------------------------------//
//  // Метод формирования массива                   //
//  //----------------------------------------------//

// int[] GetArray(int size)
// {
//     int[] array = new int[size];
//     size = array.Length;   
//     for(int i = 0; i < array.Length; i++)
//     {
//         string ?readElement = Console.ReadLine();
//         bool resParseLength = int.TryParse(readElement, out int ElementIsNumber);
//         if(resParseLength) array[i] = ElementIsNumber;
//         else Console.WriteLine("Введен некорректный элемент, заменен нулевым");
//     }
//     return array; 
// }  

//  //----------------------------------------------//
//  // Метод подсчета элементов                     //
//  //----------------------------------------------//

// int CountPositiveSumm (int[] arr)
// {
//     int count =0;
//     foreach(int item in arr)
//     {
//         if(item>0)  count++;
//     }
// return count;
// }

 //----------------------------------------------//



 //----------------------------------------------//

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.WriteLine("Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
Console.WriteLine();


int tryCount = 0;

Console.WriteLine("Введите коэффициенты: ");
Console.Write($"k1 = ");   
string strCoef1 = Console.ReadLine()!;
if (element != string.Empty)        // условие для нормального заполнения элементов массива
{
    double k1 = Coordinates[0];

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



double[] Coordinates = GetArray(4);
double k1 = Coordinates[0];
double b1=Coordinates[1];
double k2=Coordinates[2];
double b2=Coordinates[3];

double[] ResultInterceptPoint = SearchinterceptPoint(k1,b1,k2,b2);
if (Double.IsInfinity(ResultInterceptPoint[0])||Double.IsInfinity(ResultInterceptPoint[1])) 
Console.WriteLine($"Прямые не пересекаются");  
else 
Console.WriteLine($"Прямые y(x)={k1}x+{b1} и y(x)={k2}x+{b2} пересекаются в  точке А[x,y] = A[{string.Join("; ", ResultInterceptPoint)}]");

 

 //----------------------------------------------//
 // Метод вычисления точки пересечения           //
 //----------------------------------------------//

double[] SearchinterceptPoint(double angle1, double bias1, double angle2, double bias2)
{
int length = 2;
double[] interceptCoordinate = new double[length];
double x = (bias2-bias1)/(angle1-angle2);
double y = ((angle1*(bias2-bias1)/(angle1-angle2)) + bias1);
interceptCoordinate[0] = x;
interceptCoordinate[1] = y;
return interceptCoordinate;     
}

 //----------------------------------------------//



 //----------------------------------------------//
