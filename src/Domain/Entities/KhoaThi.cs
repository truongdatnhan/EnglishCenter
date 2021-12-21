using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class KhoaThi
    {
        public string MaKT { get; set; }
        public string TenKhoa { get; set; }
        public DateTime NgayThi { get; set; }
        public ICollection<ThiSinh> ThiSinhs { get; set; }
    }
}
