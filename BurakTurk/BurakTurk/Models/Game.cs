using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurakTurk.Models
{
    class Game
    {
        Int32 id;
        Int32 year;
        string name;
        string info;
        string character;
        string imageurl;
        ICollection<Place> locations;

        [JsonProperty(PropertyName = "id")]
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "year")]
        public Int32 Year
        {
            get { return year; }
            set { year = value; }
        }

        [JsonProperty(PropertyName = "name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [JsonProperty(PropertyName = "info")]
        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        [JsonProperty(PropertyName = "character")]
        public string Character
        {
            get { return character; }
            set { character = value; }
        }

        [JsonProperty(PropertyName = "imageurl")]
        public string Imageurl
        {
            get { return imageurl; }
            set { imageurl = value; }
        }

        [JsonProperty(PropertyName = "locations")]
        public ICollection<Place> Locations
        {
            get { return locations; }
            set { locations = value; }
        }

        public string Version { get; set; }

    }
}