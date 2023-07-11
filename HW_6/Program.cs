﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
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

 //----------------------------------------------//
 // Тело программы                               //
 //----------------------------------------------//

int size = 4;
double[] Coordinates = GetArray(size);
double k1 = Coordinates[0];
double b1 = Coordinates[1];
double k2 = Coordinates[2];
double b2 = Coordinates[3];
double[] ResultInterceptPoint = SearchinterceptPoint(k1,b1,k2,b2);
if (Double.IsInfinity(ResultInterceptPoint[0])||Double.IsInfinity(ResultInterceptPoint[1])) 
    Console.WriteLine($"Прямые не пересекаются"); 
else if(k1==k2 && b1==b2)
    Console.WriteLine($"Прямые совпадают");
else 
    Console.WriteLine($"Прямые y(x)={k1}x+{b1} и y(x)={k2}x+{b2} пересекаются в  точке А[x,y] = A[{string.Join("; ", ResultInterceptPoint)}]");


 //----------------------------------------------//
 // Метод получения коэффициентов                //
 //----------------------------------------------//

double[] GetArray(int size)
{
    double result;
    double[] coef = new double[size];
    Console.WriteLine("Введите коэффициенты: ");
    for(int i=0; i<size; i++)
    {
        if(i==0) Console.WriteLine("коэффициент k1 = ");
        else if(i==1) Console.WriteLine("коэффициент b1 = ");
        else if(i==2) Console.WriteLine("коэффициент k2 = ");
        else Console.WriteLine("коэффициент b2 = ");
        string strCoef = Console.ReadLine()!;
        bool resParsing = double.TryParse(strCoef, out result);
        if(resParsing) 
            coef[i]=result;
        else
        { 
            Console.Write("Повторите ввод\n");
            i--;
        }
    }
return coef;
}
 

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
