// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
// заменить большими «К», а большие «С» заменить на маленькие «с».


// string text = "— Я думаю, — сказал Князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, \n"
//             + "вы бы взяли приступом согласие прусского Короля. \n"
//             + "Вы так красноречивы. Вы дадите мне чаю? \n";
            
// Console.Write(text);
// Console.WriteLine();
// // Создадим метод, заменяющий символы

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for(int i=0; i<length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText1 = Replace(text, ' ', '/');
// //Console.Write(newText1);

// string newText2 = Replace(newText1, 'с', 'С');
// //Console.Write(newText2);

// string newText = Replace(newText2, 'К', 'к');
// Console.Write(newText);
// Console.WriteLine();

/**********************************************************************************/

// Упорядочивание данных внутри массива. 
// Алгоритм сортировки методом выбора, ещё его называют алгоритм сортировки методом минимакса или
// иногда просто называют методом максимального, или выбора максимального или выбора
// минимального и так далее. 
// Есть какая-то последовательность чисел. Наша задача — выбрать самый первый элемент и в оставшейся
// части, с учётом нашей текущей позиции определить минимальный. После того как он найден,
// нужно поменять выделенный (рабочий элемент), на который сейчас указывает стрелочка, это
// 6, с единицей, являющейся для нас минимальной, в общем, выделенном куске.

// создадим массив
// int[] arr = {1, 5, 4, 2, 6, 7, 8, 1};

// // создаем метод для вывода массива в консоль
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine();
// }
// PrintArray(arr);

// // создаем метод, упорядочивающий массив
// void Sorting(int[] array)
// {
//     for(int i = 0; i < array.Length-1; i++)
//     {
//             int minPosition = i;
//         for(int j= i+1; j < array.Length; j++)
//         {
//                 if(array[j] < array[minPosition])
//             //if(array[j] < array[i])
//             {
//                     minPosition = j;
//                     int temp = array[i];
//                     array[i] = array[minPosition];
//                     array[minPosition] = temp;
//                 //int temp = array[i];
//                 //array[i] = array[j];
//                 //array[j] = temp;
//             }
//         }
//     }
// }
// // запускаем работу функций
// Sorting(arr);
// PrintArray(arr);


/*********************************/

/*  ==== Та же задача, только через максимум */
// Я не понимаю, в чем разница, ведь переменная, куда мы кладем значения условная и меняется - она может быть и больше и меньше

// создадим массив
int[] arr = {1, 5, 4, 2, 6, 7, 8, 1};

// создаем метод для вывода массива в консоль
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
PrintArray(arr);

// создаем метод, упорядочивающий массив
void Sorting(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
            int maxPosition = i;
        for(int j= i+1; j < array.Length; j++)
        {
                if(array[j] < array[maxPosition])
            //if(array[j] < array[i])
            {
                    maxPosition = j;
                    int temp = array[i];
                    array[i] = array[maxPosition];
                    array[maxPosition] = temp;
                //int temp = array[i];
                //array[i] = array[j];
                //array[j] = temp;
            }
        }
    }
}
// запускаем работу функций
Sorting(arr);
PrintArray(arr);