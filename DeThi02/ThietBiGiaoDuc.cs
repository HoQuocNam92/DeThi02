using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi02
{
    internal class ThietBiGiaoDuc : ThietBi
    {
        int tuoi;
        public int Tuoi {  get { return tuoi; } set { tuoi = value; } }
        public ThietBiGiaoDuc(string maThietBi, string tenThietBi, int namSanXuat, double giaBan, double hoaHong , int tuoi) : base( maThietBi,  tenThietBi,  namSanXuat,  giaBan,  hoaHong) 
        {
            Tuoi = tuoi;
        }

        public override double phiBaoHanh()
        {
            if (tuoi <= 10)
            {
                return 0;
            }
            else if (NamSanXuat <= 2020)
            {
                return 0.1 * GiaBan;
            }
            return 0.18 * GiaBan;
        }
                                                                    
    }
}
