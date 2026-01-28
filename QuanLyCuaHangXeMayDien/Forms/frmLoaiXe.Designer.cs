namespace QuanLyCuaHangXeMayDien.Forms
{
    partial class frmLoaiXe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnThoat = new System.Windows.Forms.Button();
            btnHuyBo = new System.Windows.Forms.Button();
            btnLuu = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            txtTenXe = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            dataGridView = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenXe);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(776, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Xe";
            // 
            // btnThoat
            // 
            btnThoat.Location = new System.Drawing.Point(605, 95);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(112, 34);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += new System.EventHandler(btnThoat_Click);
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new System.Drawing.Point(487, 95);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new System.Drawing.Size(112, 34);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += new System.EventHandler(btnHuyBo_Click);
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = System.Drawing.Color.Blue;
            btnLuu.Location = new System.Drawing.Point(369, 95);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(112, 34);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += new System.EventHandler(btnLuu_Click);
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = System.Drawing.Color.Red;
            btnXoa.Location = new System.Drawing.Point(251, 95);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(112, 34);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += new System.EventHandler(btnXoa_Click);
            // 
            // btnSua
            // 
            btnSua.Location = new System.Drawing.Point(133, 95);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(112, 34);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += new System.EventHandler(btnSua_Click);
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(15, 95);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(112, 34);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += new System.EventHandler(btnThem_Click);
            // 
            // txtTenXe
            // 
            txtTenXe.Location = new System.Drawing.Point(113, 33);
            txtTenXe.Name = "txtTenXe";
            txtTenXe.Size = new System.Drawing.Size(583, 31);
            txtTenXe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên Xe (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new System.Drawing.Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(776, 259);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, TenXe });
            dataGridView.Location = new System.Drawing.Point(6, 28);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new System.Drawing.Size(753, 225);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // TenXe
            // 
            TenXe.DataPropertyName = "TenLoai";
            TenXe.HeaderText = "Tên Xe";
            TenXe.MinimumWidth = 8;
            TenXe.Name = "TenXe";
            // 
            // frmLoaiXe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLoaiXe";
            Text = "Loại Xe";
            Load += new System.EventHandler(frmLoaiXe_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
    }
}