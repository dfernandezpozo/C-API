using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;
using DigimonData;




class Program
{
    static async Task Main()
    {
        using HttpClient client = new HttpClient();

        Console.Write("\nDime el digimon que quieres buscar: ");
        string input = Console.ReadLine();

        string url = $"https://digi-api.com/api/v1/digimon/{input}";

        try
        {
            string json = await client.GetStringAsync(url);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            
            Digimon digi = JsonSerializer.Deserialize<Digimon>(json, options);

            InfoBasica.Mostrar(digi);
            Menu.Mostrar(digi);

            
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"Error en la solicitud: {e.Message}");
        }
    }

   
}


