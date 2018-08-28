using System.Collections.Generic;


namespace TransportEncommun
{
    
    class StationController
    {
        public List<string> stations { get; set; }
        StationLibrary.Library library = new StationLibrary.Library();
        public Station[] Stations => Station.FromJson(library.Request());
        
        public string clearedLine()
        {
            string lineWithoutDuplication = "";

            foreach ( in )
            {
                ;
            }
            return ;
        }
    }
}
