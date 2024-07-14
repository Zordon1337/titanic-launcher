using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace titanic_launcher
{
    public class Client
    {
        [JsonPropertyName("downloads")]
        public List<string> Downloads { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("hashes")]
        public List<Hash> Hashes { get; set; }

        [JsonPropertyName("known_bugs")]
        public string KnownBugs { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("preview")]
        public bool Preview { get; set; }

        [JsonPropertyName("recommended")]
        public bool Recommended { get; set; }

        [JsonPropertyName("screenshots")]
        public List<Screenshot> Screenshots { get; set; }

        [JsonPropertyName("supported")]
        public bool Supported { get; set; }

        [JsonPropertyName("actions")]
        public List<string> Actions { get; set; }
    }

    public class Hash
    {
        [JsonPropertyName("file")]
        public string File { get; set; }

        [JsonPropertyName("md5")]
        public List<string> Md5 { get; set; }
    }

    public class Screenshot
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("src")]
        public string Src { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }
    }
}
