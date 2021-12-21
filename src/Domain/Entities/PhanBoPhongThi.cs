using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PhanBoPhongThi
    {
        public PhongThi PhongThi { get; set; }
        public string MaPhong { get; set; }
        public GiaoVien GiaoVien { get; set; }
        public string MaGV { get; set; }
    }
}
