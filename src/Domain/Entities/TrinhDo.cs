using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TrinhDo
    {
        public string TenTrinhDo { get; set; }
        public ICollection<ThiSinh> ThiSinhs { get; set; }

    }
}
