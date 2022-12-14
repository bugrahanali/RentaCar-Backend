using Entities.Concrete;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;

namespace DataAccess.Concrete.EntityFramework
{       
    //Context :Db tabloları ile proje classlarını bağlamak
    public class RentaCarContext:DbContext //DbContext kendiliğinden var yükleyince geliyor
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\ProjectsV13;Database=RentaCarContext;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<OperationClaim> operationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }







    }
}
