using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardgameDatabase.Models
{
    public class Boardgame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Keeper { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public List<string> Tags { get; set; }
        public bool ForSale { get; set; }

    }
}
