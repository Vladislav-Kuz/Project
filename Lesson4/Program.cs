﻿/***************************************************/

// string[,] table= new string[2,5];
// table[1,2] ="слово";
// for(int i = 0; i < 2; i++)
// {
//     for(int j = 0; j < 5; j++)
//     {
//         Console.Write($"-{table[i,j]}- ");
//     }
//     Console.WriteLine();    
// }

/***************************************************/


// int[,] matrix= new int[3,4];
// for(int i = 0; i < 3; i++)
// {
//     for(int j = 0; j < 4; j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();    
// }

// теперь то же самое с использованием GetLength

// int[,] matrix= new int[3,4];
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();    
// }

/***************************************************/

// //---------------------------------------------------
// // Пишем метод, выводящий массив
// //---------------------------------------------------

// void PrintArray(int[,] matr)
// {
// for(int i = 0; i < matr.GetLength(0); i++)
// {
//     for(int j = 0; j < matr.GetLength(1); j++)
//     {
//         Console.Write($"{matr[i,j]} ");
//     }
//     Console.WriteLine();    
// }
// }

// //---------------------------------------------------
// // Пишем метод, наполняющий массив случайными числами
// //---------------------------------------------------

// void FillArray(int[,] matr)
// {
// for(int i = 0; i < matr.GetLength(0); i++)
// {
//     for(int j = 0; j < matr.GetLength(1); j++)
//     {
//         matr[i,j] = new Random().Next(10,100);
//     }
// }
// }

// //---------------------------------------------------
// //Тело программы
// //---------------------------------------------------

// int[,] matrix= new int[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


/***************************************************/

//-----------------------------------------------
// Теперь рисование
//-----------------------------------------------


// -----------------------------------------------
// Есть контейнер с рисунком
// -----------------------------------------------

// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// //-----------------------------------------------
// // Метод вывода картинки
// //-----------------------------------------------

// void PrintImage(int[,] image)
// {
// for(int i = 0; i < image.GetLength(0); i++)
// {
//     for(int j = 0; j < image.GetLength(1); j++)
//     {
//         if(image[i,j]==0)
//         Console.Write(" ");    
//         else Console.Write("+");    
//     }
//     Console.WriteLine();    
// }
// }

// //-----------------------------------------------
// // Метод закрашивания картинки
// //-----------------------------------------------

// void FillImage(int row, int col)
// {
//     if(pic[row, col]==0)
//     {
//         pic[row, col]=1;
//         FillImage(row-1, col);
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);
//     }
// }


// //-----------------------------------------------
// // Поиск незакрашенной точки
// //-----------------------------------------------

// int FingEmptySpace(int[,] image, int rawOrString)
// {
//     int row1 = 0;
//     int col1 = 0;
//     int flag = 0;
//     int iFirst = 0;
//     int jFirst = 0;
//     int dif = 0;
//     for(int i = 0; i < image.GetLength(0); i++)
//     {
//         flag=0;
//         if(dif>2) break;
//         for(int j = 0; j < image.GetLength(1); j++)
//         {
//             if(dif>2) break;
//             if(image[i,j]==1)
//             {
//                 if(flag==0)
//                 {
//                     flag = 1;
//                     iFirst = i;
//                     jFirst = j;
//                 }
//                 else
//                 if(flag==1)
//                 {
//                     dif = j - jFirst;   
//                     if(dif > 1)
//                     { 
//                         row1 = iFirst;
//                         col1 = jFirst + 1;
//                     }
//                 }
//             }
//         }
//     }
//     if (rawOrString == 0)
//     return row1;
//     else return col1;
// }
// //-----------------------------------------------
// // Тело программы
// //-----------------------------------------------
// int row2;
// int col2;
// PrintImage(pic);
// row2 = FingEmptySpace(pic,0);
// col2 = FingEmptySpace(pic,1);
// Console.WriteLine($"Начинаем закрашивать со строки row index = {row2}, столбца column index = {col2}");
// FillImage(row2, col2);
// PrintImage(pic);

/***************************************************/

// Числа Фибоначчи

// double Fibonacci(int n)
// {
//     if(n==1 || n == 2) return n;
//     else return Fibonacci(n-1)+Fibonacci(n-2);
// }

// for(int i=1; i<40; i++) // от бОльших чисел опасно, очень долго считает
// {
//     Console.WriteLine(Fibonacci(i));
// }

// Факториал числа через рекрсию
Console.Write("Введите целое число: ");
int numberParse = int.Parse(Console.ReadLine()!);
int N = numberParse;
Console.WriteLine($"Факториал числа !{numberParse} = {Factorial(N)}");
double Factorial(int n)
{
    if (n==1) return 1;
    else return n*Factorial(n - 1);
}
