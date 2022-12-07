//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = SetNumber("N");

int[] arr = CubeTable[n];
{
    int[] arr = new int[n];

    for (int i = 1; i<= num; i++)
    {
        arr[i - 1] = i * i * i;
    }
    return arr;
}

System.Console.WriteLine(string.Join(","), arr);