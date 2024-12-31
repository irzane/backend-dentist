namespace DentisteApp.Models.Entities
{
    public class Acte
    {
        public int ActeID { get; set; }
        public int DossierMedicalID { get; set; }
        public string? TypeActe { get; set; }
        public DateTime DateActe { get; set; }
        public string? Description { get; set; }

    }
}
