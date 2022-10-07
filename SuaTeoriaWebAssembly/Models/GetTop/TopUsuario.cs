using SuaTeoriaWebAssembly.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

public class TopUsuario
{
    [JsonPropertyName("idUsuario")]
    public int IdUsuario { get; set; }
    [JsonPropertyName("quantidade")]
    public int Quantidade { get; set; }
    [JsonPropertyName("user")]
    public Usuario? Usuario { get; set; }
}
