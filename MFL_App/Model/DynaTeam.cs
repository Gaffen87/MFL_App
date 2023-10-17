using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL_App.Model
{
    public class DynaTeam
    {
		public string Id { get; set; }
		public List<Player> Players { get; set; }
		public string Week { get; set; }

		public DynaTeam() 
        {
            Players = new List<Player>();
        }
    }
}
