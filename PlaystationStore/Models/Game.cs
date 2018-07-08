using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlaystationStore.Models
{
    [Table(name: "PS4_games")]
    public class Game
    {
        public int gameID { get; set; }
        public string gameName { get; set; }
        public string gameGeneric { get; set; }
        public float gamePrice { get; set; }
    }
}