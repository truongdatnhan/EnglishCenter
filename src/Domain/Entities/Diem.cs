using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Diem
    {
        public BaiThi BaiThi { get; set; }
        public string MaBaiThi { get; set; }
        public PhanThi PhanThi { get; set; }
        public string TenPhanThi { get; set; }
    }
}
