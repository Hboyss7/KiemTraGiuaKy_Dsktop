using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2212366_BuiTrungHieu_De3
{
    internal class DocGia
    {
        public string MaDocGia {  get; set; }

        public string TenDocGia { get; set; }

        public string SoDT { get; set; }

        public string DiaChi { get; set; }

        public DocGia()
        {
                
        }

        public DocGia(string ma, string ten, string sdt, string diachi)
        {
            this.MaDocGia = ma;
            this.TenDocGia = ten;   
            this.SoDT = sdt;
            this.DiaChi = diachi;
        }

        public override string ToString()
        {
            string s = "Mã độc giả: " + MaDocGia + "\n" +
                       "Tên độc giả: " + TenDocGia + "\n" +
                       "Số điện thoại " + SoDT + "\n" +
                       "Địa chỉ: " + DiaChi + "\n";
            return s;
        }
    }
}
