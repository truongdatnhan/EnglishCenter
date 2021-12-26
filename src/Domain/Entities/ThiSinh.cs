using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ThiSinh
    {
        public string SBD { get; set; }
        public string HoTen { get; set; }
        public string CMND { get; set; }
        public string NoiSinh { get; set; }
        public Gender GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string NoiCap { get; set; }
        public DateTime NgayCap { get; set; }
        public string Email { get; set; }
        public TrinhDo TrinhDo { get; set; }
        public string TenTrinhDo { get; set; }
        public ICollection<KhoaThi> KhoaThis { get; set; }
        public ICollection<DanhSachDangKy> DanhSachDangKi { get; set; }
    }
}
