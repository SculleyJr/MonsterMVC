namespace MonsterMVC.Domain.Data
{
    public class ActiveMonster
    {
        public int Id { get; set; }
        public int EncounterId { get; set; }
        public int MonsterId { get; set; }
        public int HealthPoints { get; set; }
        public bool IsAlive { get; set; }

        public virtual Encounter Encounter { get; set; }
        public virtual MonsterDataModel Monster { get; set; }
    }
}
