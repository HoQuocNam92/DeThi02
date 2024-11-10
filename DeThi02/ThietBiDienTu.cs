using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi02
{
    internal class ThietBiDienTu : ThietBi
    {
        int soThang;
        public int SoThang {  get { return soThang; } set { soThang = value; } }
        public ThietBiDienTu(string maThietBi, string tenThietBi, int namSanXuat, double giaBan, double hoaHong, int sothang) : base(maThietBi, tenThietBi, namSanXuat, giaBan, hoaHong)
        {
            SoThang = sothang;
        }
        public override double phiBaoHanh()
        {
            if(SoThang >= 24)
            {
                return GiaBan * 0.1;
            }
            else if(SoThang >=12 && SoThang <= 24)
            {
                return GiaBan * 0.08;
            }
            return 0;
        }
        public override double loiNhuan()
        {
            if(GiaBan >= 100000)
            {
                return base.loiNhuan() * 0.97;
            }
            return base.loiNhuan() *0.98;
        }
    }
}
