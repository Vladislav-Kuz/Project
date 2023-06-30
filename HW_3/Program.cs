// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// принять строку, 
// записать в массив
// проверить число или символ?
// сравнение

int Prompt(string message){                // Прекрасная ф-ция для ввода данных
     System.Console.Write(message);
     string value = Console.ReadLine();
     int result = Convert.ToInt32(value);
     return result;
    }

void FillArray(int[] collection){
    int length = collection.Length;
    int index=0;
    while(index<length){
        string value = Console.ReadLine();
        collection[index] = 
    }
}
int number = Prompt("Введите пятизначное число: "); 

int i;
for(i = 0; i < length; i++){
    if(array[i]!=array[length-i]){
        Console.WriteLine("Не палиндром");
    }
}
Console.WriteLine("Палиндром");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125