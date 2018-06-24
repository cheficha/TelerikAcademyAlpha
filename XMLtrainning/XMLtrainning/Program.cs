using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

namespace XMLtrainning
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("../../resources/movies.json");
            var movies = JsonConvert.DeserializeObject<List<Movies>>(json);
            var ordered = movies.SelectMany(movie => movie.Cast)
                .OrderBy(actor => actor);
            Console.WriteLine(string.Join(Environment.NewLine,ordered));
       
        }
    }
    public class Movies
    {
        [JsonProperty("cast")]
        public List<string> Cast { get; set; }
    }
}
