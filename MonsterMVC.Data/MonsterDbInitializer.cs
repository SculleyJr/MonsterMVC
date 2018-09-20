using MonsterMVC.Domain.Data;
using System.Data.Entity;
using MonsterMVC.Data.Migrations;

namespace MonsterMVC.Data
{
    class MonsterDbInitializer : MigrateDatabaseToLatestVersion<MonsterDbContext, Configuration>
    {

    

    }
}
