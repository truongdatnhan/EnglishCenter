using Domain.Entities;
using System.Collections.Generic;

namespace EnglishCenter.Models
{
    public class DanhSachViewModel
    {
        public IEnumerable<SoBaoDanh> SBDs { get; set; }
    }
}
