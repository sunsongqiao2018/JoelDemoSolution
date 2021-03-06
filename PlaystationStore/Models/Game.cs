﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PlaystationStore.Models
{
    [Table(name: "PS4_games")]

    public class Game
    {
        [Required]
        public int gameID { get; set; }
       [StringLength(50)]
        public string gameName { get; set; }

        public string gameGeneric { get; set; }
        public float gamePrice { get; set; }

       //public int producerId{ get; set; }
        public virtual Producer producer { get; set; }
    }
}