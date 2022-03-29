using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjApiRest29_03_2022.Model;

namespace ProjApiRest29_03_2022.Data
{
    public class ProjApiRest29_03_2022Context : DbContext
    {
        public ProjApiRest29_03_2022Context (DbContextOptions<ProjApiRest29_03_2022Context> options)
            : base(options)
        {
        }

        public DbSet<ProjApiRest29_03_2022.Model.Client> Client { get; set; }
    }
}
