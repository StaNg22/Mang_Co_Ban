using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 4.4.Cho mảng số nguyên gồm n phần tử tùy ý nhập từ bàn phím hoặc file. 
//Nhập thêm giá trị nguyên x và đếm số lần xuất hiện của x trong mảng.
namespace Bài_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] Arr = new int[1000];
            int n = 0;
            int x = 0;
            Console.WriteLine("Vui lòng nhập số phần tử của mảng Arr:");
            n = int.Parse(Console.ReadLine());
            Nhap(n, Arr);
            Xuat(n, Arr);
            Console.WriteLine("Nhập vào giá trị cần xét:");
            x = int.Parse(Console.ReadLine());
            NhapThem(ref n, Arr, x);
            Xuat(n, Arr);
            DemLanXuatHien(n, Arr, x);
        }
        static void Nhap(int n, int[] Arr)
        {
            Console.WriteLine("Vui lòng nhập vào các phần tử:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Arr[{i}] = ");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Xuat(int n, int[] Arr)
        {
            Console.WriteLine("Các phần tử vừa nhập là:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Arr[i]}\t");
            }
            Console.WriteLine();
        }
        static void NhapThem(ref int n, int[] Arr, int x)
        {
            Arr[n] = x;
            n++;
        }
        static void DemLanXuatHien(int n, int[] Arr, int x)
        {
            int dem = 0;
            for (int i = 0;i<=n; i++)
            {
                if (x == Arr[i])
                {
                    dem++;
                }
            }
            Console.WriteLine($"Số lần xuất hiện của {x} trong mảng Arr là : {dem}");
        }
    }
}

