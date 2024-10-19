using Application.ViewModals;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence;
using Persistence.Context;

namespace Persistence.Context
{
    public class AppDbContext : DbContext //inherit by installing Microsoft.EntityFrameworkCore
    {
        public DbSet<Spot> Spot { get; set; }
        public DbSet<Flow> Flow { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SPOT_DB;Trusted_Connection=True; Encrypt = False; TrustServerCertificate = False;", null);

        }
     
    }
}
