using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using KUSYS.Core.Models;
using KUSYS.Data.Configurations;

namespace KUSYS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

       public DbSet<Students> Students { get; set; }
       public DbSet<Students> User { get; set; }
       public DbSet<Course>  Courses  { get; set; }
       public DbSet<StudentCourse>   StudentCourses  { get; set; }

        /// <summary>
        /// Person deneme amaçlı bu şekilde yapıldı normalde burayı doldurmamak gerekir configuration ve seedleri oluşturup burdan çağırmamız lazım...!!
        /// </summary>
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
             modelBuilder.ApplyConfiguration(new UserConfiguration());

          

            
          
        }
    }
}
