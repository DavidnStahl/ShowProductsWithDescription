using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MediafyAssignment.Models
{
    public class Product
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("fromPrice")]
        public string FromPrice { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("NumberOfTimesDescriptionBeenViewed")]
        public string NumberOfTimesDecriptionBeenViewed { get; set; }
    }
}
