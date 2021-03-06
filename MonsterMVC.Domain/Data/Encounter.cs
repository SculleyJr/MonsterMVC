﻿using System.Collections.Generic;

namespace MonsterMVC.Domain.Data
{
    public class Encounter
    {
        public int Id { get; set; }
        public virtual ICollection<ActiveMonster> ActiveMonsters { get; set; }
    }
}