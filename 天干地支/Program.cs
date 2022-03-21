using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 天干地支
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "甲己乙丙丁戊己庚辛壬癸";
            string b = "子丑寅卯辰巳午未申酉戌亥";
            int x = 0;
            int y = 0;
            int year = 0;
            string[] value = new string[60];
            int valuei = 0;
            Console.Write("請輸入西元年:");
            year = Convert.ToInt32(Console.ReadLine());   //輸入字元變數字

            if (year >= 0)
            {
                for (int i = 0; i < 60; i++)
                {
                    Console.WriteLine(Convert.ToString(a[x]) + Convert.ToString(b[y]));
                    if (++x >= a.Length) x = 0;
                    if (++y >= b.Length) y = 0;
                }
                if (year > 60)
                {
                    valuei = (year - 4) % 60;
                }
                else if (year < 4)
                {
                    valuei = year + 56;
                }
                else
                {
                    valuei = year - 4;
                }

                Console.ReadLine();
            }
        }
    }
}
