using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;

class Program
{
    static async Task Main()
    {
        using (HttpClient client = new HttpClient())
        {
            string url = "https://digi-api.com/api/v1/digimon";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();

                Console.WriteLine("Respuesta recibida correctamente.\n");

                // Deserializar el JSON a un objeto C#
                var result = JsonSerializer.Deserialize<DigimonResponse>(content);

                // Mostrar algunos resultados
                if (result != null && result.content != null)
                {
                    Console.WriteLine("Listado de Digimon:");
                    foreach (var digimon in result.content)
                    {

                        Console.WriteLine($"-{digimon.name}({digimon.level})");
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error en la solicitud: {e.Message}");
            }
        }
    }

    // Clases para deserializar el JSON
    public class DigimonResponse
    {
        public List<Digimon> content { get; set; }
    }

    public class Digimon
    {

         public string name { get; set; }
        public string level { get; set; }
        public string href { get; set; }
    }
}
