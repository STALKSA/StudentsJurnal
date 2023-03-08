using JurnalDB.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalDB
{
    public class AppDBContext : DbContext
    {
        private const string ConnectionString = "Data Source=\"C:\\Users\\Ksy18\\OneDrive\\Рабочий стол\\ADO\\JurnalDB\\JurnalDB\\hello.db\"";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);

        }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Visit> Visits => Set<Visit>();
        public DbSet<Group> Groups => Set<Group>();
    }
}
