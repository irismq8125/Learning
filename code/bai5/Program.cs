using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    struct ThongTinNhanVien
    {
        public string hoTen { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public float HSL { get; set; }
        public int LCB { get; set; }
        public int soNam { get; set; }
        public int PC { get; set; }
        public int tamTinh { get; set; }
        public int Luong { get; set; }

        //Ham khoi tao co tham so dau vao
        public ThongTinNhanVien(string ten, string gt, DateTime ns, float hsl, int lcb, int sonam)
        {
            this.hoTen = ten;
            this.gioiTinh = gt;
            this.ngaySinh = ns;
            this.HSL = hsl;
            this.LCB = lcb;
            this.soNam = sonam;
            this.PC = sonam >= 5 ? lcb / 2 : 0;
            this.tamTinh = (int)Math.Ceiling(this.LCB * this.HSL);
            this.Luong = this.tamTinh + this.PC;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai bao he so luong
            const float HSL = 2.34f;

            //khai bao thong tin nhan vien 1
            string hoTen1 = "Luong Van Luong";
            string gioiTinh1 = "Nam";
            DateTime ngaySinh1 = DateTime.Parse("02/12/2023");
            int LCB1 = 2500000;
            int soNam1 = 4;

            //khai bao thong tin nhan vien 2
            string hoTen2 = "Nguyen Van Luyen";
            string gioiTinh2 = "Nam";
            DateTime ngaySinh2 = DateTime.Parse("03/12/2023");
            int LCB2 = 2500000;
            int soNam2 = 6;

            ThongTinNhanVien nv1 = new ThongTinNhanVien(hoTen1, gioiTinh1, ngaySinh1, HSL, LCB1, soNam1);
            Console.WriteLine("Thong tin nhan vien 1:\n" +
                                    "Ho ten: \t{0}\n" +
                                    "Gioi tinh: \t{1}\n" +
                                    "Ngay sinh: \t{2}\n" +
                                    "LCB:\t\t{3}\n" +
                                    "HSL:\t\t{4}\n" +
                                    "So nam:\t\t{5}\n" +
                                    "Phu cap:\t{6}\n" +
                                    "Tam tinh:\t{7}\n" +
                                    "Tien luong: \t{8}"
                                    , nv1.hoTen, nv1.gioiTinh, nv1.ngaySinh.ToString("dd/MM/yyyy"),
                                    nv1.LCB, nv1.HSL, nv1.soNam, nv1.PC, nv1.tamTinh, nv1.Luong);
            Console.WriteLine("----------------------------------------");

            ThongTinNhanVien nv2 = new ThongTinNhanVien(hoTen2, gioiTinh2, ngaySinh2, HSL, LCB2, soNam2);
            Console.WriteLine("Thong tin nhan vien 2:\n" +
                                    "Ho ten: \t{0}\n" +
                                    "Gioi tinh: \t{1}\n" +
                                    "Ngay sinh: \t{2}\n" +
                                    "LCB:\t\t{3}\n" +
                                    "HSL:\t\t{4}\n" +
                                    "So nam:\t\t{5}\n" +
                                    "Phu cap:\t{6}\n" +
                                    "Tam tinh:\t{7}\n" +
                                    "Tien luong: \t{8}"
                                    , nv2.hoTen, nv2.gioiTinh, nv2.ngaySinh.ToString("dd/MM/yyyy"),
                                    nv2.LCB, nv2.HSL, nv2.soNam, nv2.PC, nv2.tamTinh, nv2.Luong);
            Console.ReadKey();
        }
    }
}
