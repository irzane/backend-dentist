namespace DentisteApp.Models.Entities
{
    public class Paiement
    {
        public int PaiementID { get; set; }
        public DateTime DatePaiement { get; set; }
        public decimal Montant { get; set; }
        public string? MoyenPaiement { get; set; }

    }
}
