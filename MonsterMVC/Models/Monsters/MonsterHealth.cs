using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MonsterMVC.Models
{
    public class MonsterHealth
    {
        [Key]
        public int MonsterId { get; set; }
        [JsonProperty("hit_points")]
        public int hitPoints { get; set; }
    }
}