using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using MFL_App.Model;

namespace MFL_App.Services
{

	public class RosterService
	{
		HttpClient httpClient;
        public RosterService()
        {
            httpClient = new();
        }

        List<Player> players;
        public async Task<List<Player>> GetPlayers()
        {
            if (players?.Count > 0)
                return players;


            var response = httpClient.GetAsync("https://api.myfantasyleague.com/2023/export?TYPE=rosters&L=72358&APIKEY=&FRANCHISE=0004&W=&JSON=1");

            await Console.Out.WriteLineAsync(response.ToString());

            return players;
        }

    }
}
