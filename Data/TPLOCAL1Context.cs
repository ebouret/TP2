using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TPLOCAL1.Models;

namespace TPLOCAL1.Data
{
    public class TPLOCAL1Context : DbContext
    {
        public TPLOCAL1Context (DbContextOptions<TPLOCAL1Context> options)
            : base(options)
        {
        }

        public DbSet<TPLOCAL1.Models.Form> Form { get; set; } = default!;
    }
}
