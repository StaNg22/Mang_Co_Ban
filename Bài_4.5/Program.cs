using System;
using System.Text;
//Bài 4.5.Cho mảng số nguyên gồm n phần tử tùy ý. Hãy nhập giá trị nguyên x nào 
//đó và xác định phần tử có giá trị gần x nhất. Giá trị k nào đó gọi là gần x nhất nếu 
//|k - x| gần với 0 nhất.
namespace Bài_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr;
            int[] arr1;
            int n = 0;
            int x = 0;
            n = SoLuong();
            arr = new int[n];
            Console.WriteLine("Nhập vào các phần tử:\n");
            arr = NhapMang(n);
            Console.WriteLine("Mảng vừa nhập là:");
            XuatMang(arr);
            Console.WriteLine("Nhập giá trị cần xét:");
            x = int.Parse(Console.ReadLine());
            GiaTriTuyetDoi(out arr1, arr, x);
            Console.WriteLine($"Giá trị gần {x} là:");
            GiaTriGanNhat(arr1, arr, n);
        }
        static void GiaTriGanNhat(int[] arr1, int[] arr, int n)
        {
            int temp = min(arr1);
            int temp1 = 0;
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr1[i] == temp)
                {
                    if (temp1 != arr[i] && dem != 2)
                    {
                        Console.Write($"{arr[i]}  ");
                        temp1 = arr[i];
                        dem++;
                    }
                    if (dem == 2)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
        static void GiaTriTuyetDoi(out int[] arr1, int[] arr, int x)
        {
            arr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = Math.Abs(arr[i] - x);
            }
        }
        static int min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
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
            for (int i = 0; i < n; i++)
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
                Console.WriteLine("Nhập vào số lượng:");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
    }
}
