using System.ComponentModel.DataAnnotations;

namespace Magma3_Back.ViewModels
{
    public class NotaViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Preco deve ser maior que zero")]
        public decimal Preco { get; set; }

        [Required]
        public DateTime Data { get; set; }

    }
}
