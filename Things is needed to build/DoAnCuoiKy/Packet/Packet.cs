using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketStructure
{
    //     Mô tả gói tin    -> |Độ dài của sMaTK|Độ dài của sHoTen|Độ dài của sMatKhau|Độ dài của iVaiTro|      sMaTK     |       sHoTen    |      sMatKhau     |      iVaiTro     |
    // Kích thước theo byte -> |        4       |        4        |         4         |         4        |Độ dài của sMaTK|Độ dài của sHoten|Độ dài của sMatKhau|Độ dài của iVaiTro|

    public enum VaiTroNguoiDung
    {
        NhanVien,
        QuanLy,
        Null
    }

    public class Packet
    {
        private string sMaTK;
        private string sHoTen;
        private string sMatKhau;
        private int iVaiTro;

        public Packet()
        {
            this.sMaTK = string.Empty;
            this.sHoTen = string.Empty;
            this.sMatKhau = string.Empty;
            this.iVaiTro = (int)VaiTroNguoiDung.Null;
        }

        public string MaTK
        {
            get { return this.MaTK; }
            set { this.MaTK = value; }
        }

        public string HoTen
        {
            get { return this.sHoTen; }
            set { this.sHoTen = value; }
        }

        public string MatKhau
        {
            get { return this.sMatKhau; }
            set { this.sMatKhau = value; }
        }

        public int VaiTro
        {
            get { return this.iVaiTro; }
            set { this.iVaiTro = value; }
        }

        // Đọc gói tin
        public Packet(byte[] data)
        {
            // Đọc độ dài của sMaTK ở byte đầu tiên của gói tin
            //int sMaTK_length = BitConverter.ToInt32(data, 0);

            // Đọc độ dài của sHoTen ở 4 byte tiếp theo
            int sHoTen_length = BitConverter.ToInt32(data, 0);

            // Đọc độ dài của sMatKhau ở 4 byte tiếp theo
            int sMatKhau_length = BitConverter.ToInt32(data, 4);

            // Đọc độ dài của iVaiTro ở 4 byte tiếp theo
            //int iVaiTro_length = BitConverter.ToInt32(data, 12);

            // Đọc nội dung sMaTK
            /*if (sMaTK_length > 0)
            {
                this.sMaTK = Encoding.UTF8.GetString(data, 16, sMaTK_length);
            }
            else
            {
                this.sMaTK = string.Empty;
            }*/

            // Đọc nội dung sHoTen
            if (sHoTen_length > 0)
            {
                this.sHoTen = Encoding.UTF8.GetString(data, 8, sHoTen_length);
            }
            else
            {
                this.sHoTen = string.Empty;
            }

            // Đọc nội dung của sMatKhau
            if (sMatKhau_length > 0)
            {
                this.sMatKhau = Encoding.UTF8.GetString(data, 8 + sHoTen_length, sMatKhau_length);
            }
            else
            {
                this.sMatKhau = string.Empty;
            }

            // Đọc nội dung của iVaiTro
            //this.iVaiTro = int.Parse(Encoding.UTF8.GetString(data, 16 + sMaTK_length + sHoTen_length + sMatKhau_length, 1));

        }

        // Chuyển dữ liệu thành mảng byte
        public byte[] GetDataStream()
        {
            List<byte> data = new List<byte>();

            // Thêm độ dài của sMaTK
            //data.AddRange(BitConverter.GetBytes(this.sMaTK.Length));

            // Thêm độ dài của sHoTen
            data.AddRange(BitConverter.GetBytes(Encoding.UTF8.GetByteCount(this.sHoTen)));

            // Thêm độ dài của sMatKhau
            data.AddRange(BitConverter.GetBytes(Encoding.UTF8.GetByteCount(this.sMatKhau)));

            // Thêm độ dài của iVaiTro
            //data.AddRange(BitConverter.GetBytes(1));

            // Thêm sMaTK
            //data.AddRange(Encoding.UTF8.GetBytes(this.sMaTK));

            // Thêm sHoTen
            data.AddRange(Encoding.UTF8.GetBytes(this.sHoTen));

            // Thêm sMatKhau
            data.AddRange(Encoding.UTF8.GetBytes(this.sMatKhau));

            // Thêm iVaiTro
            //data.AddRange(BitConverter.GetBytes(this.iVaiTro));

            return data.ToArray();
        }
    }
}