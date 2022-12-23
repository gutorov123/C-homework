using System;
					
public class Program
{
	public static void Main()
	{
		// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
		// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
		// M = 4; N = 8. -> ""4, 6, 7, 8""
		
		void PrintInterval(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			for(int i = start; i <= end; i++)
			{
				Console.Write($"{i} ");
			}
		}
		PrintInterval(22, 9);
		
		Console.WriteLine();
		
		// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
		// M = 1; N = 15 -> 120
		// M = 4; N = 8. -> 30
		
		int CalculateSumm(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2; // по формуле суммы членов арифметической прогрессии
		}
		
		Console.WriteLine(CalculateSumm(72, 16));
	}
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}