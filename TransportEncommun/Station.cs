using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportEncommun
{
    class Station
    {
        public string id { get; set; }
        public string name { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public List<string> lines { get; set; }

        public static Station[] FromJson(string json) => JsonConvert.DeserializeObject<Station[]>(json, Converter.Settings);

    }
}
