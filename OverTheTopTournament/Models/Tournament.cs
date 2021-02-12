using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverTheTopTournament.Models
{
    public class Tournament
    {
        public DateTime DateOfTournament { get; set; }
        public string Location { get; set; }
        public int NumberOfContestants { get; set; }

        //not sure if I need these here or in a different spot
        public int FirstPlace { get; set; }
        public int SecondPlace { get; set; }
        public int ThirdPlace { get; set; }
    }
}
