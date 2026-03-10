using ConsumerAdviceApi.Services;

var service = new AdviceApiService();

Console.WriteLine("Iniciando requisição para obter conselho...");

var resultado = await service.ObterConselhoAsync();

if (!string.IsNullOrEmpty(resultado))
{
  Console.WriteLine("\nConselho de Hoje:");
  Console.WriteLine(resultado);
}

Console.WriteLine("\n fim da requisição!");