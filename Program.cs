using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_thực_hành_số_2_ngày_21_tháng_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.Write("nhập vào số a:");
             //   int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("nhập vào số b:");
             //   int b = Convert.ToInt32(Console.ReadLine());
            //double d = a / b;
            //Console.Write("kết quả:" + Convert.ToString(d));
          //Console.ReadLine();

            Console.Write("nhập vào số a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhập vào số b:");
            int b = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToDouble(a)/Convert.ToDouble(b);
            Console.Write("kết quả:" + Convert.ToString(d));
            Console.ReadLine();
        }
    }
}
