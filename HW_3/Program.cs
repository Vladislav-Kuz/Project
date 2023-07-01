// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// Есть еще вариант развернуть массив, выдать его в строку и сравнить начальную и конечную строки

// Console.WriteLine("Введите пятизначное число: ");
// string? value = Console.ReadLine()!;
// int res;
// bool flagDight = int.TryParse(value, out res);
// char[] array = value.ToCharArray();
// //char[] array = value.ToArray<char>();
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