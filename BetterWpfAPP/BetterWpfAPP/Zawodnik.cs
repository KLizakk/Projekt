using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterWpfAPP
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);





        public class Birth
        {
            public string date { get; set; }
            public string country { get; set; }
        }

        public class Height
        {
            public string feets { get; set; }
            public string inches { get; set; }
            public string meters { get; set; }
        }

        public class Leagues
        {
            public Standard standard { get; set; }
            public Vegas vegas { get; set; }
            public Sacramento sacramento { get; set; }
        }

        public class Nba
        {
            public int start { get; set; }
            public int pro { get; set; }
        }

        public class Parameters
        {
            public string search { get; set; }
        }

        public class Response
        {
            public int id { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public Birth birth { get; set; }
            public Nba nba { get; set; }
            public Height height { get; set; }
            public Weight weight { get; set; }
            public string college { get; set; }
            public string affiliation { get; set; }
            public Leagues leagues { get; set; }
        }

        public class Root
        {
            public string get { get; set; }
            public Parameters parameters { get; set; }
            public List<object> errors { get; set; }
            public int results { get; set; }
            public List<Response> response { get; set; }
        }

        public class Sacramento
        {
            public object jersey { get; set; }
            public bool active { get; set; }
            public string pos { get; set; }
        }

        public class Standard
        {
            public int jersey { get; set; }
            public bool active { get; set; }
            public string pos { get; set; }
        }

        public class Vegas
        {
            public int jersey { get; set; }
            public bool active { get; set; }
            public string pos { get; set; }
        }

        public class Weight
        {
            public string pounds { get; set; }
            public string kilograms { get; set; }
        }
    

}
