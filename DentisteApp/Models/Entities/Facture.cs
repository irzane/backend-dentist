namespace DentisteApp.Models.Entities
{
    public class Facture
    {
        public int FactureID { get; set; }
        public DateTime DateFacture { get; set; }
        public decimal MontantTotal { get; set; }
        public string? EtatPaiement { get; set; }

    }
}
