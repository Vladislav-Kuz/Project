
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите целое число");
// //Console.WriteLine("Число " + int.Parse(Console.ReadLine()!));
// // int parseNumber = int.Parse(Console.ReadLine()!);
// int limit = int.Parse(Console.ReadLine()!);
// int sum=0;
// //int[] array = value.ToArray();
// // //char[] array = value.ToArray<char>(); // можно таким методом
// // int length = array.Length;
// for (int i = 1; i <= limit; i++)
// {
//     sum+=i;
// }
// Console.WriteLine($"Сумма числа {limit} = {sum}");



// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите целое число");
// int numberParse = int.Parse(Console.ReadLine()!);
// int number = numberParse;
// int count = 0;
// if (numberParse != 0){
// while(number>0){
//     count++;
//     number/=10;
// }
// }
// else{
//     count++;
// }
// Console.WriteLine($"в числе {numberParse} количество цифр: {count}");




// Задача 28 - Найдите факториал числа

// Console.WriteLine("Введите целое число");
// int numberParse = int.Parse(Console.ReadLine()!);
// int N = numberParse;
// int result = 1;
// for(int i =1; i<=N; i++){
//     result*=i;
// }
// Console.WriteLine($"Факториал числа !{numberParse} = {result}");




      
        
// Console.Write("Введите целое число: ");
// int numberParse = int.Parse(Console.ReadLine()!);
// int N = numberParse;
// int factorial = Factorial(N);
// Console.WriteLine($"Факториал числа !{numberParse} = {factorial}");

//   int Factorial(int n)
//         {
//         if (n==1)
//         {
//             return 1;
//         }     
//         return n*Factorial(n - 1);
//         }





// Нужно заполнить массив из 8-ми элементов случайными нулями и единицами
// int size = 8;
// int[] array = new int[size];
// int length = array.Length;
// for(int i = 0; i < length; i++)
// {
//   array[i] = new Random().Next(2); // от 0 включительно до 2 не включительно, можно Next(0,2)
//   //Console.WriteLine(array[i]);
// }
// Console.WriteLine($"[{string.Join("; ", array)}]");