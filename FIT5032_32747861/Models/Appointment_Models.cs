using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_32747861.Models
{
    public partial class Appointment_Models : DbContext
    {
        public Appointment_Models()
            : base("name=Appointment_Models")
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Session)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.DoctorName)
                .IsUnicode(false);
        }
    }
}
