using System.Text.Json.Serialization;

namespace ConsumerAdviceApi.Models
{
  public class AdviceResponse
  {
    [JsonPropertyName("slip")]
    public AdviceItem? Slip { get; set; }
  }

  public class AdviceItem
  {
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("advice")]
    public string? Advice { get; set; }
  }
}