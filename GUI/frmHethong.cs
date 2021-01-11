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
using DTO;

namespace GUI
{
   
    
    public partial class frmHethong : Form
    {
        //----------Khai báo lớp: GUI_CEnableMenu
        GUI_CEnableMenu mnu = new GUI_CEnableMenu();

        //----------Khai báo lớp: BUS_CDBConnect
        BUS_CDBConnect cn = new BUS_CDBConnect();

        private DTO_CUser loginedUser;
        public static string workShiftID = "";
        public frmHethong()
        {

            InitializeComponent();
            loginedUser = null;
            this.txtUsername.Focus(); 
        }

        private void frmHethong_Load(object sender, EventArgs e)
        {
            mnu.EnableMenu(true, false);
            frmDangnhap frm = new frmDangnhap();
            frm.ShowDialog();
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

        private void mnuDMKH_Click(object sender, EventArgs e)
        {
            new frmCustomer().Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.userLogin();
        }

        private void userLogin()
        {
            if (this.checkValid())
            {
                DTO_CUser user = new DTO.DTO_CUser(this.txtUsername.Text, this.txtPassword.Text);
                this.loginedUser = new BUS_USER().userLogin(user);
                if (loginedUser != null)
                    loadForm(loginedUser, 0);
                else
                    MessageBox.Show("Đăng nhập không thành công", "SUccess !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadForm(DTO_CUser user, int selectIndex)
        {
            this.mainTabControl.SelectedIndex = 1;
            this.lb_username.Text = user.TenNV;
            this.lb_role_name.Text = user.RoleName + " :";
            this.lb_user_id.Text = user.MaNV;
        }
        private bool checkValid()
        {
            bool isValid = false;

            if (this.txtUsername.Text.Trim() == "")
                MessageBox.Show("Vui lòng nhập tài khoản", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (this.txtPassword.Text.Trim() == "")
                MessageBox.Show("Vui lòng mật khẩu", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                isValid = true;

            return isValid;
        }

        

        //login if user press enter key
        private void mainTabControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.mainTabControl.SelectedIndex == 0)
                    this.userLogin();
            }
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            if (DTO_Money.Status1)
                new frm_BanHang(this.loginedUser).ShowDialog();
            else
                MessageBox.Show("Vui lòng mở ca trước khi bán hàng", "KHÔNG THỂ BÁN HÀNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_open_work_shift_Click(object sender, EventArgs e)
        {
            new frm_ShiftControl(0, loginedUser).ShowDialog();
        }

        private void btn_close_work_shift_Click(object sender, EventArgs e)
        {
            if(DTO_Money.Status1)
                new frm_ShiftControl(1, loginedUser).ShowDialog();
            MessageBox.Show("KHÔNG CÓ CA LÀM NÀO ĐƯỢC MỞ", "KHÔNG THỂ ĐÓNG CA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
