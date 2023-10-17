using MFL_App.Model;
using MFL_App.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL_App.ViewModel
{
    public class RosterViewModel : BaseViewModel
    {
        RosterService rosterService;
        public RosterViewModel(RosterService rosterService) 
        {
            Title = "Roster";
            this.rosterService = rosterService;
            var Roster = rosterService.GetPlayers();
        }

        public ObservableCollection<Player> Players { get; set; } = new ObservableCollection<Player>()
        {
            new Player() { Id = 1, Name = "Devon Witherspoon", Age = 21, Position = "cb", Team = "Seattle Seahawks" },
            new Player() { Id = 2, Name = "DK Metcalf", Age = 25, Position = "wr", Team = "Seattle Seahawks" }
        };

    }
}
