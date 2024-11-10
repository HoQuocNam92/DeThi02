using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi02
{
    internal class ThietBiGiaDung : ThietBi
    {
        string chatLieu;
        public string ChatLieu { get { return chatLieu; } set { chatLieu = value; } }
        public ThietBiGiaDung(string maThietBi, string tenThietBi, int namSanXuat, double giaBan, double hoaHong, string chatlieu) : base(maThietBi, tenThietBi, namSanXuat, giaBan, hoaHong)
        {
            ChatLieu = chatlieu;
        }
        public override double phiBaoHanh()
        {
            if (chatLieu == "Nhua")
            {
                return 0;
            }
            if((GiaBan * 0.15) > 10000){
                return 10000;
            }
            return GiaBan * 0.15;
        }
       
    }
}
