﻿using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Persistence.Repositories
{
    public class PhongThiRepository : EFRepository<PhongThi>, IPhongThiRepository
    {
        public PhongThiRepository(CenterContext context) : base(context)
        {
        }
    }
}