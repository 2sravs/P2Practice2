using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainBowSchoolEF.Models;

namespace RainBowSchoolEF.Data
{
    public class RainBowSchoolEFContext : DbContext
    {
        public RainBowSchoolEFContext (DbContextOptions<RainBowSchoolEFContext> options)
            : base(options)
        {
        }

        public DbSet<RainBowSchoolEF.Models.School> School { get; set; } = default!;
        public DbSet<RainBowSchoolEF.Models.School> Students { get; set; } = default!;
        public DbSet<RainBowSchoolEF.Models.School> Class { get; set; } = default!;
    }
}
