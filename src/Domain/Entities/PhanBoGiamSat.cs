using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PhanBoGiamSat
    {
        public BaiThi BaiThi { get; set; }
        public string MaBaiThi { get; set; }
        public GiaoVien GiaoVien { get; set; }
        public string MaGV { get; set; }
    }
}
