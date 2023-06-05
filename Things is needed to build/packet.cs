using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DoAn
{
    public enum Header 
    {
        TaiKhoan, 
        KhachHang, 
        NhanVien, 
        Ban,
        Mon,
        HoaDon, 
        CTHD, 
        Null
    }
    public enum Options 
    {
        DangNhap, 
        DangKy,
        QuenMatKhau, 
        Them, 
        Xoa, 
        Sua, 
        Tim, 
        Xem, 
        Null
    }

    public class Packet
    {
        private Header header;
        private Options options;
        private string message;
        private int maTK;
        private string hoTen;
        private string matKhau;
        private string vaiTro;
        private int maKH; 
        private string hoTenKH; 
        private string sdt; 
        private string hoTenNV; 
        private DateTime NgVL; 
        private string chucVu; 
        private double luong; 
        private int maBan; 
        private int slBan; 
        private string loaiBan; 
        private string tinhtrangBan; 
        private int maMon; 
        private string tenMon; 
        private string dvt; 
        private double gia; 
        private int maHD; 
        private DateTime ngayHD; 
        private double triGia; 
        private int sl; 

        public Header ProjectHeader
        {
            get { return header; }
            set { header = value; }
        }
        public Options ProjectOptions
        {
            get { return options; }
            set { options = value; }
        }
        public string ProjectMessage
        {
            get { return message; }
            set { message = value; }
        }
        public int MaTK
        {
            get { return maTK; }
            set { maTK = value; }
        }
        public string HoTen 
        {
            get { return hoTen; }
            set { hoTen = value;}
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string VaiTro 
        {
            get { return vaiTro; }
            set { vaiTro = value; }
        }
        public int MaKH 
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string HoTenKH
        {
            get { return hoTenKH; }
            set { hoTenKH = value; }
        }
        public string SDT 
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string HoTenNV 
        {
            get { return hoTenNV; }
            set { hoTenNV = value; }
        }
        public DateTime NGVL
        {
            get { return NgVL; }
            set { NgVL = value; }
        }
        public string ChucVu 
        {
            get { return chucVu; }
            set { chucVu = value; }
        }
        public double Luong
        {
            get { return luong; }
            set { luong = value; }
        }
        public int MaBan 
        {
            get { return maBan; }
            set { maBan = value; }
        }
        public int SLBan 
        {
            get { return slBan; }
            set { slBan = value; }
        }
        public string LoaiBan 
        {
            get { return loaiBan; }
            set { loaiBan = value; }
        }
        public string TinhTrangBan 
        {
            get { return tinhtrangBan; }
            set { tinhtrangBan = value; }
        }
        public int MaMon 
        {
            get { return maMon; }
            set { maMon = value; }
        }
        public string TenMon 
        {
            get { return tenMon; }
            set { tenMon = value; }
        }
        public string DVT 
        {
            get { return dvt; }
            set { dvt = value; }
        }
        public double Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        private int MaHD 
        {
            get { return maHD; }
            set { maHD = value; }
        }
        private DateTime NgayHD
        {
            get { return ngayHD; }
            set { ngayHD = value; }
        }
        private double TriGia
        {
            get { return triGia; }
            set { triGia = value; }
        }
        public Packet()
        {
            this.header = Header.Null;
            this.options = Options.Null;
            this.message = "";
            this.maTK = 0;
            this.hoTen = "";
            this.matKhau = "";
            this.vaiTro = "";
            this.maKH = "";
            this.hoTenKH = ""; 
            this.hoTenNV = ""; 
            this.NgVL = "";
            this.chucVu = "";
            this.luong = "";
            this.maBan = "";
            this.slBan = "";
            this.loaiBan = "";
            this.tinhtrangBan = "";
            this. maMon = "";
            this.tenMon = "";
            this.gia = "";
            this.maHD = "";
            this.ngayHD = "";
            this.triGia = "";

        }
    
        public Packet(byte[] data)
        {
                this.header = (Header)BitConverter.ToInt32(data, 0);
                this.options = (Options)BitConverter.ToInt32(data, 4);
                this.maTK = BitConverter.ToInt32(data, 8);
                int hoTenLength = BitConverter.ToInt32(data, 12);
                this.hoTen = Encoding.UTF8.GetString(data, 16, hoTenLength);
                int matKhauLength = BitConverter.ToInt32(data, 16 + hoTenLength);
                this.matKhau = Encoding.UTF8.GetString(data, 20 + hoTenLength, matKhauLength);
                this.vaiTro = Encoding.UTF8.GetString(data, 20 + hoTenLength + matKhauLength, 4);
                
                int index = 24 + hoTenLength + matKhauLength;
                
                if (header == Header.KhachHang)
                {
                    this.maKH = BitConverter.ToInt32(data, index);
                    int hoTenKHLength = BitConverter.ToInt32(data, index + 4);
                    this.hoTenKH = Encoding.UTF8.GetString(data, index + 8, hoTenKHLength);
                    this.sdt = Encoding.UTF8.GetString(data, index + 8 + hoTenKHLength, 10);
                    index += 18 + hoTenKHLength;
                }
                else if (header == Header.NhanVien)
                {
                    this.hoTenNV = Encoding.UTF8.GetString(data, index, hoTenLength);
                    this.NgVL = DateTime.FromBinary(BitConverter.ToInt64(data, index + hoTenLength));
                    int chucVuLength = BitConverter.ToInt32(data, index + hoTenLength + 8);
                    this.chucVu = Encoding.UTF8.GetString(data, index + hoTenLength + 12, chucVuLength);
                    this.luong = BitConverter.ToDouble(data, index + hoTenLength + 12 + chucVuLength);
                    index += hoTenLength + 20 + chucVuLength;
                }
                else if (header == Header.Ban)
                {
                    this.maBan = BitConverter.ToInt32(data, index);
                    this.slBan = BitConverter.ToInt32(data, index + 4);
                    int loaiBanLength = BitConverter.ToInt32(data, index + 8);
                    this.loaiBan = Encoding.UTF8.GetString(data, index + 12, loaiBanLength);
                    int tinhTrangBanLength = BitConverter.ToInt32(data, index + 12 + loaiBanLength);
                    this.tinhtrangBan = Encoding.UTF8.GetString(data, index + 16 + loaiBanLength, tinhTrangBanLength);
                    index += 16 + loaiBanLength + tinhTrangBanLength;
                }
                else if (header == Header.Mon)
                {
                    this.maMon = BitConverter.ToInt32(data, index);
                    int tenMonLength = BitConverter.ToInt32(data, index + 4);
                    this.tenMon = Encoding.UTF8.GetString(data, index + 8, tenMonLength);
                    int dvtLength = BitConverter.ToInt32(data, index + 8 + tenMonLength);
                    this.dvt = Encoding.UTF8.GetString(data, index + 12 + tenMonLength, dvtLength);
                    this.gia = BitConverter.ToDouble(data, index + 12 + tenMonLength + dvtLength);
                    index += 12 + tenMonLength + dvtLength;
                }
                else if (header == Header.HoaDon)
                {
                    this.maHD = BitConverter.ToInt32(data, index);
                    this.ngayHD = DateTime.FromBinary(BitConverter.ToInt64(data, index + 4));
                    this.triGia = BitConverter.ToDouble(data, index + 12);
                    index += 20;
                }
                else if (header == Header.CTHD)
                {
                    this.maHD = BitConverter.ToInt32(data, index);
                    this.MaMon = BitConverter.ToInt32(data, index + 4);
                    this.SL = BitConverter.ToInt32(data, index + 8);
                    index += 12;
                }

                int messageLength = BitConverter.ToInt32(data, index);
                
                if (messageLength > 0)
                {
                    this.message = Encoding.UTF8.GetString(data, index + 4, messageLength);
                }
                else
                {
                    this.message = "";
                }
            }
        }

    
        public byte[] GetDataStream()
        {
            List<byte> data = new List<byte>();
            data.AddRange(BitConverter.GetBytes((int)this.header));
            data.AddRange(BitConverter.GetBytes((int)this.options));
            data.AddRange(BitConverter.GetBytes(this.maTk));
            data.AddRange(BitConverter.GetBytes(this.hoTen.Length));
            data.AddRange(Encoding.UTF8.GetBytes(this.hoTen));
            data.AddRange(BitConverter.GetBytes(this.matKhau.Length));
            data.AddRange(Encoding.UTF8.GetBytes(this.matKhau));
            data.AddRange(Encoding.UTF8.GetBytes(this.vaiTro));
            data.AddRange(BitConverter.GetBytes(this.maKH));
            data.AddRange(BitConverter.GetBytes(this.hoTenKH.Length));
            data.AddRange(Encoding.UTF8.GetBytes(this.hoTenKH));
            data.AddRange(BitConverter.GetBytes(this.sdt.Length));
            data.AddRange(Encoding.UTF8.GetBytes(this.sdt));
            data.AddRange(BitConverter.GetBytes(this.hoTenNV.Length));
            data.AddRange(Encoding.UTF8.GetBytes(this.hoTenNV));
            data.AddRange(BitConverter.GetBytes(this.NgVL.Ticks));
            data.AddRange(BitConverter.GetBytes(this.chucVu.Length));
            data.AddRange(Encoding.UTF8.GetBytes(this.chucVu));
            data.AddRange(BitConverter.GetBytes(this.luong));
            data.AddRange(BitConverter.GetBytes(this.maBan));
            data.AddRange(BitConverter.GetBytes(this.slBan));
            data.AddRange(BitConverter.GetBytes(this.loaiBan.Length));
            data.AddRange(Encoding.UTF8.GetBytes(this.loaiBan));
            data.AddRange(BitConverter.GetBytes(this.tinhtrangBan.Length));
            data.AddRange(Encoding.UTF8.GetBytes(this.tinhtrangBan));
            data.AddRange(BitConverter.GetBytes(this.maMon));
            data.AddRange(BitConverter.GetBytes(this.tenMon.Length));
            data.AddRange(Encoding.UTF8.GetBytes(this.tenMon));
            data.AddRange(BitConverter.GetBytes(this.dvt.Length));
            data.AddRange(Encoding.UTF8.GetBytes(this.dvt));
            data.AddRange(BitConverter.GetBytes(this.gia));
            data.AddRange(BitConverter.GetBytes(this.maHD));
            data.AddRange(BitConverter.GetBytes(this.ngayHD.Ticks));
            data.AddRange(BitConverter.GetBytes(this.triGia));
            data.AddRange(BitConverter.GetBytes(this.sl)); 
            if (!string.IsNullOrEmpty(this.message))
            {
                byte[] messageBytes = Encoding.UTF8.GetBytes(this.message);
                data.AddRange(BitConverter.GetBytes(messageBytes.Length));
                data.AddRange(messageBytes);
            }
            else
            {
                data.AddRange(BitConverter.GetBytes(0));
            }
            return data.ToArray();
        }
    }
    public class TaiKhoan
    {
        public int MaTK { get; set; }
        public string HoTen { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }

        // public TaiKhoan()
        // {
        //     MaTK = 0;
        //     HoTen = "";
        //     MatKhau = "";
        //     VaiTro = "";
        // }

        // public TaiKhoan(int maTK, string hoTen, string matKhau, string vaiTro)
        // {
        //     MaTK = maTK;
        //     HoTen = hoTen;
        //     MatKhau = matKhau;
        //     VaiTro = vaiTro;
        // }
    }
    public class KhachHang
    {
        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public int SoDT { get; set; }
    }
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public int NgVL { get; set; }
        public int ChucVu { get; set; }
        public int Luong { get; set; }
    }
    public class Ban
    {   
        public int MaBan { get; set; }
        public int SLBan { get; set; }
        public int LoaiBan { get; set; }
        public int TinhTrangBan { get; set; }
    }
    public class Mon
    {
        public int MaMon { get; set; }
        public string TenMon { get; set; }
        public string DVT { get; set; }
        public float Gia { get; set; }
    }
    public class HoaDon
    {
        public int MaHD { get; set; }
        public int MaNV { get; set; }
        public int MaKH { get; set; }
        public int MaBan { get; set; }
        public DateTime NgayHD { get; set; }
        public double TriGia { get; set; }
    }
    public class CTHD
    {
        public int MaHD { get; set; }
        public int MaMon { get; set; }
        public int SL { get; set; }
    }


}
