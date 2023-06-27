/* Домашнее задание №1 */


// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


// Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
// Console.WriteLine("Для начала нажмите ENTER");
// while (Console.ReadKey().Key != ConsoleKey.Enter) {}
// Console.Write("Введите 1-е число: ");
// double firstNumber = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите 2-е число: ");
// double secondNumber = Convert.ToDouble(Console.ReadLine());

// if (firstNumber > secondNumber){
// Console.WriteLine("Первое число ("+ firstNumber + ") больше второго (" + secondNumber + ").");   
// }
// else 
// if(firstNumber < secondNumber){
// Console.WriteLine("Второе число ("+ secondNumber + ") больше первого (" + firstNumber + ").");
// }
// else Console.WriteLine("Числа равны!");
// Console.WriteLine("Для выхода нажмите ESCAPE");
// while (Console.ReadKey().Key != ConsoleKey.Escape) {};



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
int sizeArray = 3;
double[] numbers = new double[sizeArray];
Console.WriteLine("Программа, которая на вход принимает три числа и выдаёт максимальное.");
Console.WriteLine("Для начала нажмите ENTER");
while (Console.ReadKey().Key != ConsoleKey.Enter) {}
int count = 0;      // обнуляем счетчик для ввода чисел в массив
while(count<3){
    Console.Write("Введите "+ (count+1) +"-е число: ");
    numbers[count] = Convert.ToDouble(Console.ReadLine());
    count++;
   }
   count=0;         // обнуляем счетчик для основного цикла
   double max = numbers[0];     // принимаем первый элемент за максимум
while(count<3){
    if (numbers[count] >= max){
        max = numbers[count];
        }
    count++;
    }
Console.WriteLine("Максимальное число равно " + max + ".");
Console.WriteLine("Для выхода нажмите ESCAPE");
while (Console.ReadKey().Key != ConsoleKey.Escape) {};

*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Программа, которая на вход принимает число и выдаёт. является ли оно четным");
Console.WriteLine("Для начала нажмите ENTER");
while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
    if(number%2 == 0)
    {
        Console.Write("Число " + number + " является четным");       
    }
    else 
    {
        Console.WriteLine("Число " + number + " нечетное");
    }
Console.WriteLine("Для выхода нажмите ESCAPE");
while (Console.ReadKey().Key != ConsoleKey.Escape) {};

*/


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.WriteLine("Программа, которая на вход принимает число N и выдаёт четные от 1 до N");
Console.WriteLine("Для начала нажмите ENTER");
while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
int j=0;
int[] numbers = new int[N-1]; 
Console.WriteLine("Четные значения в диапазоне от 1 до N: ");
while(i<=N && j<(N-1)) 
{
    if(i%2 == 0)
    {
        numbers[j]=i; 
        
        Console.Write($"{numbers[j]}; ");       
    }
    i++;
    j++;    
}  

*/        
        
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i=1; // про четные мы знаем, что после нуля первое четное 2
int even=0; // создали счетчик четных чисел
Console.WriteLine("Четные значения в диапазоне от 1 до N: ");
while(i<=N) // запускаем цикл со счетчиком до N включительно
{
    if(i%2 == 0) // если счетчик, он же число, делится на 2
    {      
        even = i;  // то записываем число в переменную "четное"
        Console.Write(even + "; "); //выводим переменную 
    }
    i++; // после проверки прибавляем счетчик для взятия следующего числа
}        
     
