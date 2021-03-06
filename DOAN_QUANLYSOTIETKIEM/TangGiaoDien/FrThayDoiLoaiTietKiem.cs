using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace TangGiaoDien
{
    public partial class FrThayDoiLoaiTietKiem : Form
    {
        public FrThayDoiLoaiTietKiem()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Enabled = true;

            }
            if (checkBox1.Checked == false)
            {
                groupBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                groupBox2.Enabled = false;
            }

            if (checkBox2.Checked == true)
            {
                groupBox2.Enabled = true;

            }
            
        }

        private void FrThayDoiLoaiTietKiem_Load(object sender, EventArgs e)
        {
           // ((Frmain)this.MdiParent).ThayDoiThongTinTrangThai("Trạng Thái:load màn hình'" + this.Text + "' thành công!", Color.Blue);

            if (checkBox1.Checked == true)
            {
                txtmaloaitietkiem.Text = LoaiTietKiem_BUS.MaTiepTheo().ToString();
               // LoaiTietKiem_DTO Them = new LoaiTietKiem_DTO();
            }
            
            cbtenloaitietkiem.DataSource = LoaiTietKiem_BUS.DSLoaiTietKiem();
            cbtenloaitietkiem.DisplayMember = "tenloaitietkiem";
            cbtenloaitietkiem.ValueMember = "maloaitietkiem";
            long maloaitietkiem = long.Parse(cbtenloaitietkiem.SelectedValue.ToString());
            textBox1.Text = LoaiTietKiem_BUS.LayLaiSuatBoiMaLoaiTietKiem(maloaitietkiem).ToString(); 
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoaiTietKiem_DTO Them = new LoaiTietKiem_DTO();
            if (txttenloaitietkiem.Text == "")
            {
                MessageBox.Show("Chưa nhập tên loại tiết kiệm");
                return;
            }
            Them.tenloaitietkiem = txttenloaitietkiem.Text;
            float laisuat;
            if (txtlaisuat.Text == "")
            {
                MessageBox.Show("Chưa nhập số lãi suất");
                return;
            }

            if (float.TryParse(txtlaisuat.Text, out laisuat) == false)
            {
                MessageBox.Show("Tiền Gởi Chỉ Được Nhập Số");
                return;
            }
            Them.maloaitietkiem =long.Parse(txtmaloaitietkiem.Text.ToString());
            Them.laisuat = float.Parse(txtlaisuat.Text.ToString());
            LoaiTietKiem_BUS.ThemLoaiTietKiem(Them);
            MessageBox.Show("Thêm Loại Kỳ Hạn Thành Công !");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbtenloaitietkiem.DataSource = LoaiTietKiem_BUS.DSLoaiTietKiem();
            cbtenloaitietkiem.DisplayMember = "tenloaitietkiem";
            cbtenloaitietkiem.ValueMember = "maloaitietkiem";
            long maloaitietkiem = long.Parse(cbtenloaitietkiem.SelectedValue.ToString());
            string loaitietkiem = LoaiTietKiem_BUS.LayLaiSuatBoiMaLoaiTietKiem(maloaitietkiem).ToString();
            if (textBox1.Text != loaitietkiem)
            {
                float giatri = float.Parse(textBox1.Text.ToString());
                LoaiTietKiem_BUS.ThayDoiQuyDinh(maloaitietkiem, giatri);
                MessageBox.Show("Cập Nhật Thành Công !");
            }
            
        }

        private void cbtenloaitietkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtenloaitietkiem.SelectedIndex < 0)
            {
                return;
            }
            List<LoaiTietKiem_DTO> danhsachloai = (List<LoaiTietKiem_DTO>)cbtenloaitietkiem.DataSource;
            foreach (LoaiTietKiem_DTO loai in danhsachloai)
            {
                if (loai.maloaitietkiem.ToString() == cbtenloaitietkiem.SelectedValue.ToString())
                {
                    textBox1.Text = loai.laisuat.ToString();
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        void themloaikyhan()
        {
            LoaiTietKiem_DTO Them = new LoaiTietKiem_DTO();
            if (txttenloaitietkiem.Text == "")
            {
                MessageBox.Show("Chưa nhập tên loại tiết kiệm");
                return;
            }
            Them.tenloaitietkiem = txttenloaitietkiem.Text;
            float laisuat;
            if (txtlaisuat.Text == "")
            {
                MessageBox.Show("Chưa nhập số lãi suất");
                return;
            }

            if (float.TryParse(txtlaisuat.Text, out laisuat) == false)
            {
                MessageBox.Show("Tiền Gởi Chỉ Được Nhập Số");
                return;
            }
            Them.maloaitietkiem = long.Parse(txtmaloaitietkiem.Text.ToString());
            Them.laisuat = float.Parse(txtlaisuat.Text.ToString());
            LoaiTietKiem_BUS.ThemLoaiTietKiem(Them);
            MessageBox.Show("Thêm Loại Kỳ Hạn Thành Công !");
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            themloaikyhan();

        }
        void thaydoilaisuat()
        {
            cbtenloaitietkiem.DataSource = LoaiTietKiem_BUS.DSLoaiTietKiem();
            cbtenloaitietkiem.DisplayMember = "tenloaitietkiem";
            cbtenloaitietkiem.ValueMember = "maloaitietkiem";
            long maloaitietkiem = long.Parse(cbtenloaitietkiem.SelectedValue.ToString());
            string loaitietkiem = LoaiTietKiem_BUS.LayLaiSuatBoiMaLoaiTietKiem(maloaitietkiem).ToString();
            if (textBox1.Text != loaitietkiem)
            {
                float giatri = float.Parse(textBox1.Text.ToString());
                LoaiTietKiem_BUS.ThayDoiQuyDinh(maloaitietkiem, giatri);
                MessageBox.Show("Cập Nhật Thành Công !");
            }
            
        }
        private void btcapnhat_Click(object sender, EventArgs e)
        {
            thaydoilaisuat();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult t;
            t = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == t)
            {
                this.Close();
            }
        } 
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult t;
            t = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == t)
            {
                this.Close();
            }
        } 
        private void FrThayDoiLoaiTietKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (checkBox1.Checked == true)
                {
                    themloaikyhan();
                }
                if (checkBox2.Checked == true)
                {
                    thaydoilaisuat();
                    
                } 
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    DialogResult t;
                    t = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == t)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btthem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                themloaikyhan();
            }
        }

        private void simpleButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult t;
                t = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == t)
                {
                    this.Close();
                }
            }
        }

        private void simpleButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult t;
                t = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == t)
                {
                    this.Close();
                }
            }
        } 
        private void btcapnhat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                thaydoilaisuat();
            }
        }  
    }
}