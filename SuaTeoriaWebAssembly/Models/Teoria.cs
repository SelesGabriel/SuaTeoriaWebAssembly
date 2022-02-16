namespace SuaTeoriaWebAssembly.Models
{
    public class Teoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string ImagemTitulo { get; set; }
        public DateTime DataCriacao { get; set;} = DateTime.Now;
        public int IdCategoria { get; set; }
        public int IdObra { get; set; }
        public int IdUsuario { get; set; }
        public string NovaObra { get; set; }
    }
}
