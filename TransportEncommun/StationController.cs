using System;
using System.Collections.Generic;
using System.Linq;

namespace TransportEncommun
{

    class StationController
    {
        public List<string> stations { get; set; }
        StationLibrary.Library library = new StationLibrary.Library();
        public List<Station> Stations => DistinctStation(Station.FromJson(library.Request()));


        public List<Station> DistinctStation(Station[] Stations)
        {
            //Liste de stations vide. Qui va les stocker sans les doublons
            List<Station> clearedStations = new List<Station> { };

            // pour selectionner chaque station
            foreach (Station station in Stations) // la station courante
            {
                // compare la station selectonnée dans le tableau temporaire
                // ELle vient de la liste propre de stations 
                // C'est une unique station du même nom que la station courante
                Station duplicatedStation = clearedStations.Find(oneStation => oneStation.Equals(station));

                // si la station unique existe
                if (duplicatedStation != null)
                {
                    DistinctLine(station, duplicatedStation);
                }
                else
                {
                    station.lines = station.lines.Distinct().ToList();
                    clearedStations.Add(station);
                }

            }

            return clearedStations;
        }

        private void DistinctLine(Station station, Station duplicatedStation)
        {
            List<string> clearedLines = duplicatedStation.lines.Concat(station.lines).Distinct().ToList();
            duplicatedStation.lines = clearedLines;
        }
    }
}
