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

        // Permitimos al usuario escribrir el digmon que desea buscar
        // Si el usuario pone un  número enseñaría el digimon cuyo id corresponda
        // Al número introducido por el usuario.
        Console.Write("\n🔍 Dime el Digimon que quieres buscar (nombre/número): ");

        string input = Console.ReadLine();

        string url = $"https://digi-api.com/api/v1/digimon/{input}";

        try
        {   //Hacemos la solicitud web y guardamos la respuesta en json
            string json = await client.GetStringAsync(url);

            // Establecemos que da igual si los datos obtenidos en json están
            // en mayúscula o minúscula
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // Convertimos el objeto json en un objeto de c# tipo Digimon
            Digimon digi = JsonSerializer.Deserialize<Digimon>(json, options);

            // Llama al método mostrar de la clase InfoBasica
            InfoBasica.Mostrar(digi);
            // Llama al método mostrar del Menu
            Menu.Mostrar(digi);


        } // Si el usuario escribe un nombre inventado le mostrará lo siguiente por consola:
        catch (HttpRequestException)
        {
            Console.WriteLine("No disponemos de la información de ese Digimon");
        }
    }


}


