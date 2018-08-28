using System;
using System.Collections.Generic;

namespace TransportEncommun
{
    class Program
    {
        static void Main(string[] args)
        {
            StationController stationController = new StationController();
            List<Station> Stations = stationController.Stations;


            int i;
            for (i = 0; i < Stations.Count; i++)
            {
                Console.WriteLine(Stations[i]);
            }
            Console.ReadKey();


            //((HttpWebRequest) request).UserAgent = ".NET Framework Example Client";
            //Console.WriteLine(((HttpWebResponse) response).StatusDescription);  

            //var request = WebRequest.Create(requestUri) as HttpWebRequest;
            //if (request != null) { }
        }

    }
}
