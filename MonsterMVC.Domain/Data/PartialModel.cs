using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMVC.Domain.Data
{
    public class PartialModel
    {
        public Encounter Encounter { get; set; }
        public MonsterDataModel MonsterDataModel { get; set; }
    }
}
