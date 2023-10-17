using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MFL_App.Model
{
    public class Player
    {
		public string Salary { get; set; }
		public string Status { get; set; }
		public string ContractYear { get; set; }
		public string Drafted { get; set; }
		public string Id { get; set; }
	}

	[JsonSerializable(typeof(List<Player>))]
	internal sealed partial class PlayerContext : JsonSerializerContext
	{ }
}
