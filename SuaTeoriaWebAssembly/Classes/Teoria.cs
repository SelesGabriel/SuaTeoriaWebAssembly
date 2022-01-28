namespace SuaTeoriaWebAssembly.Classes
{
    public class Teoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Categoria Categoria { get; set; }
        public Obra Obra { get; set; }
        public string ImagemTitulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public Usuario Usuario { get; set; }
    }
}
