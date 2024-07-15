using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static titanic_launcher.Client;

namespace titanic_launcher
{
    internal class api
    {
        private static WebClient _c = new WebClient();
        private static string getImage(int id)
        {
            if (!System.IO.Directory.Exists("./avatars"))
                System.IO.Directory.CreateDirectory("./avatars");
            _c.DownloadFile($"https://osu.lekuru.xyz/a/{id}", $"./avatars/{id}.png");
            return $"./avatars/{id}.png";
        }
        public static User getUser(int id)
        {
            string weboutput = _c.DownloadString("https://osu.lekuru.xyz/api/profile/" + id);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Root root = JsonSerializer.Deserialize<Root>(weboutput, options);

            if (root == null || root.Stats == null || root.Stats.Count < 4)
                throw new Exception("Invalid JSON data.");

            User user = new User
            {
                Username = root.Name,
                StdScore = new Score
                {
                    TotalScore = root.Stats[0].tscore,
                    RankedScore = root.Stats[0].rscore,
                    PP = root.Stats[0].pp,
                    Accuracy = (float)root.Stats[0].acc
                },
                TaikoScore = new Score
                {
                    TotalScore = root.Stats[1].tscore,
                    RankedScore = root.Stats[1].rscore,
                    PP = root.Stats[1].pp,
                    Accuracy = (float)root.Stats[1].acc
                },
                CtbScore = new Score
                {
                    TotalScore = root.Stats[2].tscore,
                    RankedScore = root.Stats[2].rscore,
                    PP = root.Stats[2].pp,
                    Accuracy = (float)root.Stats[2].acc
                },
                ManiaScore = new Score
                {
                    TotalScore = root.Stats[3].tscore,
                    RankedScore = root.Stats[3].rscore,
                    PP = root.Stats[3].pp,
                    Accuracy = (float)root.Stats[3].acc
                }
            };
            user.ImagePath = getImage(id);
            return user;
        }
        public static User getUser(string id)
        {
            string weboutput = _c.DownloadString("https://osu.lekuru.xyz/api/profile/" + id);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Root root = JsonSerializer.Deserialize<Root>(weboutput, options);

            if (root == null || root.Stats == null || root.Stats.Count < 4)
                throw new Exception("Invalid JSON data.");

            User user = new User
            {
                Username = root.Name,
                Id = root.id,
                StdScore = new Score
                {
                    TotalScore = root.Stats[0].tscore,
                    RankedScore = root.Stats[0].rscore,
                    PP = root.Stats[0].pp,
                    Accuracy = (float)root.Stats[0].acc
                },
                TaikoScore = new Score
                {
                    TotalScore = root.Stats[1].tscore,
                    RankedScore = root.Stats[1].rscore,
                    PP = root.Stats[1].pp,
                    Accuracy = (float)root.Stats[1].acc
                },
                CtbScore = new Score
                {
                    TotalScore = root.Stats[2].tscore,
                    RankedScore = root.Stats[2].rscore,
                    PP = root.Stats[2].pp,
                    Accuracy = (float)root.Stats[2].acc
                },
                ManiaScore = new Score
                {
                    TotalScore = root.Stats[3].tscore,
                    RankedScore = root.Stats[3].rscore,
                    PP = root.Stats[3].pp,
                    Accuracy = (float)root.Stats[3].acc
                }
            };
            user.ImagePath = getImage(user.Id);
            return user;
        }
        public static List<Client> getClients()
        {

            
            try
            {
                List<Client> downloads = JsonSerializer.Deserialize<List<Client>>(_c.DownloadString(Settings.manifest));

                return downloads;
            } catch(WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = e.Response as HttpWebResponse;
                    if (response != null)
                    {
                        MessageBox.Show($"Server returned error {(int)response.StatusCode}\nplease make sure manifest you gave is correct.", "Uh oh, something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return new List<Client>();
            }
        }
        public static string getClientImage(Client cl)
        {

            if (!System.IO.Directory.Exists("./images"))
                System.IO.Directory.CreateDirectory("./images");
            if(System.IO.File.Exists($"./images/{cl.Name}.png"))
                return $"./images/{cl.Name}.png";
            if (cl.Screenshots.Count == 0)
                return $"";
            if(!cl.Screenshots[0].Src.Contains("https"))
            {
                //_c.DownloadFile("https://osu.lekuru.xyz"+cl.Screenshots[0].Src, $".//images/{cl.Name}.png");
                return "https://osu.lekuru.xyz" + cl.Screenshots[0].Src;
            } else
            {
                // _c.DownloadFile(cl.Screenshots[0].Src, $".//images/{cl.Name}.png");
                return (cl.Screenshots[0].Src);
            }
            
            Thread.Sleep(2000);
            return $"./images/{cl.Name}.png";
        }
    }

    
}

