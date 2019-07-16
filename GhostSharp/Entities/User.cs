using Newtonsoft.Json;
using System.Collections.Generic;

namespace GhostSharp.Entities
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("profile_image")]
        public string ProfileImage { get; set; }
        [JsonProperty("cover_image")]
        public string CoverImage { get; set; }
        [JsonProperty("bio")]
        public string Bio { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("facebook")]
        public string Facebook { get; set; }
        [JsonProperty("twitter")]
        public string Twitter { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}