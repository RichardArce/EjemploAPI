using System.Text.Json.Serialization;

namespace MiPrimeraAPI.DAL.Entidades.External
{
    public record RatingDto
    {
        [JsonPropertyName("rate")]
        public decimal Rate { get; init; }

        [JsonPropertyName("count")]
        public int Count { get; init; }
    }

    public record ProductResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("title")]
        public string Title { get; init; } = string.Empty;

        [JsonPropertyName("price")]
        public decimal Price { get; init; }

        [JsonPropertyName("description")]
        public string Description { get; init; } = string.Empty;

        [JsonPropertyName("category")]
        public string Category { get; init; } = string.Empty;

        [JsonPropertyName("image")]
        public string Image { get; init; } = string.Empty;

        [JsonPropertyName("rating")]
        public RatingDto? Rating { get; init; }
    }
}