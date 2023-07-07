// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int size = 12;
// int[] array = new int[size];

// int sumPositive = 0; // Сумма полож. чисел
// int sumNegative = 0; // Сумма отрц. чисел

// for (int i = 0; i < size; i++) // array.Length = size
// {
//     array[i] = new Random().Next(-9, 10);
//     if (array[i] > 0) // Число в массиве положительное, ищем сумму пол. чисел
//     {
//         sumPositive += array[i]; // sumPositive = sumPositive + array[i]
//     }
//     else // отрц. и ноль
//     {
//         sumNegative += array[i]; // sumNegative = sumNegative + array[i]
//     }
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Сумма пол. чисел: {sumPositive}, сумма отц. чисел: {sumNegative}");



// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// синтаксис метода: тип_возр_знач ИмяМетода (параметр1, параметр2)
// size - размер массива, min - минимальное число в рандоме, max - максимальное
// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size]; // Массив на size элементов
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1); 
//     }

//     return result; // Массив, который заполнили числами в диапазоне от min до max
// }
// // Массив на 7 элементов, каждый элемент - число от 0 до 10 (рандомное)
// int[] array = GetArray(7, 0, 10); // size = 10, min = 0, max = 10
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");




// int[] ReverseArray(int[] array) // Метод берет массив и заменяет элементы на противоположные 
// {
//     for (int i = 0; i < array.Length; i++) // array.Length - длина массива
//     {
//         array[i] *= -1; // array[i] = array[i] * -1
//     }
//     return array;
// }
// Console.WriteLine($"Перевертыш: [ {string.Join("; ", ReverseArray(array))} ]");





// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// if (array.Length % 2 == 1)
// {
//     size++;
// }
// int[] result = new int[size];


int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size]; // Массив на size элементов
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1); 
    }

    return result; // Массив, который заполнили числами в диапазоне от min до max
}


int[] array = GetArray(7, 0, 10); // size = 10, min = 0, max = 10
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");

// PascalCase - для методов, каждое слово в вашей переменной идет с большой буквы
// camelCase - первая буква - маленькая, остальные - заглавные

int[] MultiplyingArrays (int[] array)
{
    int sizeNewArray = array.Length / 2 + array.Length % 2; 

    int[] newArray = new int[sizeNewArray];
    // i - номер элемента с левого края (первого элемента)
    // j - номер элемента с правого края (последний элемент массива)
    for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
    {
        newArray[i] = array[i] * array[j];
    }

    if(array.Length % 2 == 1) // Размер массива - нечетное число
    {
        newArray[sizeNewArray - 1] = array[array.Length / 2];
    }

    return newArray;
} 

Console.WriteLine($"Результат: [ {string.Join("; ", MultiplyingArrays(array))} ]");