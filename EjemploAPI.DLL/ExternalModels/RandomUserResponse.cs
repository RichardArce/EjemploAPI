using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MiPrimeraAPI.DAL.Entidades.External
{
    public record RandomUserResponse
    {
        [JsonPropertyName("results")]
        public List<UserResult> Results { get; init; } = new();

        [JsonPropertyName("info")]
        public ResponseInfo Info { get; init; } = new();
    }

    public record UserResult
    {
        [JsonPropertyName("gender")]
        public string Gender { get; init; } = string.Empty;

        [JsonPropertyName("name")]
        public Name Name { get; init; } = new();

        [JsonPropertyName("location")]
        public Location Location { get; init; } = new();

        [JsonPropertyName("email")]
        public string Email { get; init; } = string.Empty;

        [JsonPropertyName("login")]
        public Login Login { get; init; } = new();

        [JsonPropertyName("dob")]
        public DateInfo Dob { get; init; } = new();

        [JsonPropertyName("registered")]
        public DateInfo Registered { get; init; } = new();

        [JsonPropertyName("phone")]
        public string Phone { get; init; } = string.Empty;

        [JsonPropertyName("cell")]
        public string Cell { get; init; } = string.Empty;

        [JsonPropertyName("id")]
        public Id Id { get; init; } = new();

        [JsonPropertyName("picture")]
        public Picture Picture { get; init; } = new();

        [JsonPropertyName("nat")]
        public string Nat { get; init; } = string.Empty;
    }

    public record Name
    {
        [JsonPropertyName("title")]
        public string Title { get; init; } = string.Empty;

        [JsonPropertyName("first")]
        public string First { get; init; } = string.Empty;

        [JsonPropertyName("last")]
        public string Last { get; init; } = string.Empty;
    }

    public record Location
    {
        [JsonPropertyName("street")]
        public Street Street { get; init; } = new();

        [JsonPropertyName("city")]
        public string City { get; init; } = string.Empty;

        [JsonPropertyName("state")]
        public string State { get; init; } = string.Empty;

        [JsonPropertyName("country")]
        public string Country { get; init; } = string.Empty;

        // Postcode can be number or string in different responses — use JsonElement to accept both.
        [JsonPropertyName("postcode")]
        public JsonElement Postcode { get; init; }

        [JsonPropertyName("coordinates")]
        public Coordinates Coordinates { get; init; } = new();

        [JsonPropertyName("timezone")]
        public Timezone Timezone { get; init; } = new();
    }

    public record Street
    {
        [JsonPropertyName("number")]
        public int Number { get; init; }

        [JsonPropertyName("name")]
        public string Name { get; init; } = string.Empty;
    }

    public record Coordinates
    {
        [JsonPropertyName("latitude")]
        public string Latitude { get; init; } = string.Empty;

        [JsonPropertyName("longitude")]
        public string Longitude { get; init; } = string.Empty;
    }

    public record Timezone
    {
        [JsonPropertyName("offset")]
        public string Offset { get; init; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; init; } = string.Empty;
    }

    public record Login
    {
        [JsonPropertyName("uuid")]
        public string Uuid { get; init; } = string.Empty;

        [JsonPropertyName("username")]
        public string Username { get; init; } = string.Empty;

        [JsonPropertyName("password")]
        public string Password { get; init; } = string.Empty;

        [JsonPropertyName("salt")]
        public string Salt { get; init; } = string.Empty;

        [JsonPropertyName("md5")]
        public string Md5 { get; init; } = string.Empty;

        [JsonPropertyName("sha1")]
        public string Sha1 { get; init; } = string.Empty;

        [JsonPropertyName("sha256")]
        public string Sha256 { get; init; } = string.Empty;
    }

    public record DateInfo
    {
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; init; }

        [JsonPropertyName("age")]
        public int Age { get; init; }
    }

    public record Id
    {
        [JsonPropertyName("name")]
        public string Name { get; init; } = string.Empty;

        [JsonPropertyName("value")]
        public string? Value { get; init; }
    }

    public record Picture
    {
        [JsonPropertyName("large")]
        public string Large { get; init; } = string.Empty;

        [JsonPropertyName("medium")]
        public string Medium { get; init; } = string.Empty;

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; init; } = string.Empty;
    }

    public record ResponseInfo
    {
        [JsonPropertyName("seed")]
        public string Seed { get; init; } = string.Empty;

        [JsonPropertyName("results")]
        public int Results { get; init; }

        [JsonPropertyName("page")]
        public int Page { get; init; }

        [JsonPropertyName("version")]
        public string Version { get; init; } = string.Empty;
    }
}