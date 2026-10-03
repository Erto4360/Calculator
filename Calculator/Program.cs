
using System.Threading;

class Suleymancakır
{
    static void Main()
    {
        while (true)
        {

            Console.WriteLine("");
            Console.WriteLine("---CALCULATOR---");
            Console.WriteLine("");

            Console.WriteLine("Enter the 1st number: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("0-Exit, 1-Addition, 2-Subtraction, 3-Multiplication, 4-Division");
            int islem = Convert.ToInt32(Console.ReadLine());

            int sonuc;

            switch (islem)
            {
                case 0:
                    Console.WriteLine("Goodbye...");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;

                case 1:
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Result: " + sonuc);
                    break;

                case 2:
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Result: " + sonuc);
                    break;

                case 3:
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Result: " + sonuc);
                    break;

                case 4:
                    if (sayi1 < sayi2)
                    {
                        Console.WriteLine("The first number cannot be smaller than the second number");
                        break;
                    }

                    else if (sayi1 == 0 || sayi2 == 0)
                    {
                        Console.WriteLine("You cannot divide by 0");
                        break;
                    }

                    else
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine("Result: " + sonuc);
                        break;
                    }
            }

            {

            }
        }
    }
}
```