using System;
using System.Collections.Generic;

namespace WebAppPlayers.Models
{
    public partial class Player
    {
        public int Pid { get; set; }
        public string Pname { get; set; } = null!;
        public string Prole { get; set; } = null!;
        public string? Pteam { get; set; }
    }
}
