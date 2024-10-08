using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _2212366_BuiTrungHieu_De3
{
    public delegate int SoSanh(Object obj1,  Object obj2);
    
    internal class QuanLyDocGia
    {
        public List<DocGia> dsdg;

        public QuanLyDocGia()
        {
               dsdg = new List<DocGia>();
        }

        public void Them(DocGia dg)
        {
            dsdg.Add(dg);
        }

        public void NhapTuFile()
        {
            string tenFile = "ds.txt", line;
            FileStream file = new FileStream(tenFile, FileMode.Open);
            StreamReader sr = new StreamReader(file);
            string[] doan;
            while ((line = sr.ReadLine())!= null)
            {
                DocGia dg = new DocGia();
                doan = line.Split(';');
                dg.MaDocGia = doan[0];
                dg.TenDocGia = doan[1];
                dg.SoDT = doan[2];
                dg.DiaChi = doan[3];
                this.dsdg.Add(dg);
            }

        }

        public override string ToString()
        {
            string s = "";
            foreach (DocGia dg in dsdg)
            {
                s += dg.ToString() + "\n"; 
            }    
            return s;
        }

        public DocGia Tim(Object obj, SoSanh ss)
        {
            DocGia dg = null ;
            foreach (var item in dsdg)
            {
                if (ss(obj,item)==0)
                {
                    dg = item;
                    break;
                }
            }
            return dg;
        }
    }
}
