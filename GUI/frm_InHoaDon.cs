using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace GUI
{
    public partial class frm_InHoaDon : Form
    {
        private String billID;
        public frm_InHoaDon(String billID)
        {
            this.billID = billID;
            InitializeComponent();
            this.INHOADON(billID);
        }
    public void INHOADON(string ms)
        {
            //----------1.Khai báo CrystalReport: CrystalReportHD.rpt
            rp_DonHang rp = new rp_DonHang();

            //----------2.Cung cấp thông tin đăng nhập cho CrystalReport: CrystalReportHD
            ConnectionInfo myConn = new ConnectionInfo();
            myConn.ServerName = frmDangnhap.SV;
            myConn.DatabaseName = frmDangnhap.DB;
            myConn.UserID = frmDangnhap.ID;
            myConn.Password = frmDangnhap.PASS;
            TableLogOnInfo myTable = new TableLogOnInfo();
            myTable.ConnectionInfo = myConn;
            rp.Database.Tables[0].ApplyLogOnInfo(myTable);

            //----------3.Khai báo kết nối tham số với CrystalReport
            CrystalDecisions.Shared.ParameterValues myVL = new CrystalDecisions.Shared.ParameterValues();
            CrystalDecisions.Shared.ParameterDiscreteValue PDVMaHD = new CrystalDecisions.Shared.ParameterDiscreteValue();


            //----------4. Truyền tham số Từ ngày - Đến ngày (Form)
            //-----4.1. Truyền tham số Từ ngày
            PDVMaHD.Value = ms;
            myVL.Add(PDVMaHD);
            rp.DataDefinition.ParameterFields["@MSHD"].ApplyCurrentValues(myVL);
            myVL.Clear();


            //-----------5.Gán CrystalReport vào crystalReportViewerP
            crystalReportViewerHD.ReportSource = rp;
        }

        
    }
}
