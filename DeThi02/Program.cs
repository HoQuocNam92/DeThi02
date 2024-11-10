using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThietBi ThietBiDienTu = new ThietBiDienTu("TH0002" , "May Ui" , 2022 ,100000 , 0.06 , 12 );
            ThietBiDienTu.Xuat();
            ThietBi ThietBiGiaDung = new ThietBiGiaDung("TH0001", "May say toc", 2019, 200000, 0.02, "Nhua");
            ThietBiGiaDung.Xuat();
            ThietBi ThietBiGiaoDuc = new ThietBiGiaoDuc("TB0003", "But Chi", 2019, 200000, 0.02, 12);
            ThietBiGiaoDuc.Xuat();
        }
    }
}
