// Домашнее задание №2

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


// Console.Write("Введите трехзначное число: ");
// int numberThreeDight = Convert.ToInt32(Console.ReadLine());
// if (numberThreeDight >= 100 && numberThreeDight < 1000)
// {
//     int result = (numberThreeDight % 100) / 10;
//     Console.WriteLine($"В числе {numberThreeDight} вторая цифра {result}");
// }
// else
// {
//     Console.WriteLine($"Ошибка: число {numberThreeDight} не трехзначное");
// }








// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов

// int result=0;
// int multiplier = 1;
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number>=100)
// {
//     while((number/multiplier)>=100)
//     {
//         multiplier*=10;
//     }  
// result = (number % multiplier)/(multiplier/10);  
// Console.WriteLine($"В числе {number} третья цифра {result}");
// }   
// else
// {
// Console.WriteLine($"В числе {number} третьей цифры нет");
// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
// Console.Write($"Введите день недели: ");
// string[] days = new string[]
// {
// "понедельник", 
// "вторник", 
// "среда", 
// "четверг", 
// "пятница", 
// "суббота", 
// "воскресенье"
// }; 
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if (dayNumber>=1 && dayNumber<=7)
// {
//     if (dayNumber-1 == Array.IndexOf(days, "суббота") || dayNumber-1 == Array.IndexOf(days, "воскресенье"))
//     {
//         Console.Write($"Это выходной - {days[dayNumber-1]}!\n");
//     }
//     else
//     {
//         Console.Write($"Это рабочий день - {days[dayNumber-1]}.\n");
//     }
// }
// else
// {
//     Console.Write($"Введен не день недели\n");    
// }





// ДОПОЛНИТЕЛЬНОЕ ЗАДАНИЕ: Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000. 

// Console.Write("Программа, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000.\n");
// int[] intrestingNumber = new int[10];
// Console.Write($"10 интересных чисел:\n");
// int index = 0;
// while(index < 10)
// {
//     int numberRnd = new Random().Next(10,1000);
//     int firstDight = numberRnd / 100;
//     int secDight = numberRnd / 10 % 10;
//     int thirdDight = numberRnd % 10;
//     int ifInterest = (firstDight * secDight * thirdDight)/(firstDight + secDight + thirdDight);
//     int remainder = (firstDight * secDight * thirdDight)%(firstDight + secDight + thirdDight);
//         if(remainder == 0 && ifInterest >= 1)
//         {
//             intrestingNumber[index] = numberRnd;     
//             index++;
//         }
// }
// for (int n = 0; n < 10; n++)
// {
//     Console.Write($"{intrestingNumber[n]},");    
// }






// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    int Prompt(string message){                // Прекрасная ф-ция для ввода данных
    System.Console.Write(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
 }
 int number = Prompt("Введите число: "); // вызвали ф-цию, которая выдала сообщение message и далее произвела ввод числа, преобразовала его в int и вернула в переменной result
 if (number >= 100 && number < 1000)
 {
     int result = (number % 100) / 10;
     Console.WriteLine($"В числе '{number}' вторая цифра '{result}'"); // такие кавычки из-за свойств класса System, так как данные в юникоде 16
 }
 else
 {
     Console.WriteLine($"Ошибка: число '{number}' не трехзначное");
 }
