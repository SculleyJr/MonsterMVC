using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterMVC.Domain.Data;

namespace MonsterMVC.Models
{
    public class SelectedViewModel
    {
        public int Id { get; set; }

        public int SelectedId { get; set; }

        public IEnumerable<SelectList> MonsterId { get; set; }

        public int EncounterId { get; set; }
        public int HealthPoints { get; set; }
        public bool IsAlive { get; set; }

        public ICollection<MonsterDataModel> MonsterDataModels { get; set; }
        public ICollection<Encounter> Encounters { get;set; }
    }
}