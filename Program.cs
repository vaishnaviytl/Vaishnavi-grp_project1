using System;

namespace Assignment
{
    class Program
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n * n];

            int x = arr.Length - n; //start

            arr[x] = 1;

            printArr(arr, n);

            while (true)
            {
                arr[x] = 0;
                Console.WriteLine("\n");
                Console.WriteLine("enter 2 up 8 down 4 left 6 right ");
                int k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 2: //up
                        if (x >= n)
                            x = x - n;
                        break;

                    case 8: //down
                        if (x < (n * n - n))
                            x = x + n;
                        break;

                    case 4: //left
                        if (x % n != 0)
                            x = x - 1;
                        break;

                    case 6:
                        if (x % n != n - 1) //right
                            x = x + 1;
                        break;

                    default:
                        Console.WriteLine("wrong input");
                        break;

                }
                arr[x] = 1;
                printArr(arr, n);
            }

        }

        public static void printArr(int[] arr, int n)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(arr[i]);
            }
        }

    }
}
