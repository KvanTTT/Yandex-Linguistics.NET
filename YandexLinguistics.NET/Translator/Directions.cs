using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace YandexLinguistics.NET.Translator
{
    public class Directions
    {
        [JsonPropertyName("dirs")]
        public IReadOnlyList<string> TranslatorDirections { get; set; }
    }
}