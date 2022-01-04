using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Persistence.Repositories
{
    public class SoBaoDanhRepository : EFRepository<SoBaoDanh>, ISoBaoDanhRepository
    {
        public SoBaoDanhRepository(CenterContext context) : base(context)
        {
        }
    }
}