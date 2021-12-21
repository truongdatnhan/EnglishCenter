using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ThamGiaDuThi
    {
        public ThiSinh ThiSinh { get; set; }
        public string SBD { get; set; }
        public PhongThi PhongThi { get; set; }
        public string MaPhong { get; set; }
    }
}
