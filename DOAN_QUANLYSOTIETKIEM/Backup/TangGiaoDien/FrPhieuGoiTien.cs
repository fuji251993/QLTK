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
    public partial class FrPhieuGoiTien : Form
    {
        public FrPhieuGoiTien()
        {
            InitializeComponent();
        }
        private void loaddulieu()
        {
            List<PhieuGoiTien_DTO> tam = PhieuGoiTien_BUS.LayDanhSachPhieuGoi();
            dataGrid.DataSource = tam; 
        }
        private void FrPhieuGoiTien_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            List<SoTietKiem_DTO> tam = SoTietKiem_BUS.ListSoMo();
            dataGridView1.DataSource = tam;
            dataGridView1.Columns[0].DataPropertyName = "maso";
            dataGridView1.Columns[1].DataPropertyName = "tenkhachhang";
            float tiengoi = ThamSo_BUS.SoTienGoiThemToiThieu();
            txtsotiengoi.Text = tiengoi.ToString();
            txtmaphieugoi.Text = PhieuGoiTien_BUS.MaTiepTheo().ToString();
            loaddulieu();
        } 
        private void txtmaso_TextChanged(object sender, EventArgs e)
        {
            long maso;

            if (long.TryParse(txtmaso.Text, out maso) == false && txtmaso.Text!="")
            {  
                MessageBox.Show("Mã chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SoTietKiem_DTO SoTietKiem = SoTietKiem_BUS.LayThongTinSoTietKiem(maso);           
            if (SoTietKiem == null)
            {
                txttenkhach.Text = "";
                txtcmnd.Text = "";
                txttongtien.Text = "";                
                MessageBox.Show("Mã này chưa được nhập. Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          
            txttenkhach.Text = SoTietKiem.tenkhachhang;
            txtcmnd.Text = SoTietKiem.cmnd;
            txttongtien.Text = SoTietKiem.tongtien.ToString(); 
            LoaiTietKiem_DTO LoaiTietKiem = LoaiTietKiem_BUS.LayDSLTK(SoTietKiem.maloaitietkiem);
            txtloaitietkiem.Text = LoaiTietKiem.tenloaitietkiem;

        } 
    
        private void btlapphieu_Click(object sender, EventArgs e)
        {
            //SoTietKiem_DTO SoTietKiem = SoTietKiem_BUS.LayThongTinSoTietKiem(maso);
            PhieuGoiTien_DTO PhieuGoi = new PhieuGoiTien_DTO();

            if (txtmaso.Text == "")
            {     
                MessageBox.Show("Chưa nhập thông tin của sổ muốn gởi thêm tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            long maloaitietkiemkhongkyhan = LoaiTietKiem_BUS.LayMaLoaiTietKiemKoKyHan();
            PhieuGoi.maso = long.Parse(txtmaso.Text.ToString());
            PhieuGoi.maphieugoitien = long.Parse(txtmaphieugoi.Text.ToString());
            PhieuGoi.ngaygoi = dtngaygoi.Value;
            float tiencu = float.Parse(txttongtien.Text.ToString());

            long maloaitietkiemcuamaso = SoTietKiem_BUS.LayMaLoaiTietKiem(PhieuGoi.maso);

            if (maloaitietkiemcuamaso != maloaitietkiemkhongkyhan)
            { 
                MessageBox.Show("Loại Tiết Kiệm Này Không Được Gởi Thêm Tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            if (txtsotiengoi.Text == "")
            { 
                MessageBox.Show("Chưa nhập Số tiền muốn gởi thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            float sotiengoi;

            if (float.TryParse(txtsotiengoi.Text, out sotiengoi) == false)
            { 
                MessageBox.Show("Tiền Gởi Chỉ Được Nhập Số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PhieuGoi.sotiengoi = long.Parse(txtsotiengoi.Text.ToString());

            float tiengoi = ThamSo_BUS.SoTienGoiThemToiThieu(); 
            if (PhieuGoi.sotiengoi < tiengoi)
            {
                MessageBox.Show("Số Tiền Gởi Không Đúng Quy Định,Tiền Gởi Thêm Phải Lớn Hơn " + tiengoi);
                return;
            }
            PhieuGoiTien_BUS.LapPhieuGoiTien(PhieuGoi, tiencu);
            MessageBox.Show("Gởi Tiền Thành Công");
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
        private void btlapphieumoi_Click(object sender, EventArgs e)
        {
            txtcmnd.Text = "";
            txtloaitietkiem.Text = "";
            txtmaso.Text  = "";
            txttongtien.Text = "";
            float tiengoi = ThamSo_BUS.SoTienGoiThemToiThieu();
            txtsotiengoi.Text = tiengoi.ToString();
        } 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaso.Text = dataGridView1.CurrentRow.Cells["MaSo"].Value.ToString();
        } 
        private void btcapnhat_Click(object sender, EventArgs e)
        {
            PhieuGoiTien_DTO phieugoitien = new PhieuGoiTien_DTO();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                phieugoitien.sotiengoi= long.Parse(gridView1.GetRowCellValue(i, "sotiengoi").ToString());
                phieugoitien.ngaygoi  = DateTime.Parse( gridView1.GetRowCellValue(i, "ngaygoi").ToString());
                phieugoitien.maphieugoitien = long.Parse(gridView1.GetRowCellValue(i, "maphieugoitien").ToString()); 
                PhieuGoiTien_BUS.CapNhatPhieuGoiTien(phieugoitien);
            } 
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } 
        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string a = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "maphieugoitien").ToString();
                if (a != "")
                {
                    DialogResult t;
                    t = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == t)
                    {
                        PhieuGoiTien_BUS.DeleteLoai(a);
                        loaddulieu();
                    }
                }
                else
                { 
                    MessageBox.Show("Không có mã để xóa ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        } 
        private void repositoryItemCheckEdit1_Click(object sender, EventArgs e)
        {
            PhieuGoiTien_DTO phieugoitien = new PhieuGoiTien_DTO();
            phieugoitien.sotiengoi = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "sotiengoi").ToString());
            phieugoitien.ngaygoi = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ngaygoi").ToString());
            phieugoitien.maphieugoitien = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "maphieugoitien").ToString());

            PhieuGoiTien_BUS.CapNhatPhieuGoiTien(phieugoitien);             
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void repositoryItemCheckEdit2_Click(object sender, EventArgs e)
        {
            try
            {
                string a = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "maphieugoitien").ToString();
                if (a != "")
                {
                    DialogResult t;
                    t = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (DialogResult.OK == t)
                    {
                        PhieuGoiTien_BUS.DeleteLoai(a);
                        loaddulieu();
                    }
                }
                else
                { 
                    MessageBox.Show("Không có mã để xóa ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {     
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }  
    }
}