using System.ComponentModel.DataAnnotations;

namespace FrechettteZacharyTp4.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string Nom { get; set; } = default!;
        public int Age { get; set; }
        public string Courriel { get; set; } = default!;
        [MaxLength(10)]
        public string? NoTelephone { get; set; }
        public int AbonnementId { get; set; }
        public Abonnements Abonnement { get; set; } = default!;
    }
}
