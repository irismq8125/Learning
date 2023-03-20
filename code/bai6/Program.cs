using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cach 1
            //Console.Write("Nhap vao ngay: ngay = ");
            //string day = Console.ReadLine();
            //Console.Write("Nhap vao thang: thang = ");
            //string month = Console.ReadLine();
            //Console.Write("Nhap vao nam: nam = ");
            //string year = Console.ReadLine();
            //DateTime date = DateTime.Parse(month + "/" + day + "/" + year);

            //cach 2
            Console.Write("Nhap vao ngay ban muon (VD: 03/20/2023). Ngay ban muon la: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            //Hien thi ket qua
            Console.WriteLine("<------------------------------------>");
            Console.WriteLine("Ngay hom qua la: \t{0}", date.AddDays(-1).ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay hom nay la: \t{0}", date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay mai la: \t\t{0}", date.AddDays(1).ToString("dd/MM/yyyy"));
            Console.WriteLine("<------------------------------------>");
            Console.ReadKey();
        }
    }
}
