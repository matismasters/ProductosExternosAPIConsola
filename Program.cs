// Ejercicio: Listar los productos provenientes de una API REST externa de mock.io
// URL del recurso: GET https://68ffe1e9e02b16d1753f8cfe.mockapi.io/api/v1/productos
// Ejemplo de formato de la respuesta JSON:
/*
[
    {"createdAt":"2025-10-27T17:00:32.230Z","nombre":"Small Wooden Bike","precio":"44.10","id":"1"},
    {"createdAt":"2025-10-27T14:10:51.173Z","nombre":"Unbranded Gold Ball","precio":"995.39","id":"2"}
]
*/

using ProductosExternosAPIConsola;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        IServicioProductos servicioProductos = new ServicioProductos();
        //await servicioProductos.CrearProducto();
        //await servicioProductos.ListarProductos();
        //await servicioProductos.BuscarMostrar("1");
    }
}
