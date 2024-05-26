using apbd6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd6.Models
{
    public class PrescriptionMedicament
    {
        public int IdMedicament { get; set; }
        public int IdPrescription { get; set; }
        public int Dose { get; set; }
        public string Details { get; set; }


        public virtual Medicament IdMedicamentNav { get; set; }
        public virtual Prescription IdPrescriptionNav { get; set; }
    }
}