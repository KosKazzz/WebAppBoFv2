using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppBoFv2.Models;

namespace WebAppBoFv2.Data
{
    public class WebAppBoFv2Context : DbContext
    {
        public WebAppBoFv2Context (DbContextOptions<WebAppBoFv2Context> options)
            : base(options)
        {
            Database.EnsureCreated();//M
        }

        public DbSet<WebAppBoFv2.Models.Company> Company { get; set; }

        public DbSet<WebAppBoFv2.Models.User> User { get; set; }
        //public DbSet<User> Users { get; set; }//Me
        public DbSet<Role> Roles { get; set; }//M
        protected override void OnModelCreating(ModelBuilder modelBuilder)//M full method
        {

            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminEmail = "admin@mail.ru";
            string adminLogin = "admin";
            string adminPassword = "123456";

            // add roles
            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            User adminUser = new User { Id = 1, EmailReg = adminEmail, Password = adminPassword, Login=adminLogin, RoleId = adminRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }
    }
}
