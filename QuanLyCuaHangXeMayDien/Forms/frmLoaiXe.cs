using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyCuaHangXeMayDien.Data; // Thêm dòng này để gọi được QLXMDDbContext

namespace QuanLyCuaHangXeMayDien.Forms
{
    public partial class frmLoaiXe : Form
    {
        QLXMDDbContext context = new QLXMDDbContext();
        bool xuLyThem = false;
        int id;

        public frmLoaiXe()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenXe.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmLoaiXe_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            // Gọi đúng bảng LoaiXes trong DbContext của bạn
            var lsp = context.LoaiXes.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            txtTenXe.DataBindings.Clear();
            // Lưu ý: Nếu trong file LoaiXe.cs bạn đổi thuộc tính TenLoai thành tên khác (vd: TenXe) thì sửa chữ "TenLoai" ở đây lại nhé
            txtTenXe.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenXe.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["ID"].Value != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenXe.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại xe?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    var lsp = new LoaiXe();
                    lsp.TenLoai = txtTenXe.Text; // Sửa "TenLoai" nếu file LoaiXe.cs bạn dùng tên biến khác
                    context.LoaiXes.Add(lsp);
                    context.SaveChanges();
                }
                else
                {
                    var lsp = context.LoaiXes.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenLoai = txtTenXe.Text; // Sửa "TenLoai" nếu file LoaiXe.cs bạn dùng tên biến khác
                        context.LoaiXes.Update(lsp);
                        context.SaveChanges();
                    }
                }
                frmLoaiXe_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại xe này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridView.CurrentRow != null && dataGridView.CurrentRow.Cells["ID"].Value != null)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                    var lsp = context.LoaiXes.Find(id);

                    if (lsp != null)
                    {
                        context.LoaiXes.Remove(lsp);
                        context.SaveChanges();
                        frmLoaiXe_Load(sender, e);
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiXe_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}