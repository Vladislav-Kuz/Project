// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine();
// Console.WriteLine("Программа, которая показывает количество чётных чисел в массиве из случайных чисел.");
// Console.WriteLine();
// Console.Write("Введите размер массива: ");
// string strLength = Console.ReadLine()!;
// bool resParsing = int.TryParse(strLength, out var length); 
// if (resParsing)
// {
// int[] arrayToFind = CreateRandomArray(length);
// int res = EvenCount(arrayToFind);
// Console.WriteLine($"В массиве случайных трехзначных чисел: [{string.Join("; ", arrayToFind)}] \nсодержится {res} четных чисел");
// Console.WriteLine();

// }
// else Console.WriteLine("Длина массива должна быть числом!"); 
// //----------------------------------------------//
// // Метод формирования массива                   //
// //----------------------------------------------//
// int[] CreateRandomArray(int size)
// {
// int[] array =  new int[size];
// for (int i=0; i<size; i++)
//     {
//     array[i] = new Random().Next(100, 1000);
//     }
//     return array; 
// }

// //----------------------------------------------//
// // Метод поиска четных чисел                    //
// //----------------------------------------------//
// int EvenCount(int[] array)
// {
//     int count=0;
//     for(int i=0; i<array.Length; i++)
//         if(array[i]%2==0) count++;       
// return count;
// }



/********************************************************************************/

// //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// //стоящих на нечётных позициях.
// //[3, 7, 23, 12] -> 19
// //[-4, -6, 89, 6] -> 0

// Console.WriteLine();
// Console.WriteLine("Программа, которая получает сумму элементов, стоящих на нечетных позициях массива из случайных чисел.");
// Console.WriteLine();
// Console.Write("Введите размер массива: ");
// string strLength = Console.ReadLine()!; 
// Console.Write("Введите миниальную размерность элемента: 10^");
// string strMinDight = Console.ReadLine()!;
// Console.Write("Введите максимальную размерность элемента: 10^");
// string strMaxDight = Console.ReadLine()!;
// bool parsingLength = int.TryParse(strLength, out var length);
// bool parsindMin = int.TryParse(strMinDight, out var minDight);
// bool parsingMax = int.TryParse(strMaxDight, out var maxDight);
// if ((parsingLength | parsindMin| parsingMax)&&(minDight<9 && maxDight<9))
// {
// int[] arrayToFind = CreateRandomArray(length, minDight, maxDight);
// int res = OddIndexSum(arrayToFind);
// Console.WriteLine($"В массиве случайных чисел: [{string.Join("; ", arrayToFind)}] \nСумма элементов на нечетных позициях = {res}.");
// Console.WriteLine();
// }
// else Console.WriteLine("Неподходящие данные!");

// //----------------------------------------------//
// // Метод формирования массива                   //
// //----------------------------------------------//

// int[] CreateRandomArray(int size, int min, int max)
// {
// int[] array =  new int[size];

// int minNumber = Convert.ToInt32(Math.Pow(10,min)); // просто так, для развлечения 
// int maxNumber = Convert.ToInt32(Math.Pow(10,max));
// for (int i=0; i<size; i++)
//     {
//     array[i] = new Random().Next(minNumber, maxNumber+1);
//     }
//     return array; 
// }

// //----------------------------------------------//
// // Метод поиска суммы по нечетным индексам      //
// //----------------------------------------------//
// int OddIndexSum(int[] array)
// {
//     int sum = 0;
//     for(int i=0; i<array.Length; i++)
//         if(i % 2 != 0) sum += array[i];        
//     return sum;
// }


/********************************************************************************/

// //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// //[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine();
// Console.WriteLine("Программа, которая находит разницу между максимальным и минимальным элементом массива вещественных чисел.");
// Console.WriteLine();
// Console.WriteLine("Введите размер массива: ");
// string strLength = Console.ReadLine()!;
// bool resParsing = int.TryParse(strLength, out var length); 
// if (resParsing)
// {
// double[] arrayToFind = CreateRandomArray(length);
// double res = MaxMinDiff(arrayToFind);
// Console.WriteLine($"В массиве случайных чисел: \n{string.Join("; \n", arrayToFind)} \nразность между максимальным и минимальным элементами = {res}.");
// }
// else Console.WriteLine("Должно быть число!");
// Console.WriteLine();

// //----------------------------------------------//
// // Метод формирования массива                   //
// //----------------------------------------------//
// double[] CreateRandomArray(int size)
// {
// double[] array =  new double[size];
// for (int i=0; i<size; i++)
//     {
//     array[i] = Math.Pow(10,new Random().Next(1,4)) * new Random().NextDouble(); // 10 в произвольной степени умножаю на случайное число не более 1
//     }
//     return array; 
// }

// //----------------------------------------------//
// // Метод поиска суммы по нечетным индексам      //
// //----------------------------------------------//
// double MaxMinDiff(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for(int i=1; i<array.Length; i++)
//     {
//         if(array[i] > max) max = array[i];
//         if(array[i] < min) min = array[i];
//     }
//     double result = max - min;;        
//     return result;
// }
