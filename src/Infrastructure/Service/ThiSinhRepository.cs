using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Persistence.Repositories
{
    public class ThiSinhRepository : EFRepository<ThiSinh>, IThiSinhRepository
    {
        public ThiSinhRepository(CenterContext context) : base(context)
        {
        }
    }
}