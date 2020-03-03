using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    public  class TeamModel
    {
        // NOTE: get package that allow reference count to show above each function/property (Resharper)
        public List<int> TeamMembers { get; set; } = new List<int>();
        public string TeamName { get; set; }

    }
}
