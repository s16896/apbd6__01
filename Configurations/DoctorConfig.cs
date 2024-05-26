using apbd6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apbd6.Models;

namespace apbd6.Configurations
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.IdDoctor).HasName("Doctor_PK");
            builder.Property(e => e.IdDoctor).UseIdentityColumn();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();

            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.HasIndex(e => e.Email).IsUnique();

            // adding data
            var doctors = new List<Doctor>();

            doctors.Add(new Doctor
            {
                IdDoctor = 1,
                FirstName = "Tomas",
                LastName = "Ericson",
                Email = "TomasEricson@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 2,
                FirstName = "John",
                LastName = "Tester",
                Email = "JohnTester@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 3,
                FirstName = "michai",
                LastName = "Kowalski",
                Email = "MichaiKowalski@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 4,
                FirstName = "Patio",
                LastName = "Kowalski",
                Email = "SergioPsychiatrist@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 5,
                FirstName = "Pablo",
                LastName = "Escobar",
                Email = "PabloEscobar@gmail.com"
            });

            doctors.Add(new Doctor
            {
                IdDoctor = 6,
                FirstName = "Thomas",
                LastName = "Test",
                Email = "ThomasTest@gmail.com"
            });

            builder.HasData(doctors);
        }
    }
}