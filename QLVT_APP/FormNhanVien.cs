using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_APP
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.dS.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'dS.VIEW_NHANVIEN' table. You can move, or remove it, as needed.
                this.vIEW_NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vIEW_NHANVIENTableAdapter.Fill(this.dS.VIEW_NHANVIEN);
				// TODO: This line of code loads data into the 'dS.CT_NhanVien' table. You can move, or remove it, as needed.
				this.cT_NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
				this.cT_NhanVienTableAdapter.Fill(this.dS.CT_NhanVien);
				// TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
				this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
				this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
			}
            catch
            {
                MessageBox.Show("Tải dữ liệu không thành công!\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void textEdit5_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
		{

		}

		private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
		{

		}

		private void bar_btn_add_ItemClick(object sender, ItemClickEventArgs e)
		{
			groupControl_edit.Enabled = true;
			groupControl_nv.Enabled = false;
			bar_btn_add.Enabled = false;
			bar_btn_update.Enabled = false;
			bar_btn_remove.Enabled = false;
			bar_btn_save.Enabled = true;
			bar_btn_exit.Enabled = true;
			bar_btn_refresh.Enabled = false;
			bar_btn_ccn.Enabled = false;

		}
	}
}