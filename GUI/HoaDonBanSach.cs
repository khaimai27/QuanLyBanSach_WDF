using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_Container
{
    public partial class HoaDonBanSach : Form
    {
        SqlConnection connNS = new SqlConnection("Data Source=ADMIN-PC;Initial Catalog=QLBS;Integrated Security=True");
        SqlCommand command;
        string str = "Data Source=ADMIN-PC;Initial Catalog=QLBS;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable dt = new DataTable();
        DataRow dr;
        public HoaDonBanSach()
        {
            InitializeComponent();
        }

        private void btnTimHDBS_Click(object sender, EventArgs e)
        {

            DanhSach();
        }
        private void DanhSach()
        {
            SqlCommand command = new SqlCommand();
            command = connNS.CreateCommand();
            string MATGBS = cboTGBS.Text.Trim();
            string MATLBS = cboTLBS.Text.Trim();
            string MANXBBS = cboNXBBS.Text.Trim();

            command.CommandText = "SELECT a.* FROM SACH a LEFT JOIN TheLoai b ON a.MaTL = b.MaTL";
            command.CommandText += " LEFT JOIN TacGia c ON a.MaTG = c.MaTG";
            command.CommandText += " LEFT JOIN NhaXuatBan d ON a.MaNXB = d.MaNXB";
            command.CommandText += " WHERE 1=1";
            if (txtTenSachBS.Text != "")
            {
                command.CommandText += " AND TenSach LIKE N'%" + txtTenSachBS.Text.Trim() + "%'";
            }
            if (MATGBS != "")
            {
                command.CommandText += " AND TenTG LIKE N'%" + MATGBS + "%'";
            }
            if (MATLBS != "")
            {
                command.CommandText += " AND TenTL LIKE N'%" + MATLBS + "%'";
            }
            if (MANXBBS != "")
            {
                command.CommandText += " AND TenNXB LIKE N'%" + MANXBBS + "%'";
            }

            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvKetQua.DataSource = table;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn chắc chắn muốn thoát chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
            
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvKetQua.Rows[dgvKetQua.CurrentCell.RowIndex];
            string MaSach = row.Cells[0].Value.ToString();
            string TenSach = row.Cells[0].Value.ToString();
            decimal GiaNhap = decimal.Parse(row.Cells[6].Value.ToString());

            dr = dt.NewRow();
            dr["MaSach"] = MaSach;
            dr["TenSach"] = TenSach;
            dr["SoLuong"] = txtSLBan.Value;
            dt.Rows.Add(dr);
            dgvGioHang.DataSource = dt;

            txtTongTien.Value = txtTongTien.Value + (txtSLBan.Value * GiaNhap);
        }

        public void HoaDonBanSach_Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add("MaSach");
            dt.Columns.Add("TenSach");
            dt.Columns.Add("SoLuong");


            connNS.Open();
            //load combo box TacGia
            SqlCommand cmdNS = new SqlCommand("Select MaTG,TenTG from TacGia", connNS);
            SqlDataAdapter daNS = new SqlDataAdapter();
            daNS.SelectCommand = cmdNS;
            DataTable tableNS = new DataTable();
            daNS.Fill(tableNS);
            cboTGBS.DataSource = tableNS;
            cboTGBS.DisplayMember = "TenTG";
            cboTGBS.ValueMember = "MaTG";
            if (cboTGBS.Items.Count > 1)
            {
                cboTGBS.SelectedIndex = -1;
            }


            //Load combo box TheLoai
            SqlCommand cmdNSTL = new SqlCommand("Select MaTL,TenTL from TheLoai", connNS);
            SqlDataAdapter daNSTL = new SqlDataAdapter();
            daNSTL.SelectCommand = cmdNSTL;
            DataTable tableNSTL = new DataTable();
            daNSTL.Fill(tableNSTL);
            cboTLBS.DataSource = tableNSTL;
            cboTLBS.DisplayMember = "TenTL";
            cboTLBS.ValueMember = "MaTL";
            if (cboTLBS.Items.Count > 1)
            {
                cboTLBS.SelectedIndex = -1;
            }

            //Load combo box NXB
            SqlCommand cmdNSNXB = new SqlCommand("Select MaNXB,TenNXB from NhaXuatBan", connNS);
            SqlDataAdapter daNSNXB = new SqlDataAdapter();
            daNSTL.SelectCommand = cmdNSNXB;
            DataTable tableNSNXB = new DataTable();
            daNSTL.Fill(tableNSNXB);
            cboNXBBS.DataSource = tableNSNXB;
            cboNXBBS.DisplayMember = "TenNXB";
            cboNXBBS.ValueMember = "MaNXB";
            if (cboNXBBS.Items.Count > 1)
            {
                cboNXBBS.SelectedIndex = -1;
            }
            

            //Load datagrid view KetQua
            command = connNS.CreateCommand();
            command.CommandText = "select * from Sach";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvKetQua.DataSource = table;
        }

        private void txtTenSachBS_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void btnMoi_Click(object sender, EventArgs e)
        {
            
            //load combo box TacGia
            SqlCommand cmdNS = new SqlCommand("Select MaTG,TenTG from TacGia", connNS);
            SqlDataAdapter daNS = new SqlDataAdapter();
            daNS.SelectCommand = cmdNS;
            DataTable tableNS = new DataTable();
            daNS.Fill(tableNS);
            cboTGBS.DataSource = tableNS;
            cboTGBS.DisplayMember = "TenTG";
            cboTGBS.ValueMember = "MaTG";
            if (cboTGBS.Items.Count > 1)
            {
                cboTGBS.SelectedIndex = -1;
            }


            //Load combo box TheLoai
            SqlCommand cmdNSTL = new SqlCommand("Select MaTL,TenTL from TheLoai", connNS);
            SqlDataAdapter daNSTL = new SqlDataAdapter();
            daNSTL.SelectCommand = cmdNSTL;
            DataTable tableNSTL = new DataTable();
            daNSTL.Fill(tableNSTL);
            cboTLBS.DataSource = tableNSTL;
            cboTLBS.DisplayMember = "TenTL";
            cboTLBS.ValueMember = "MaTL";
            if (cboTLBS.Items.Count > 1)
            {
                cboTLBS.SelectedIndex = -1;
            }

            //Load combo box NXB
            SqlCommand cmdNSNXB = new SqlCommand("Select MaNXB,TenNXB from NhaXuatBan", connNS);
            SqlDataAdapter daNSNXB = new SqlDataAdapter();
            daNSTL.SelectCommand = cmdNSNXB;
            DataTable tableNSNXB = new DataTable();
            daNSTL.Fill(tableNSNXB);
            cboNXBBS.DataSource = tableNSNXB;
            cboNXBBS.DisplayMember = "TenNXB";
            cboNXBBS.ValueMember = "MaNXB";
            if (cboNXBBS.Items.Count > 1)
            {
                cboNXBBS.SelectedIndex = -1;
            }

            //Load datagrid view KetQua
            command = connNS.CreateCommand();
            command.CommandText = "select * from Sach";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvKetQua.DataSource = table;

            
        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKetQua.CurrentRow.Index;
            txtTenSachBS.Text = dgvKetQua.Rows[i].Cells[1].Value.ToString();
            cboNXBBS.SelectedValue = dgvKetQua.Rows[i].Cells[4].Value.ToString();
            cboTLBS.SelectedValue= dgvKetQua.Rows[i].Cells[2].Value.ToString();
            cboTGBS.SelectedValue= dgvKetQua.Rows[i].Cells[3].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn chắn tính tiền không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlCommand cmdtl = new SqlCommand();
                cmdtl = connNS.CreateCommand();
                
                for (int rows = 0; rows < dgvGioHang.Rows.Count-1; rows++)
                {

                    string slTon = dgvGioHang.Rows[rows].Cells["SoLuong"].Value.ToString();
                    string maSach = dgvGioHang.Rows[rows].Cells["MaSach"].Value.ToString();
                    cmdtl.CommandText = "UPDATE SACH SET SoLuongTon = SoLuongTon - " + slTon + " WHERE MaSach ='"+ maSach + "'";
                    cmdtl.ExecuteNonQuery();
                }
                MessageBox.Show("Tính thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                DanhSach();
            };
            
        }

        private void btnXoaKhoiGio_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
