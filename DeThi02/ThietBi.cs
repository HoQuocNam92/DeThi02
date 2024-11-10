using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi02
{
    public abstract class ThietBi
    {
        string maThietBi;
        string tenThietBi;
        int namSanXuat;
        double giaBan;
        double hoaHong;
        static public double tiLeThue = 0.08;
        public string MaThietBi
        {
            get { return maThietBi; }
            set {
                if (value.Length == 6 && value.StartsWith("TB") && int.TryParse(value.Substring(2), out _)) {
                    maThietBi = value;
                }
                else
                {
                    maThietBi = "TB0001";
                }
            }
        }
        public string TenThietBi
        {
            get { return tenThietBi; }
            set { tenThietBi = value; }
        }
        public int NamSanXuat
        {
            get { return namSanXuat; }
            set { namSanXuat = value; }
        }
        public double GiaBan { get { return giaBan; }
            set { if (value >= 0)
                { giaBan = value; }
                else { giaBan = 0; }
            }
        }
        public double HoaHong
        {
            get { return hoaHong; }
            set { hoaHong = value; }
        }
        public ThietBi()
        {
            maThietBi= "TB0001";
            tenThietBi = "May xuc dat";
            NamSanXuat = 2024;
            GiaBan = 10000;
            HoaHong = 0.04;

        }
        public ThietBi(string maThietBi, string tenThietBi, int namSanXuat, double giaBan, double hoaHong)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;
            NamSanXuat = namSanXuat;
            GiaBan = giaBan;
            HoaHong = hoaHong;
        }
        public double thueSanXuat()
        {
            return GiaBan * tiLeThue;
        }
        public double chiPhi()
        {
            return HoaHong * GiaBan + phiBaoHanh();
        }
        public abstract double phiBaoHanh();
        public virtual double loiNhuan()
        {
            return GiaBan - chiPhi() -thueSanXuat();
        }
        public  void Xuat()
        {
            Console.WriteLine("Ma thiet bi {0} , ten thiet bi {1} , nam san xuat {2} , gia ban {3} , hoa hong {4} , loi nhuan {5} ", MaThietBi, TenThietBi, NamSanXuat, GiaBan, HoaHong, loiNhuan());
        }
    }
}
