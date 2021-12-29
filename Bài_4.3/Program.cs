using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 4.3.Cho số dương n và mảng arr gồm n số nguyên tùy ý. Hãy:
//a) Sắp xếp các phần tử trong mảng này theo thứ tự tăng dần từ trái qua phải
//b) Sắp xếp các phần tử trong mảng này theo thứ tự giảm dần từ trái qua phải
//c) Hiển thị kết quả trước và sau sắp xếp
namespace Bài_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] Arr = new int[1000];
            int n = 0;
            Console.WriteLine("Vui lòng nhập số phần tử của mảng Arr:");
            n = int.Parse(Console.ReadLine());
            Nhap(n, Arr);
            Xuat(n, Arr);
            MangTang(ref Arr, n);
            Console.WriteLine("Mảng Arr được tăng dần là:");
            Xuat(n, Arr);
            Console.WriteLine("Mảng Arr đước giảm dần là:");
            MangGiam(ref Arr, n);
            Xuat(n, Arr);
        }
        static void MangGiam(ref int[] arr, int n)
        {
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void MangTang(ref int[] arr, int n)
        {
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void Nhap(int n, int[] Arr)
        {
            Console.WriteLine("Nhập vào các phần tử của mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Arr[{i}] = ");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Xuat(int n, int[] Arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Arr[i]}\t");
            }
            Console.WriteLine();
        }
       
    }
}
