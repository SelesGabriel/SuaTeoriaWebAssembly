using SuaTeoriaWebAssembly.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

public class TopUsuario
{
    [JsonPropertyName("quantidade")]
    public int Quantidade { get; set; }
    [JsonPropertyName("user")]
    public Usuario? Usuario { get; set; }
}
