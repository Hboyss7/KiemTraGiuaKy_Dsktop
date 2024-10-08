using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _2212366_BuiTrungHieu_De3
{
    public partial class Form1 : Form
    {
        QuanLyDocGia dsdg;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            dsdg = new QuanLyDocGia();
            dsdg.NhapTuFile();
            LoadLV();
        }
        private void ThemLV (DocGia dg)
        {
            ListViewItem lvitem = new ListViewItem(dg.MaDocGia);
            lvitem.SubItems.Add(dg.TenDocGia);
            lvitem.SubItems.Add(dg.SoDT);
            lvitem.SubItems.Add(dg.DiaChi);
            this.lvQLDG.Items.Add(lvitem);
            
        }
        private void LoadLV()
        {
            lvQLDG.Items.Clear();
            foreach (var item in dsdg.dsdg)
            {
                ThemLV(item);
            }
        }

        private void lvQLDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = lvQLDG.SelectedItems.Count ;
            if (count > 0) 
            {
                ListViewItem lvitem = lvQLDG.SelectedItems[0];
                DocGia dg = GetLV(lvitem);
                ThietLapControl(dg);
            }
        }
        private DocGia GetLV(ListViewItem lvitem)
        {
            DocGia dg = new DocGia();
            dg.MaDocGia = lvitem.SubItems[0].Text;
            dg.TenDocGia = lvitem.SubItems[1].Text;
            dg.SoDT = lvitem.SubItems[2].Text;
            dg.DiaChi = lvitem.SubItems[3].Text;

            return dg;
        }
        private void ThietLapControl(DocGia dg)
        {
            txtMaDocGia.Text = dg.MaDocGia;
            txtTenDocGia.Text = dg.TenDocGia;
            mtxtSDT.Text = dg.SoDT;
            txtDiaChi.Text = dg.DiaChi;
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaDocGia.Text = "";
            txtTenDocGia.Text = "";
            mtxtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DocGia dg = GetControl();
            DocGia kq = dsdg.Tim(dg.MaDocGia, delegate (object obj1, object obj2)
                {
                    return (obj2 as DocGia).MaDocGia.CompareTo(obj1.ToString());

                });
            if (kq != null)
            {
                MessageBox.Show("Mã độc giả đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.dsdg.Them(dg);
                this.LoadLV();
            }
            

        }
        private DocGia GetControl ()
        {
            DocGia dg = new DocGia();
            dg.MaDocGia = txtMaDocGia.Text;
            dg.TenDocGia = txtTenDocGia.Text;
            dg.SoDT = mtxtSDT.Text;
            dg.DiaChi = txtDiaChi.Text;
            return dg;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string s = txtTimKiem.Text;
            QuanLyDocGia dsdg2 = dsdg;
            if (s.Length > 0) 
            {
                DocGia kq = dsdg.Tim(s, delegate (object obj1, object obj2)
                {
                    return (obj2 as DocGia).MaDocGia.CompareTo(obj1.ToString());

                });
                if (kq != null)
                {
                    dsdg = new QuanLyDocGia();
                    dsdg.Them(kq);
                    lvQLDG.Items.Clear();
                    LoadLV();
                }
                else
                {
                    lvQLDG.Items.Clear();
                }
                dsdg = dsdg2;
            }   
            else
            {
               
                LoadLV();
            }    
            
            
            
        }
    }
}


