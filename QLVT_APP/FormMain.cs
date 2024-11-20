using System;
using DevExpress.XtraBars;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT_APP
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Frm_login f_dangNhap;
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        public void hienThongTinStatus()
        {
            MANV.Text = "MaNV: " + Program.username;
            HOTEN.Text = "TenNV: " + Program.mHoTen;
            NHOM.Text = "Nhom: " + Program.mGroup;

            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
        }
        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup != "")
            {
                MessageBox.Show("Bạn chưa đăng xuất!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm = this.CheckExists(typeof(Frm_login));
            if (frm != null) frm.Activate();
            else
            {
                f_dangNhap = new Frm_login();
                f_dangNhap.MdiParent = this;
                //f_dangNhap.f_main = this;
                f_dangNhap.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(FormVatTu));
            if (form != null) form.Activate();
            else
            {
                FormVatTu f = new FormVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(FormNhanVien));
            if (form != null) form.Activate();
            else
            {
                FormNhanVien f = new FormNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
