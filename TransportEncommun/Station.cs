using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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

        public override bool Equals(object obj)
        {
            var station = obj as Station;
            return station != null &&
                   name == station.name;
        }

        public override string ToString()
        {
            return $@"Arrêt : {name} 
                Lignes : {linesToString()}"; // arret : victor Hugo
                                             // Lignes : 18, 17                                                
        }

        public string linesToString()
        {
            string stationInfos= "";

            foreach (string line in lines) {
                stationInfos += line; // === // stationInfos = stationInfos + line
            }
            //lines.ForEach(delegate (String name)

            return stationInfos;
        }
    }
}
