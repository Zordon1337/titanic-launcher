using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Net;
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
        public bool isInstalled()
        {
            if(!Directory.Exists("./clients"))
            {
                Directory.CreateDirectory("./clients");
                return false;
            }
            if (!Directory.Exists($"./clients/{this.Name}"))
            {
                return false;
            }
            // shit check, but i have no idea how could i check if there is executable inside without making spaghetti from code
            if(Directory.GetFiles($"./clients/{this.Name}").Length < 5)
            {
                return false;
            }
            
            return true;
        }
        public int getMaps()
        {
            if (!this.isInstalled())
                return -1;
            if(!Directory.Exists($"./clients/{this.Name}/Songs"))
            {
                return 0;
            }
            return Directory.GetDirectories($"./clients/{this.Name}/Songs").Length;
        }
        public void Run()
        {
            string filename = "";
            if (File.Exists($"./clients/{this.Name}/osu.exe"))
                filename = "osu.exe";
            if (File.Exists($"./clients/{this.Name}/osu!.exe"))
                filename = "osu!.exe";
            if (File.Exists($"./clients/{this.Name}/osu!test.exe"))
                filename = "osu!test.exe";
            if (File.Exists($"./clients/{this.Name}/osu!shine.exe"))
                filename = "osu!shine.exe";
            Process.Start($"./clients/{this.Name}/{filename}");
        }
        public void Install()
        {
            new WebClient().DownloadFile(this.Downloads[0],"./clients/temp.zip");
            ZipFile.ExtractToDirectory("./clients/temp.zip", $"./clients/{this.Name}");
            try { File.Delete("./client/temp.zip"); } catch { }
        }
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
