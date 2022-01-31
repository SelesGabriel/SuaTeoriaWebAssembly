namespace SuaTeoriaWebAssembly.Models
{
    public class Teoria
    {
        public Guid Id { get; }
        public string Titulo { get; }
        public Categoria Categoria { get; }
        public Obra Obra { get; }
        public string ImagemTitulo { get; }
        public string Conteudo { get; }
        public DateTime DataCriacao { get; }
        public Usuario Usuario { get; }
    }
}
