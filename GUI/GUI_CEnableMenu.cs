using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class GUI_CEnableMenu
    {
        //-----------Khai báo form hệ thống
        public static frmHethong frmHT = new frmHethong();

        //-----------Viết hàm Ẩn/Hiện menu hệ thống
        public void EnableMenu(bool d1, bool d2)
        {
            frmHT.mnuDN.Enabled = d1;
            frmHT.mnuHKN.Enabled = d2;
            frmHT.mnuBR.Enabled = d2;
            frmHT.mnuDMKH.Enabled = d2;
            frmHT.mnuDMMH.Enabled = d2;
            frmHT.mnuDMNV.Enabled = d2;
            frmHT.mnuLHD.Enabled = d2;
            frmHT.mnuInHD.Enabled = d2;
            frmHT.mnuBCDTMH.Enabled = d2;
            frmHT.mnuBCDTNV.Enabled = d2;
            frmHT.mnuTCHD.Enabled = d2;
        }
        //----------Viết hàm chính để chạy form hệ thống
       // static void Main()
        //{
          //  Application.Run(frmHT);
           
        //}
    }
}
