using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurakTurk.Models
{
    class Place
    {
        Int32 id;
        string locatie;
        string flagurl;
        ICollection<Game> games;

        [JsonProperty(PropertyName = "id")]
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "locatie")]
        public string Locatie
        {
            get { return locatie; }
            set { locatie = value; }
        }

        [JsonProperty(PropertyName = "flagurl")]
        public string Flagurl
        {
            get { return flagurl; }
            set { flagurl = value; }
        }

        public string Version { get; set; }
    }
}
