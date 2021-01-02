using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHethong : Form
    {
        //----------Khai báo lớp: GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        //----------Khai báo lớp: BUS_CDBConnect
        BUS_CDBConnect cn = new BUS_CDBConnect();

        public frmHethong()
        {
            InitializeComponent();
        }

        private void frmHethong_Load(object sender, EventArgs e)
        {
            mnu.EnableMenu(true, false);
            frmDangnhap frm = new frmDangnhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            frmDangnhap frm = new frmDangnhap();
            frm.ShowDialog();
        }

        private void mnuHKN_Click(object sender, EventArgs e)
        {
            if (cn.DisDBConnect() == true) //----Gọi hàm hủy kết nối CSDL ở tầng: BUS
            {
                mnu.EnableMenu(true, false); //---Gọi hàm Ẩn/Hiện menu
            }
        }
    }
}
