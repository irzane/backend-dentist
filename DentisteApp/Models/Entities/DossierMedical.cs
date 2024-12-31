using System.Text.RegularExpressions;

namespace DentisteApp.Models.Entities
{
    public class DossierMedical
    {
        public int DossierMedicalID { get; set; }
        public int PatientID { get; set; }
        public virtual Patient? Patient { get; set; }

        public virtual ICollection<Ordonnance>? Ordonnances { get; set; }
        public virtual ICollection<Paiement>? Paiements { get; set; }
        public virtual ICollection<Acte>? Actes { get; set; }
        public virtual ICollection<Facture>? Factures { get; set; }
        public virtual ICollection<FeuilleDeSoin>? FeuillesDeSoin { get; set; }
        public virtual ICollection<CertificatMedical>? CertificatsMedicaux { get; set; }
        public virtual ICollection<Imagerie>? Imageries { get; set; }
    }
}
