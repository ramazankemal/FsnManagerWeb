using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class SqlServerContext:DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options):base(options)
        {

        }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-VH5VO8P;Initial Catalog=fsnweb;Integrated Security=True;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Component>().HasKey(p => p.ComponentId);
            modelBuilder.Entity<Component>().Property(p => p.Code).HasMaxLength(25).IsRequired(true);
            modelBuilder.Entity<Component>().Property(p => p.Description).HasMaxLength(100);
            modelBuilder.Entity<Component>().Property(p => p.IsDeleted).IsRequired();
            
            modelBuilder.Entity<Component>()
                .HasData(
                new Component
                {
                    ComponentId = Guid.NewGuid(),
                    Code = "F-EN-E23-01",
                    Description = "PASIFIC KAĞIT HAVLU - FASON",
                    IsDeleted = false
                },
                new Component
                {
                    ComponentId = Guid.NewGuid(),
                    Code = "F-EN-E77-02",
                    Description = "35 LT KOVA ÇEMBER",
                    IsDeleted = false
                });
        }

        public DbSet<Component> Components { get; set; }
    }
}
