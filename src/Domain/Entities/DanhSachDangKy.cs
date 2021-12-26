using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DanhSachDangKy
    {
        public KhoaThi KhoaThi { get; set; }
        public string MaKT { get; set; }
        public ThiSinh ThiSinh { get; set; }
        public string SBD { get; set; }
    }
}
