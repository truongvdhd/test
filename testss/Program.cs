using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testss
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int dem = 1, l = 0;
            Console.Write("Nhap chuoi: ");
            str = Console.ReadLine();
            while (l <= str.Length - 1)
            {
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    dem++;
                }
                l++;
            }
            Console.Write("So tu trong chuoi la: {0}", dem);
            Console.ReadKey();
        }
    }
}
