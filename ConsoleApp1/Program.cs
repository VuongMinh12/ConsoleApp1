using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Mảng 1 chiều
            int[] one = new int[4] { 4, 7, 2, 1 };
            Console.WriteLine(one[1]);

            // Mảng 2 chiều gồm mảng có 3 dòng và 4 cột
            int[,] two = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 4, 5, 6, 7 },
                { 8, 9, 10, 11 }
            };
            Console.WriteLine(two[1,1]);


            //// Sắp xếp mảng nhập
            //int[] array = new int[10];
            //int i, n, j, tmp;
            //Console.WriteLine("Nhap kich thuoc cua mang <=10: ");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("Phan tu - {0}: ", i);
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (i = 0; i < n; i++)
            //{
            //    for (j = i + 1; j < n; j++)
            //    {
            //        if (array[j] < array[i])
            //        {
            //            //cach trao doi gia tri
            //            tmp = array[i];
            //            array[i] = array[j];
            //            array[j] = tmp;
            //        }
            //    }
            //}
            //Console.Write("\nIn cac phan tu mang theo thu tu tang dan:\n");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("{0}  ", array[i]);
            //}
            //// Sắp xếp mảng giảm dần
            //for (i = 0; i < n; i++)
            //{
            //    for (j = i + 1; j < n; j++)
            //    {
            //        if (array[j] > array[i])
            //        {
            //            //cach trao doi gia tri
            //            tmp = array[i];
            //            array[i] = array[j];
            //            array[j] = tmp;
            //        }
            //    }
            //}
            //Console.Write("\nIn cac phan tu mang theo thu tu giam dan:\n");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("{0}  ", array[i]);
            //}
            //Console.ReadKey();



            // Sắp xếp mảng cho sẵn
            int[] array = new int[5] { 4, 1, 9, 7, 8 };
            
            int n = array.Length;
            int i, j, tmp;
            Console.WriteLine("Mang gom cac so: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (array[j] < array[i])
                    {
                        tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;
                    }
                }
            }
            Console.WriteLine("\nMang sap xep theo thu tu tang dan:");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            // giam dan
            for (i = 0; i < n - 1; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (array[j] > array[i])
                    {
                        tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;
                    }
                }
            }
            Console.WriteLine("\nMang sap xep theo thu tu giam dan:");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
            Console.ReadKey();


            //So sánh 2 mảng
            int[] ar1 = new int[4] { 1, 2, 3, 7 };
            int[] ar2 = new int[4] { 1, 2, 3, 9 };
            if (ar1.Length != ar2.Length)
            {
                Console.WriteLine("Do dai 2 mang khac nhau, khong the so sanh");
            }
            else
            {
                for (int x = 0; x < ar1.Length; x++)
                {
                    if (ar1[x] != ar2[x])
                    {
                        Console.WriteLine("2 mang nay khac nhau!");
                        break;
                    }
                    else if (x == ar1.Length - 1)
                    {
                        Console.WriteLine("2 mang nay giong nhau!");
                        break;
                    }
                }
            }
            Console.ReadKey();


            //Sắp xếp mảng 2 chiều
            int[,] arr2 = {
            { 5, 2, 9 },
            { 1, 8, 3 },
            { 7, 4, 6 }
            };
            int row  = arr2.GetLength(0);
            int col = arr2.GetLength(1);

            for (int u = 0; u < col; u++)
            {
                int[] colArray = new int[row];
                for (int y = 0; y < row; y++)
                {
                    colArray[y] = arr2[y, u];
                }
                Array.Sort(colArray);

                for (int y = 0; y < row; y++)
                {
                    arr2[y, u] = colArray[y];
                }
            }


            for (int y = 0;y < row; y++)
            {
                for (int u = 0; u < col; u++)
                {
                    Console.Write(arr2[y, u] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
