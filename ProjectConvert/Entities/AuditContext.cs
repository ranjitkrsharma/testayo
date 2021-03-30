//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ConverterAPI.Entities
//{
//    public class AuditContext : DbContext
//    {
//        public AuditContext(DbContextOptions<AuditContext> options) : base(options)
//        {
//            Database.Migrate();
//        }
//        public DbSet<UserActions> UserAction { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<UserActions>().HasData(new UserActions
//            {
//                ID = Guid.NewGuid(),
//                Username = "Bob",
//                FromUnit = "KM",
//                Initial = 1.0,
//                ToUnit = "Mile",
//                Value = 0.621371,
//                DateTimeStamp = DateTime.Now
//            }, new UserActions
//            {
//                ID = Guid.NewGuid(),
//                Username = "John",
//                FromUnit = "Mile",
//                Initial = 0.621371,
//                ToUnit = "KM",
//                Value = 1.0,
//                DateTimeStamp = DateTime.Now
//            });
//        }
//    }
//}
