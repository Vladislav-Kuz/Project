// // 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// // причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// // в которой находится эта точка.

// Console.Write("Введите координаты точки Х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//     Console.Write("Точка находится в 1 четверти");
// }
// if (x < 0 && y > 0)
// {
//     Console.Write("Точка находится во 2 четверти");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в 3 четверти");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в 4 четверти");
// }
// else
// {
//     Console.WriteLine("Точка попала на ось координат");
// }


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите координаты точки А: \n");
// int xa = Convert.ToInt32(Console.ReadLine());
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки B: \n");
// int xb = Convert.ToInt32(Console.ReadLine());
// int yb = Convert.ToInt32(Console.ReadLine());
// int ac = (xb-xa);
// int bc = (yb-ya);
// double ab = Math.Round(Math.Sqrt ((Math.Pow(ac,2) + Math.Pow(bc,2))),3);
// Console.WriteLine($"Расстояние межу А и В равно: {ab}");



// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4



        //     int number = Convert.ToInt32(Console.ReadLine());
        //     for (int i = 0; i <= number; i++) 
        //     {
        //         Console.WriteLine(Math.Pow(i,2 ));
        //     }
            
        // }



Console.Write("Введите число: \n");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N+1];

void Power(double[] arrayFill, int n)
{
    int i;
    for (i = 0 ; i< n+1 ; i++)
    {
        double result =  Math.Pow(i,2);
        arrayFill[i] = result;
        Console.WriteLine($"Числу {i} соответствует его квадрат {arrayFill[i]}, ");
    }
}

Power(array, N);

int Prompt(string message)
{
	Console.Write(message);
	string number = Console.ReadLine();
	int intNumber = Convert.ToInt32(number);
	return intNumber;
}
		
void Power(int n)
{
    int i;
	double[] arrayFill = new double[n+1];
    for (i = 0 ; i< n+1 ; i++)
    {
        double result =  Math.Pow(i,2);
        arrayFill[i] = result;
    	Console.WriteLine($"Числу {i} соответствует его квадрат {arrayFill[i]}, ");    
    }	
}

int N = Prompt("Введите число: ");
Power(N);

