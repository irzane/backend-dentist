namespace DentisteApp.Models.Entities
{
    public class Ordonnance
    {
        public int OrdonnanceID { get; set; }
        public DateTime DateOrdonnance { get; set; }
        public string? Medicaments { get; set; }

    }
}
