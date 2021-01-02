using BUS;
using DTO;
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
    public partial class frmDangnhap : Form
    {
        //---------1.Khai báo tầng BUS, nơi có chứa hàm kết nối CSDL
        BUS_CDBConnect cn = new BUS_CDBConnect();

        //---------2.Khai báo lớp: GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            //----------Gọi hàm khởi tạo các tham số để đăng nhập
            DTO_CLogIn lg = new DTO_CLogIn(txtServername.Text.Trim(),
                                           txtDatabase.Text.Trim(),
                                           txtUserID.Text.Trim(),
                                           txtPassword.Text.Trim());
            //------Gọi hàm kết nối CSDL bên tầng BUS
            if (cn.DBConnect(lg) == true)
            {
                mnu.EnableMenu(false, true); //----Gọi hàm Ẩn/Hiện menu
                this.Close(); //------------Đóng màn hình đăng nhập
            }
        }
    }
}
