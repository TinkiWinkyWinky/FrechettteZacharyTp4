using System.ComponentModel.DataAnnotations;

namespace FrechettteZacharyTp4.Models
{
    public class Abonnements
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Type { get; set; } = default!;
        public float PrixMensuel { get; set; }
        public int RabaisPourcentage { get; set; }
    }
}
