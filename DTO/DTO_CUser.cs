using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class DTO_CUser
    {
        private String maNV;
        private String tenNV;
        private String tenDangNhap;
        private String matKhau;
        private DateTime ngaySinh;
        private String phai;
        private String diaChi;
        private String dienThoai;
        private String roleName;
        private int soHDThucHien;
        private DateTime ngayDangNhap;
        private int soLanDangNhap;
        private int role;



    public DTO_CUser(String tenDangNhap, String matKhau)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }

    public DTO_CUser(string maNV, string tenNV, string tenDangNhap, string dienThoai, int role, string roleName)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.tenDangNhap = tenDangNhap;
            this.dienThoai = dienThoai;
            this.role = role;
            this.RoleName = roleName;
        }
        public DTO_CUser(string maNV, string tenNV, string tenDangNhap, string matKhau, DateTime ngaySinh, string phai, string diaChi, string dienThoai, int soHDThucHien, DateTime ngayDangNhap, int soLanDangNhap, int role, string roleName)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.ngaySinh = ngaySinh;
            this.phai = phai;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.soHDThucHien = soHDThucHien;
            this.ngayDangNhap = ngayDangNhap;
            this.soLanDangNhap = soLanDangNhap;
            this.role = role;
            this.RoleName = roleName;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Phai { get => phai; set => phai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public int SoHDThucHien { get => soHDThucHien; set => soHDThucHien = value; }
        public DateTime NgayDangNhap { get => ngayDangNhap; set => ngayDangNhap = value; }
        public int SoLanDangNhap { get => soLanDangNhap; set => soLanDangNhap = value; }
        public int Role { get => role; set => role = value; }
        public string RoleName { get => roleName; set => roleName = value; }
    }




}
