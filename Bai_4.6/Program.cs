using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bài 4.6.Cho mảng số nguyên gồm n phần tử tùy ý nhập từ bàn phím hoặc file. 
//Tính trung bình cộng các số chẵn, các số lẻ trong dãy. In kết quả ra màn hình hoặc 
//file.
namespace Bai_4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr;
            int n = 0;
            double TBC = 0;
            double TBL = 0;
            n = SoLuong();
            Console.WriteLine("Nhập vào các phần tử:");
            arr = NhapMang(n);
            Console.WriteLine("Mảng vừa nhập là:");
            XuatMang(arr);
            TBC = Math.Round(TrungBinhCongSoChan(arr), 2);
            TBL = Math.Round(TrungBinhCongSoLe(arr), 2);
            Console.WriteLine($"Trung bình cộng các số chãn của mảng arr là: {TBC}");
            Console.WriteLine($"Trung bình cộng các số lẻ của mảng arr là: {TBL}");
        }
        static double TrungBinhCongSoLe(int[] arr)
        {
            int dem = 0;
            double TB = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    TB += (double)arr[i];
                    dem++;
                }
            }
            return TB / (double)dem; 
        }
        static double TrungBinhCongSoChan(int[] arr)
        {
            int dem = 0;
            double TB = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    TB += (double)arr[i];
                    dem++;
                }
            }
            return TB/(double)dem;
        }
        static void XuatMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine();
        }
        static int[] NhapMang(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static int SoLuong()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Nhập vào số lượng của mảng:");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
    }
}
