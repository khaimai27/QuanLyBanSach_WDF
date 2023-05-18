using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHoaDon : Form
    {
        private HoaDonBUS hoaDonBus = new HoaDonBUS();
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            dgvHoaDon.DataSource = hoaDonBus.LayDanhSachHoaDon();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công", "Thông báo");
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
