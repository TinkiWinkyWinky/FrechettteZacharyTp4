using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FrechettteZacharyTp4.ViewModels
{
    public class ClientsCreateVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le champ Nom est obligatoire.")]
        public string Nom { get; set; } = default!;
        [Required(ErrorMessage = "Le champ Âge est obligatoire.")]
        [Range(20, 75, ErrorMessage = "L'âge doit être compris entre 20 et 75 ans.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Le champ Courriel est obligatoire.")]
        [EmailAddress(ErrorMessage = "Le format du courriel est incorrect.")]
        public string Courriel { get; set; } = default!;
        [Required(ErrorMessage = "Le champ Numéro de téléphone est obligatoire.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Le numéro de téléphone doit comporter exactement 10 chiffres.")]
        public string? NoTelephone { get; set; }
        [Required(ErrorMessage = "Le champ Type d'abonnement est obligatoire.")]
        public int AbonnementId { get; set; }
        public List<SelectListItem>? Abonnement { get; set; }
    }
}
