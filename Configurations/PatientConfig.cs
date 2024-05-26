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
    public class PatientConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(e => e.IdPatient).HasName("IdPatient_PK");
            builder.Property(e => e.IdPatient).UseIdentityColumn();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.BirthDate).IsRequired();


            var patients = new List<Patient>();

            patients.Add(new Patient
            {
                IdPatient = 1,
                FirstName = "Test",
                LastName = "Kowalski",
                BirthDate = DateTime.Now.AddYears(-25)
            });

            patients.Add(new Patient
            {
                IdPatient = 2,
                FirstName = "Test1",
                LastName = "Janowski",
                BirthDate = DateTime.Now.AddYears(-21)
            });

            patients.Add(new Patient
            {
                IdPatient = 3,
                FirstName = "Test2",
                LastName = "Testerski",
                BirthDate = DateTime.Now.AddYears(-27)
            });

            patients.Add(new Patient
            {
                IdPatient = 4,
                FirstName = "Test3",
                LastName = "Smothie",
                BirthDate = DateTime.Now.AddYears(-22)
            });

            patients.Add(new Patient
            {
                IdPatient = 5,
                FirstName = "Test4",
                LastName = "Zawiejski",
                BirthDate = DateTime.Now.AddYears(-50)
            });

            patients.Add(new Patient
            {
                IdPatient = 6,
                FirstName = "Test5",
                LastName = "Testerowski",
                BirthDate = DateTime.Now.AddYears(-29)
            });

            patients.Add(new Patient
            {
                IdPatient = 7,
                FirstName = "Test6",
                LastName = "Pacjentowy",
                BirthDate = DateTime.Now.AddYears(-54)
            });

            patients.Add(new Patient
            {
                IdPatient = 8,
                FirstName = "Test7",
                LastName = "Testerowski",
                BirthDate = DateTime.Now.AddYears(-67)
            });

            builder.HasData(patients);
        }
    }
}