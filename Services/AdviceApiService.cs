using System.Text.Json;
using ConsumerAdviceApi.Models;

namespace ConsumerAdviceApi.Services
{
  public class AdviceApiService
  {
    private readonly HttpClient _httpClient = new HttpClient();

    public async Task<string> ObterConselhoAsync()
    {

      string url = "https://api.adviceslip.com/advice";

      var response = await _httpClient.GetStringAsync(url);

      var data = JsonSerializer.Deserialize<AdviceResponse>(response);


      return data?.Slip?.Advice ?? "Nenhum conselho encontrado.";
    }
  }
}