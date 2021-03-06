﻿using MonsterMVC.Domain.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MonsterMVC.Data.Maps
{
    internal class ActiveMonsterMap : EntityTypeConfiguration<ActiveMonster>
    {
        public ActiveMonsterMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasRequired(x => x.Monster).WithMany().HasForeignKey(x => x.MonsterId);
        }
        
    }
}
