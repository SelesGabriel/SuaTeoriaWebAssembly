using System.ComponentModel.DataAnnotations;

namespace SuaTeoriaWebAssembly.Models
{
    public class Usuario
    {
        public int Id { get; set;}
        [Required(ErrorMessage ="Nome deve ser preenchido.")]
        [MinLength(1)]
        [MaxLength(50, ErrorMessage ="A quantidade máxima de caracteres é de 50.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Usuário deve ser preenchido.")]
        [MaxLength(30, ErrorMessage = "A quantidade máxima de caracteres é de 30.")]
        public string User { get; set; }
        [EmailAddress(ErrorMessage ="Informe um email válido.")]
        [Required(ErrorMessage ="Informe um email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha deve ser preenchido.")]
        [MinLength(6, ErrorMessage = "Coloque mais caracteres na sua senha.")]
        public string Senha { get; set; }
        public string? Foto { get; set; }
    }
}
