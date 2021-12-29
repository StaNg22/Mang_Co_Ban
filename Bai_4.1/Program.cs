using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 4.1.Nhập vào số dương n và một mảng các phần tử từ arr[0] đến arr[n - 1]. 
//Hãy tìm giá trị lớn nhất và nhỏ nhất trong mảng trên.
namespace Bai_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] Arr = new int[1000];
            int n = 0;
            int Max = 0;
            int Min = 0;
            Console.WriteLine("Nhập vào số phần tử Của Arr:");
            n = int.Parse(Console.ReadLine());
            Nhap(n, Arr);
            Xuat(n, Arr);
            GiaTriLonNhat(n,Arr,Max);
            GiaTriNhoNhat(n,Arr,Min);
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
        static void Xuat(int n ,int[] Arr) 
        {
            Console.WriteLine("Mảng vừa nhập là:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Arr[i]}\t");
            }
            Console.WriteLine();
        }
        static void GiaTriLonNhat(int n , int[] Arr, int max)
        {
            max = Arr[0];
            
            for (int i = 1; i < n; i++)
            {
                if (max < Arr[i])
                {
                    max = Arr[i];
                }
            }
            Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
        }
        static void GiaTriNhoNhat(int n, int[] Arr, int min)
        {
            min = Arr[0];

            for (int i = 1; i < n; i++)
            {
                if (min > Arr[i])
                {
                    min = Arr[i];
                }
            }
            Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {min}");
        }
    }
}
