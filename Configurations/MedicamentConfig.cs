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
    public class MedicamentConfig : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(e => e.IdMedicament).HasName("IdMedicament_PK");
            builder.Property(e => e.IdMedicament).UseIdentityColumn();

            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Type).HasMaxLength(100).IsRequired();


            var medicaments = new List<Medicament>();

            medicaments.Add(new Medicament
            {
                IdMedicament = 1,
                Name = "Aspiryna",
                Description = "Super lek dla potrzebujacych.",
                Type = "NONE"
            });

            medicaments.Add(new Medicament
            {
                IdMedicament = 2,
                Name = "Lek2",
                Description = "Test2",
                Type = "NONE_1"
            });

            medicaments.Add(new Medicament
            {
                IdMedicament = 3,
                Name = "Lek3",
                Description = "Test3",
                Type = "NONE_2"
            });

            builder.HasData(medicaments);
        }
    }
}