using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P3C5
{
    class Program
    {
        static void Main(string[] args)
        {
            var listSongs = getSongs("term", "spring");
            if (listSongs.Count > 0)
            {
                foreach (var song in listSongs)
                {
                    Console.WriteLine(string.Format("{0} is available on iTunes!", song));
                }
            }
            else
            {
                Console.WriteLine("Nothiong of my interest on iTunes!");
            }
        }

        static List<String> getSongs(string keyParam, string valueParam)
        {
            const string url = "https://itunes.apple.com/search?{0}={1}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format(url, keyParam, valueParam));
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            List<string> list = new List<string>();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                string data = readStream.ReadToEnd();
                JObject joResponse = JObject.Parse(data);
                var results = (joResponse.Values()).Values();
                foreach (var res in results)
                {
                    try
                    {
                        string datas = JObject.Parse(res.ToString())["trackName"].ToString();
                        list.Add(datas);
                    }
                    catch { }
                }
                response.Close();
                readStream.Close();
                return list;
            }
            else
                return list;
        }
    }
}
