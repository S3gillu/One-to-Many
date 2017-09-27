using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace One_To_Many.Models
{
    public class StandardContext : DbContext
    {

        public StandardContext() : base("Stand")
        {



        }
        public DbSet<Stuu> Students { get; set; }

        public DbSet<Standard> Courses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //one-to-many 
            modelBuilder.HasDefaultSchema("Singh");
            modelBuilder.Entity<Stuu>()
                         .HasKey(e => e.StudentId)
                        .HasRequired<Standard>(s => s.Standard)
                        .WithMany(s => s.Students)
                        .HasForeignKey(s => s.StandardId);

            modelBuilder.Entity<Stuu>().Property(p => p.StudentName)
              .IsRequired()
              .HasMaxLength(50);

            modelBuilder.Entity<Standard>().Property(p => p.Description)
           .IsRequired()
           .HasMaxLength(200);


        }



    }
}