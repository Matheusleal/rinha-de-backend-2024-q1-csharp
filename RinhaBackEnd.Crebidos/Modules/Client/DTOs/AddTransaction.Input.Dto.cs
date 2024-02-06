using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

using RinhaBackEnd.Crebidos.Attributes;

namespace RinhaBackEnd.Crebidos.Modules.Client.DTOs;

public class AddTransactionInputDto
{
    [Required]
    [MinValue]
    [JsonPropertyName("valor")]
    public int Value { get; set; }

    [Required]
    [JsonPropertyName("tipo")]
    public char Type { get; set; }

    [Required]
    [MinLength(1)]
    [MaxLength(10)]
    [JsonPropertyName("descricao")]
    public string Description { get; set; } = string.Empty!;
}
