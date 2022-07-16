using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * аналог array[i].Length - із Java:
             * 
             * ar.GetLength(0) - що б отримати довжину масиву в першому вимірі
             * ar.GetLength(1) - що б отримати довжину масиву в другому вимірі
             * ar.GetLength(2) - що б отримати довжину масиву в третьому вимірі
             */


            //Example1();
            //Example2();
            //Example3_Use6DArray();
        }
        static void Example1()
        {
            int[,] myArray = new int[3, 3];
            int count = 1;
            for(int i = 0; i < 3; i++)
            {
                for (int j=0;j<3;j++)
                {
                    myArray[i, j] = count++;
                }
            }
            Console.WriteLine("2D array:");
            for (int i =0;i < 3;i++)
            {
                for (int j =0;j<3;j++)
                {
                    Console.Write($"|{myArray[i,j]}");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine();
        }
        static void Example2()
        {
            int[,,] ar = new int[3,3,3];
            int count = 10;
            for (int i = 0;i<3;i++)
            {
                for (int j = 0;j<3;j++)
                {
                    for (int t = 0;t<3;t++)
                    {
                        ar[i, j, t] = count++;
                    }
                }
            }
            for (int i = 0;i<3;i++)
            {
                for (int j = 0;j<3;j++)
                {
                    for (int t = 0;t<3;t++)
                    {
                        Console.Write($"|{ar[i,j,t]}");
                    }
                    Console.Write("|  ");
                }
                Console.WriteLine();
            }
        }
        static void Example3_Use6DArray()
        {
            int[,,,,,] ar = new int[3, 3, 3, 3, 3, 3];
            int count = 100;
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    for (int t = 0; t < ar.GetLength(2); t++)
                    {
                        for (int y = 0; y < ar.GetLength(3); y++)
                        {
                            for (int r = 0; r < ar.GetLength(4) ;r++)
                            {
                                for (int u = 0; u < ar.GetLength(5); u++)
                                {
                                    ar[i, j, t, y, r, u] = count++;
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    for (int t = 0; t < ar.GetLength(2); t++)
                    {
                        for (int y = 0; y < ar.GetLength(3); y++)
                        {
                            for (int r = 0; r < ar.GetLength(4); r++)
                            {
                                for (int u = 0; u < ar.GetLength(5); u++)
                                {
                                    Console.Write($"|{ar[i,j,t,y,r,u]}");
                                }
                                Console.Write("| ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

    }
}
