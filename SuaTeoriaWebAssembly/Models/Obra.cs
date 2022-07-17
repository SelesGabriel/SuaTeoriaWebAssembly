namespace SuaTeoriaWebAssembly.Models
{
    public class Obra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdCategoria { get; set; }
        public string ImagemObra { get; set; }
        public string Descricao{ get; set; }
    }
}
