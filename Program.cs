// Ejercicio: Listar los productos provenientes de una API REST externa de mock.io
// URL del recurso: GET https://68ffe1e9e02b16d1753f8cfe.mockapi.io/api/v1/productos
// Ejemplo de formato de la respuesta JSON:
/*
[
    {"createdAt":"2025-10-27T17:00:32.230Z","nombre":"Small Wooden Bike","precio":"44.10","id":"1"},
    {"createdAt":"2025-10-27T14:10:51.173Z","nombre":"Unbranded Gold Ball","precio":"995.39","id":"2"}
]
*/

using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// Creamos un Dto para mapear los productos, es necesario para serializar y deserializar
// La respuesta JSON
public class ProductoDto
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("nombre")]
    public string? NombreProducto { get; set; }

    [JsonPropertyName("precio")]
    public string? Precio { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        // URL de la API REST externa
        string apiUrl = "https://68ffe1e9e02b16d1753f8cfe.mockapi.io/api/v1/productos";

        using HttpClient httpClient = new HttpClient();
        HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            List<ProductoDto>? productos = JsonSerializer.Deserialize<List<ProductoDto>>(json);
            Console.WriteLine($"Lista de Productos {productos!.Count}:");

            // Listar los productos
            foreach (ProductoDto producto in productos)
            {
                Console.WriteLine($"ID: {producto.Id}");
                Console.WriteLine($"NombreProducto: {producto.NombreProducto}");
                Console.WriteLine($"Precio: {producto.Precio}");
                Console.WriteLine($"Fecha de Creación: {producto.CreatedAt}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine($"Error al obtener los productos: {response.StatusCode}");
        }
    }
}
