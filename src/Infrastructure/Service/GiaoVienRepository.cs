using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Persistence.Repositories
{
    public class GiaoVienRepository : EFRepository<GiaoVien>, IGiaoVienRepository
    {
        public GiaoVienRepository(CenterContext context) : base(context)
        {
        }
    }
}