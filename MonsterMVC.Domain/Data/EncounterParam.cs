﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMVC.Domain.Data
{
    public class EncounterParam
    {
        public int Id { get; set; }
        public int AverageLvl { get; set; }
        public char Difficulty { get; set; }
        public int NumberOfMonsters { get; set; }
        public Encounter Encounter { get; set; }
    }
}
