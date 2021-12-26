using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PhongThi
    {
        public string MaPhongThi { get; set; }
        public string TenPhong { get; set; }
        public string TrinhDo { get; set; }
        public string MaPhongThiTheoYCNV { get; set; }
        public KhoaThi KhoaThi { get; set; }
        public string MaKhoaThi { get; set; }
    }
}
