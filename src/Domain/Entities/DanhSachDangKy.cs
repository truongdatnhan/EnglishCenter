using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DanhSachDangKy
    {
        public ICollection<ThiSinh> ThiSinhs { get; set; }
        public string SBD { get; set; }
        public ICollection<KhoaThi> KhoaThis { get; set; }
        public string MaKT { get; set; }
    }
}
