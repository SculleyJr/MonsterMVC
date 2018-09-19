using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MonsterMVC.Domain.Data
{
    public class EncounterParam
    {

        public int Id { get; set; }
        public Encounter Encounter { get; set; }

        public virtual ICollection<MonsterDataModel> TemporaryMonsters { get; set; }


    }
}
