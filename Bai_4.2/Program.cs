using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 4.2.Cho mảng số nguyên gồm n phần tử được nhập vào từ bàn phím hoặc 
//file. Hãy tìm phần tử thỏa mãn:
//a) Là giá trị lớn thứ hai trong mảng
//b) Là giá trị nhỏ thứ hai trong mảng
//Quy ước rằng nếu min trùng max hoặc min2 trùng max2 thì không có giá trị thỏa mãn.
namespace Bai_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] Arr = new int[1000];
            int n = 0;
            int min2 = 0;
            int max2 = 0;
            Console.WriteLine("Nhập vào số phần tử của mảng Arr:");
            n = int.Parse(Console.ReadLine());
            Nhap(n, Arr);
            Xuat(n, Arr);
            if (Max(n, Arr) == Min(n, Arr))
            {
                Console.WriteLine("Không có giá trị thỏa mãn.\n");
            }
            else
            {
                Console.WriteLine($"Giá trị lớn nhất của mảng Arr là: {Max(n,Arr)}\n");
                Console.WriteLine($"Giá trị nhỏ nhất của mảng Arr là: {Min(n, Arr)}\n");
            }
            min2 = Min2(Arr, n);
            max2 = Max2(Arr, n);
            if (max2 == min2)
            {
                Console.WriteLine("Không có giá trị thỏa mãn.\n");
            }
            else
            {
                Console.WriteLine($"Giá trị lớn thứ 2 của mảng Arr là: {max2}\n");
                Console.WriteLine($"Giá trị nhỏ thứ 2 của mảng Arr là: {min2}\n");
            }


        }
        static int Min2(int[] arr, int n)
        {
            XoaPTNhoNhat(arr, ref n);
            return Min(n, arr);
        }
        static void XoaPTNhoNhat(int[] arr, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (Min(n, arr) == arr[i])
                {
                    XoaPTTaiViTri(arr, ref n, i);
                    break;
                }
            }
        }
        static int Max2(int[] arr, int n)
        {
            XoaPTLonNhat(arr, ref n);
            return Max(n, arr);
        }
        static void XoaPTLonNhat(int[] arr, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
               if (Max(n, arr) == arr[i])
               {
                    XoaPTTaiViTri(arr, ref n, i);
                    break;
               }
            }
        }
        static void XoaPTTaiViTri(int[] arr,ref int n, int x)
        {
            for (int i = x; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            n--;
        }
        static void Nhap(int n ,int[] Arr)
        {
            Console.WriteLine("Mời nhập vào phần tử của mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Arr[{i}] = ");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Xuat(int n, int[] Arr)
        {
            Console.WriteLine("Phần tử của mảng vừa nhập là:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Arr[i]}\t");
            }
            Console.WriteLine();
        }
        //A
        static int Max(int n,int[] Arr)
        {
            int max = Arr[0];
            for (int i = 1; i < n; i++)
            {
                if (max < Arr[i])
                {
                    max = Arr[i];
                }
            }
            return max;
        }
        static int Min(int n, int[] Arr)
        {
            int min = Arr[0];
            for (int i = 1; i < n; i++)
            {
                if (min > Arr[i])
                {
                    min = Arr[i];
                }
            }
            return min;
        }
    }
}
