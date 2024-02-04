using System.Text.Json;

namespace PizzaPlace.Clients
{
    public static class ExtenDepuracion
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, options);
    }
}
