using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models.Cards
{

    public class Cards
    {
        public ICollection Data { get; set; }
        [JsonPropertyName("total_card")]
        public uint TotalCards { get; set; }
    }
}