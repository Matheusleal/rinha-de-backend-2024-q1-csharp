using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

using RinhaBackEnd.Crebidos.Attributes;

namespace RinhaBackEnd.Crebidos.Modules.Client.DTOs;

public class AddTransactionOututDto
{
    [Required]
    [MinValue]
    [JsonPropertyName("limite")]
    public int Limit { get; set; }

    [Required]
    [MinValue]
    [JsonPropertyName("saldo")]
    public int Balance { get; set; }
}
