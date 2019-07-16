using Newtonsoft.Json;
using System.Collections.Generic;

namespace GhostSharp.Entities
{
    public class UserResponse
    {
        [JsonProperty("users")]
        public List<User> Users { get; set; }
    }
}
