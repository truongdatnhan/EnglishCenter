using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PhongThi
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int SoLuong { get; set; }
        public TrinhDo TrinhDo { get; set; }
        public string TenTrinhDo { get; set; }
        public KhoaThi KhoaThi { get; set; }
        public string MaKT { get; set; }
    }
}
