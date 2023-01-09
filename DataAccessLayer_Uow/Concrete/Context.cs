using EntityLayer_Uow.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_Uow.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-FJT4L6QM;initial catalog=DbUnitOfWork;integrated security=true");
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<ProcessDetail> ProcessDetails { get; set; }
    }
}
