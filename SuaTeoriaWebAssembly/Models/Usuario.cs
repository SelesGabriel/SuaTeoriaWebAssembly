namespace SuaTeoriaWebAssembly.Models
{
    public class Usuario
    {
        Guid id { get; }
        public string nome { get; set; }
        public string user { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}
