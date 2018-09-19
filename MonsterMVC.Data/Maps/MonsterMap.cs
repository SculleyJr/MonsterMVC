using MonsterMVC.Domain.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterMVC.Data.Maps
{
    class MonsterMap : EntityTypeConfiguration<MonsterDataModel>
    {
        public MonsterMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
