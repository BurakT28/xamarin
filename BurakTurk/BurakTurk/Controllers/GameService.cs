using BurakTurk.Helpers;
using BurakTurk.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace BurakTurk.Controllers
{
    class GameService
    {
        public async Task<ObservableCollection<Game>> GetCharactersAsync()
        {
            var games = await ReadCharactersFromFile();
            return new ObservableCollection<Game>(games);
        }

        private async Task<Game[]> ReadCharactersFromFile()
        {
            var assembly = typeof(GameService).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(Constants.GamesFilename);
            string text;

            using (var reader = new System.IO.StreamReader(stream))
            {
                text = await reader.ReadToEndAsync();
            }

            var games = JsonConvert.DeserializeObject<Game[]>(text);
            return games;
        }
    }
}
