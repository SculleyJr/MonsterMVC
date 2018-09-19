using Newtonsoft.Json;

namespace MonsterMVC.Domain.DomainModel
{
    public class SpecialAbility
    {
        [JsonProperty("attack_bonus")]
        public int AttackBonus { get; set; }
        [JsonProperty("desc")]
        public string Desc { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
