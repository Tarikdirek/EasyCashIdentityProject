using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-P6VL3T2;initial catalog=EasyCashDb;integrated Security=true");
        }

        public DbSet<CostumerAccount> CostumerAccounts { get; set; }
        public DbSet<CostumerAccountProcess> CostumerAccountProcesses { get; set; }

    }
}
