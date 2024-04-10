using System.ComponentModel.DataAnnotations;

namespace FrechettteZacharyTp4.ViewModels
{
    public class ClientsInfoVM
    {
        public int Id { get; set; }
        public string Nom { get; set; } = default!;
        public int Age { get; set; }
        public string Courriel { get; set; } = default!;
        [MaxLength(10)]
        public string? NoTelephone { get; set; }
        public string Type { get; set; } = default!;
    }
}
