    Console.Write("Введите переменную A");
int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите переменную B");
    int b = Convert.ToInt32(Console.ReadLine());
    int b2 = b;
            int a2 = a;
            Console.Write(a);
            // for(;b>1;b--)
    while (b > 1)
    {
      b = b - 1;
      a = a * a2;
      Console.WriteLine(a);
    }
      
            /*{
                a = a * a2;
            }*/
            Console.WriteLine(" в степени " + b2 + " = " + a);