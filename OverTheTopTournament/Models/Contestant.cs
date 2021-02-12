using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverTheTopTournament.Models
{
    public class Contestant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfWins { get; set; }
        public int NumberOfLosses { get; set; }

    }
}
