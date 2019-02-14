using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefRegister.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string MatchNumber { get; set; }

        public string GameDate { get; set; }
        
        public string Arena { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public string Score1 { get; set; }
        public string Score2 { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Fee1 { get; set; }
        public string Fee2 { get; set; }
        public string Fee3 { get; set; }
        public string Fee4 { get; set; }

    }
}
