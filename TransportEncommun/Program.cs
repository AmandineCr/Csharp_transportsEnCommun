using System;
using System.IO;
using System.Net;

namespace TransportEncommun
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create("https://data.metromobilite.fr/api/linesNear/json?x=5.727725&y=45.185656&dist=500&details=true");

            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            //Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();


            Station[] Stations = Station.FromJson(responseFromServer);

            int i;
            for (i= 0; i < Stations.Length ; i++){
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
