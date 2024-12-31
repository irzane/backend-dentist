namespace DentisteApp.Models.Entities
{
    public class CertificatMedical
    {
        public int CertificatMedicalID { get; set; }
        public int DossierMedicalID { get; set; }
        public DateTime DateCertificat { get; set; }
        public string? Raison { get; set; }
        public int Duree { get; set; }

    }
}
