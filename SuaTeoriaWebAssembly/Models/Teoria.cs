using System.ComponentModel.DataAnnotations;

namespace SuaTeoriaWebAssembly.Models
{
    public class Teoria
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Titulo { get; set; }
        [Required]
        public string Conteudo { get; set; }
        [Required]
        public string ImagemTitulo { get; set; }
        public DateTime DataCriacao { get; set;} = DateTime.UtcNow;
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        public int IdObra { get; set; }
        public int IdUsuario { get; set; }
        public string NovaObra { get; set; }
    }
}
