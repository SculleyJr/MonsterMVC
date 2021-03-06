using MonsterMVC.Domain.Data;

namespace MonsterMVC.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MonsterMVC.Data.MonsterDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MonsterMVC.Data.MonsterDbContext";
        }

        protected override void Seed(MonsterDbContext context)
        {
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 1,
                Name = "Aboleth",
                ChallengeRating = 10,
                Exp = 5900,
                UrlId = 1
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 2,
                Name = "Acolyte",
                ChallengeRating = .25f,
                Exp = 50,
                UrlId = 2
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 3,
                Name = "Adult Black Dragon",
                ChallengeRating = 14,
                Exp = 11500,
                UrlId = 3
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 4,
                Name = "Adult Blue Dracolich",
                ChallengeRating = 17,
                Exp = 18000,
                UrlId = 4
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 5,
                Name = "Adult Blue Dragon",
                ChallengeRating = 16,
                Exp = 15000,
                UrlId = 5
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 6,
                Name = "Adult Brass Dragon",
                ChallengeRating = 13,
                Exp = 10000,
                UrlId = 6
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 7,
                Name = "Adult Bronze Dragon",
                ChallengeRating = 15,
                Exp = 13000,
                UrlId = 7
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 8,
                Name = "Adult Copper Dragon",
                ChallengeRating = 14,
                Exp = 11500,
                UrlId = 8
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 9,
                Name = "Adult Gold Dragon",
                ChallengeRating = 17,
                Exp = 18000,
                UrlId = 9
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 10,
                Name = "Adult Green Dragon",
                ChallengeRating = 15,
                Exp = 13000,
                UrlId = 10
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 11,
                Name = "Adult Red Dragon",
                ChallengeRating = 17,
                Exp = 18000,
                UrlId = 11
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 12,
                Name = "Adult Silver Dragon",
                ChallengeRating = 16,
                Exp = 15000,
                UrlId = 12
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 13,
                Name = "Adult White Dragon",
                ChallengeRating = 13,
                Exp = 10000,
                UrlId = 13
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 14,
                Name = "Air Elemental",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 14
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 15,
                Name = "Ancient Black Dragon",
                ChallengeRating = 21,
                Exp = 33000,
                UrlId = 15
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 16,
                Name = "Ancient Blue Dragon",
                ChallengeRating = 23,
                Exp = 50000,
                UrlId = 16
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 17,
                Name = "Ancient Brass Dragon",
                ChallengeRating = 20,
                Exp = 25000,
                UrlId = 17
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 18,
                Name = "Ancient Bronze Dragon",
                ChallengeRating = 22,
                Exp = 41000,
                UrlId = 18
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 19,
                Name = "Ancient Copper Dragon",
                ChallengeRating = 21,
                Exp = 33000,
                UrlId = 19
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 20,
                Name = "Ancient Gold Dragon",
                ChallengeRating = 24,
                Exp = 62000,
                UrlId = 20
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 21,
                Name = "Ancient Green Dragon",
                ChallengeRating = 22,
                Exp = 41000,
                UrlId = 21
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 22,
                Name = "Ancient Red Dragon",
                ChallengeRating = 24,
                Exp = 62000,
                UrlId = 22
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 23,
                Name = "Ancient Silver Dragon",
                ChallengeRating = 23,
                Exp = 50000,
                UrlId = 23
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 24,
                Name = "Ancient White Dragon",
                ChallengeRating = 20,
                Exp = 25000,
                UrlId = 24
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 25,
                Name = "Androsphinx",
                ChallengeRating = 17,
                Exp = 18000,
                UrlId = 25
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 26,
                Name = "Animated Armor",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 26
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 27,
                Name = "Ankheg",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 27
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 28,
                Name = "Ape",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 28
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 29,
                Name = "Archmage",
                ChallengeRating = 12,
                Exp = 8400,
                UrlId = 29
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 30,
                Name = "Assassin",
                ChallengeRating = 8,
                Exp = 3900,
                UrlId = 30
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 31,
                Name = "Awakened Shrub",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 31
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 32,
                Name = "Awakened Tree",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 32
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 33,
                Name = "Axe Beak",
                ChallengeRating = .25f,
                Exp = 50,
                UrlId = 33
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 34,
                Name = "Azer",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 34
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 35,
                Name = "Baboon",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 35
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 36,
                Name = "Badger",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 36
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 37,
                Name = "Balor",
                ChallengeRating = 19,
                Exp = 22000,
                UrlId = 37
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 38,
                Name = "Bandit",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 38
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 39,
                Name = "Bandit Captain",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 39
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 40,
                Name = "Barbed Devil",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 40
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 41,
                Name = "Basilisk",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 41
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 42,
                Name = "Bat",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 42
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 43,
                Name = "Bearded Devil",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 43
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 44,
                Name = "Behir",
                ChallengeRating = 11,
                Exp = 7200,
                UrlId = 44
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 45,
                Name = "Berserker",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 45
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 46,
                Name = "Black Bear",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 46
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 47,
                Name = "Black Dragon Wyrmling",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 47
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 48,
                Name = "Black Pudding",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 48
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 49,
                Name = "Blink Dog",
                ChallengeRating = .25f,
                Exp = 50,
                UrlId = 49
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 50,
                Name = "Blood Hawk",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 50
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 51,
                Name = "Blue Dragon Wyrmling",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 51
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 52,
                Name = "Boar",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 52
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 53,
                Name = "Bone Devil",
                ChallengeRating = 12,
                Exp = 8400,
                UrlId = 53
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 54,
                Name = "Brass Dragon Wyrmling",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 54
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 55,
                Name = "Bronze Dragon Wyrmling",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 55
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 56,
                Name = "Brown Bear",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 56
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 57,
                Name = "Bugbear",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 57
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 58,
                Name = "Bulette",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 58
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 59,
                Name = "Camel",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 59
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 60,
                Name = "Carrion Crawler",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 60
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 61,
                Name = "Cat",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 61
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 62,
                Name = "Cave Bear",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 62
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 63,
                Name = "Centaur",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 63
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 64,
                Name = "Chain Devil",
                ChallengeRating = 11,
                Exp = 7200,
                UrlId = 64
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 65,
                Name = "Chimera",
                ChallengeRating = 6,
                Exp = 2300,
                UrlId = 65
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 66,
                Name = "Chuul",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 66
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 67,
                Name = "Clay Golem",
                ChallengeRating = 9,
                Exp = 5000,
                UrlId = 67
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 68,
                Name = "Cloaker",
                ChallengeRating = 8,
                Exp = 3900,
                UrlId = 68
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 69,
                Name = "Cloud Giant",
                ChallengeRating = 9,
                Exp = 5000,
                UrlId = 69
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 70,
                Name = "Cockatrice",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 70
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 71,
                Name = "Commoner",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 71
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 72,
                Name = "Constrictor Snake",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 72
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 73,
                Name = "Copper Dragon Wyrmling",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 73
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 74,
                Name = "Couatl",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 74
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 75,
                Name = "Crab",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 75
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 76,
                Name = "Crocodile",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 76
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 77,
                Name = "Cult Fanatic",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 77
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 78,
                Name = "Cultist",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 78
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 79,
                Name = "Darkmantle",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 79
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 80,
                Name = "Death Dog",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 80
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 81,
                Name = "Deep Gnome (Svirfneblin)",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 81
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 82,
                Name = "Deer",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 82
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 83,
                Name = "Deva",
                ChallengeRating = 10,
                Exp = 5900,
                UrlId = 83
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 84,
                Name = "Dire Wolf",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 84
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 85,
                Name = "Djinni",
                ChallengeRating = 11,
                Exp = 7200,
                UrlId = 85
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 86,
                Name = "Doppelganger",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 86
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 87,
                Name = "Draft Horse",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 87
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 88,
                Name = "Dragon Turtle",
                ChallengeRating = 17,
                Exp = 18000,
                UrlId = 88
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 89,
                Name = "Dretch",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 89
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 90,
                Name = "Drider",
                ChallengeRating = 6,
                Exp = 2300,
                UrlId = 90
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 91,
                Name = "Drow",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 91
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 92,
                Name = "Druid",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 92
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 93,
                Name = "Dryad",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 93
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 94,
                Name = "Duergar",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 94
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 95,
                Name = "Dust Mephit",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 95
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 96,
                Name = "Eagle",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 96
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 97,
                Name = "Earth Elemental",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 97
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 98,
                Name = "Efreeti",
                ChallengeRating = 11,
                Exp = 7200,
                UrlId = 98
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 99,
                Name = "Elephant",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 99
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 100,
                Name = "Elk",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 100
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 101,
                Name = "Erinyes",
                ChallengeRating = 12,
                Exp = 8400,
                UrlId = 101
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 102,
                Name = "Ettercap",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 102
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 103,
                Name = "Ettin",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 103
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 104,
                Name = "Fire Elemental",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 104
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 105,
                Name = "Fire Giant",
                ChallengeRating = 9,
                Exp = 5000,
                UrlId = 105
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 106,
                Name = "Flesh Golem",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 106
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 107,
                Name = "Flying Snake",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 107
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 108,
                Name = "Flying Sword",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 108
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 109,
                Name = "Frog",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 109
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 110,
                Name = "Frost Giant",
                ChallengeRating = 9,
                Exp = 5000,
                UrlId = 110
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 111,
                Name = "Gargoyle",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 111
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 112,
                Name = "Gelatinous Cube",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 112
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 113,
                Name = "Ghast",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 113
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 114,
                Name = "Ghost",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 114
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 115,
                Name = "Ghoul",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 115
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 116,
                Name = "Giant Ape",
                ChallengeRating = 7,
                Exp = 2900,
                UrlId = 116
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 117,
                Name = "Giant Badger",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 117
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 118,
                Name = "Giant Bat",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 118
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 119,
                Name = "Giant Boar",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 119
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 120,
                Name = "Giant Centipede",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 120
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 121,
                Name = "Giant Constrictor Snake",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 121
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 122,
                Name = "Giant Crab",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 122
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 123,
                Name = "Giant Crocodile",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 123
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 124,
                Name = "Giant Eagle",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 124
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 125,
                Name = "Giant Elk",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 125
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 126,
                Name = "Giant Fire Beetle",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 126
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 127,
                Name = "Giant Frog",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 127
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 128,
                Name = "Giant Goat",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 128
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 129,
                Name = "Giant Hyena",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 129
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 130,
                Name = "Giant Lizard",
                ChallengeRating = 0.25f,
                Exp = 100,
                UrlId = 130
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 131,
                Name = "Giant Octopus",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 131
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 132,
                Name = "Giant Owl",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 132
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 133,
                Name = "Giant Poisonous Snake",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 133
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 134,
                Name = "Giant Rat",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 134
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 135,
                Name = "Giant Rat (Diseased)",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 135
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 136,
                Name = "Giant Scorpion",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 136
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 137,
                Name = "Giant Sea Horse",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 137
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 138,
                Name = "Giant Shark",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 138
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 139,
                Name = "Giant Spider",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 139
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 140,
                Name = "Giant Toad",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 140
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 141,
                Name = "Giant Vulture",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 141
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 142,
                Name = "Giant Wasp",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 142
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 143,
                Name = "Giant Weasel",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 143
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 144,
                Name = "Giant Wolf Spider",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 144
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 145,
                Name = "Gibbering Mouther",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 145
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 146,
                Name = "Glabrezu",
                ChallengeRating = 9,
                Exp = 5000,
                UrlId = 146
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 147,
                Name = "Gladiator",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 147
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 148,
                Name = "Gnoll",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 148
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 149,
                Name = "Goat",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 149
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 150,
                Name = "Goblin",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 150
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 151,
                Name = "Gold Dragon Wyrmling",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 151
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 152,
                Name = "Gorgon",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 152
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 153,
                Name = "Gray Ooze",
                ChallengeRating = 0.5f,
                Exp = 50,
                UrlId = 153
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 154,
                Name = "Green Dragon Wyrmling",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 154
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 155,
                Name = "Green Hag",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 155
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 156,
                Name = "Grick",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 156
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 157,
                Name = "Griffon",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 157
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 158,
                Name = "Grimlock",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 158
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 159,
                Name = "Guard",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 159
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 160,
                Name = "Guardian Naga",
                ChallengeRating = 10,
                Exp = 5900,
                UrlId = 160
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 161,
                Name = "Gynosphinx",
                ChallengeRating = 11,
                Exp = 7200,
                UrlId = 161
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 162,
                Name = "Half-Red Dragon Veteran",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 162
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 163,
                Name = "Harpy",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 163
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 164,
                Name = "Hawk",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 164
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 165,
                Name = "Hell Hound",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 165
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 166,
                Name = "Hezrou",
                ChallengeRating = 8,
                Exp = 3900,
                UrlId = 166
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 167,
                Name = "Hill Giant",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 167
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 168,
                Name = "Hippogriff",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 168
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 169,
                Name = "Hobgoblin",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 169
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 170,
                Name = "Homunculus",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 170
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 171,
                Name = "Horned Devil",
                ChallengeRating = 11,
                Exp = 7200,
                UrlId = 171
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 172,
                Name = "Hunter Shark",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 172
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 173,
                Name = "Hydra",
                ChallengeRating = 8,
                Exp = 3900,
                UrlId = 173
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 174,
                Name = "Hyena",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 174
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 175,
                Name = "Ice Devil",
                ChallengeRating = 14,
                Exp = 11500,
                UrlId = 175
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 176,
                Name = "Ice Mephit",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 176
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 177,
                Name = "Imp",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 177
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 178,
                Name = "Invisible Stalker",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 178
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 179,
                Name = "Iron Golem",
                ChallengeRating = 16,
                Exp = 15000,
                UrlId = 179
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 180,
                Name = "Jackal",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 180
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 181,
                Name = "Killer Whale",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 181
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 182,
                Name = "Knight",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 182
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 183,
                Name = "Kobold",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 183
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 184,
                Name = "Kraken",
                ChallengeRating = 23,
                Exp = 50000,
                UrlId = 184
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 185,
                Name = "Lamia",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 185
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 186,
                Name = "Lemure",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 186
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 187,
                Name = "Lich",
                ChallengeRating = 21,
                Exp = 33000,
                UrlId = 187
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 188,
                Name = "Lion",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 188
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 189,
                Name = "Lizard",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 189
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 190,
                Name = "Lizardfolk",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 190
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 191,
                Name = "Mage",
                ChallengeRating = 6,
                Exp = 2300,
                UrlId = 191
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 192,
                Name = "Magma Mephit",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 192
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 193,
                Name = "Magmin",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 193
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 194,
                Name = "Mammoth",
                ChallengeRating = 6,
                Exp = 2300,
                UrlId = 194
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 195,
                Name = "Manticore",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 195
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 196,
                Name = "Marilith",
                ChallengeRating = 16,
                Exp = 15000,
                UrlId = 196
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 197,
                Name = "Mastiff",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 197
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 198,
                Name = "Medusa",
                ChallengeRating = 6,
                Exp = 2300,
                UrlId = 198
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 199,
                Name = "Merfolk",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 199
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 200,
                Name = "Merrow",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 200
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 201,
                Name = "Mimic",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 201
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 202,
                Name = "Minotaur",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 202
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 203,
                Name = "Minotaur Skeleton",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 203
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 204,
                Name = "Mule",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 204
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 205,
                Name = "Mummy",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 205
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 206,
                Name = "Mummy Lord",
                ChallengeRating = 15,
                Exp = 13000,
                UrlId = 206
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 207,
                Name = "Nalfeshnee",
                ChallengeRating = 13,
                Exp = 10000,
                UrlId = 207
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 208,
                Name = "Night Hag",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 208
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 209,
                Name = "Nightmare",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 209
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 210,
                Name = "Noble",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 210
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 211,
                Name = "Ochre Jelly",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 211
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 212,
                Name = "Octopus",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 212
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 213,
                Name = "Ogre",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 213
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 214,
                Name = "Ogre Zombie",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 214
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 215,
                Name = "Oni",
                ChallengeRating = 7,
                Exp = 2900,
                UrlId = 215
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 216,
                Name = "Orc",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 216
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 217,
                Name = "Otyugh",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 217
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 218,
                Name = "Owl",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 218
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 219,
                Name = "Owlbear",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 219
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 220,
                Name = "Panther",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 220
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 221,
                Name = "Pegasus",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 221
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 222,
                Name = "Phase Spider",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 222
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 223,
                Name = "Pit Fiend",
                ChallengeRating = 20,
                Exp = 25000,
                UrlId = 223
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 224,
                Name = "Planetar",
                ChallengeRating = 16,
                Exp = 15000,
                UrlId = 224
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 225,
                Name = "Plesiosaurus",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 225
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 226,
                Name = "Poisonous Snake",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 226
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 227,
                Name = "Polar Bear",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 227
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 228,
                Name = "Pony",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 228
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 229,
                Name = "Priest",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 229
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 230,
                Name = "Pseudodragon",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 230
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 231,
                Name = "Purple Worm",
                ChallengeRating = 15,
                Exp = 13000,
                UrlId = 231
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 232,
                Name = "Quasit",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 232
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 233,
                Name = "Quipper",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 233
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 234,
                Name = "Rakshasa",
                ChallengeRating = 16,
                Exp = 15000,
                UrlId = 234
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 235,
                Name = "Rat",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 235
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 236,
                Name = "Raven",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 236
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 237,
                Name = "Red Dragon Wyrmling",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 237
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 238,
                Name = "Reef Shark",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 238
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 239,
                Name = "Remorhaz",
                ChallengeRating = 11,
                Exp = 7200,
                UrlId = 239
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 240,
                Name = "Rhinoceros",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 240
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 241,
                Name = "Riding Horse",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 241
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 242,
                Name = "Roc",
                ChallengeRating = 11,
                Exp = 7200,
                UrlId = 242
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 243,
                Name = "Roper",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 243
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 244,
                Name = "Rug of Smothering",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 244
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 245,
                Name = "Rust Monster",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 245
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 246,
                Name = "Saber-Toothed Tiger",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 246
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 247,
                Name = "Sahuagin",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 247
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 248,
                Name = "Salamander",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 248
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 249,
                Name = "Satyr",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 249
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 250,
                Name = "Scorpion",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 250
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 251,
                Name = "Scout",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 251
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 252,
                Name = "Sea Hag",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 252
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 253,
                Name = "Sea Horse",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 253
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 254,
                Name = "Shadow",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 254
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 255,
                Name = "Shambling Mound",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 255
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 256,
                Name = "Shield Guardian",
                ChallengeRating = 7,
                Exp = 2900,
                UrlId = 256
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 257,
                Name = "Shrieker",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 257
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 258,
                Name = "Silver Dragon Wyrmling",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 258
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 259,
                Name = "Skeleton",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 249
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 260,
                Name = "Solar",
                ChallengeRating = 21,
                Exp = 33000,
                UrlId = 260
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 261,
                Name = "Specter",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 261
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 262,
                Name = "Spider",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 262
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 263,
                Name = "Spirit Naga",
                ChallengeRating = 8,
                Exp = 3900,
                UrlId = 263
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 264,
                Name = "Sprite",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 264
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 265,
                Name = "Spy",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 265
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 266,
                Name = "Steam Mephit",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 266
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 267,
                Name = "Stirge",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 267
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 268,
                Name = "Stone Giant",
                ChallengeRating = 7,
                Exp = 2900,
                UrlId = 268
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 269,
                Name = "Stone Golem",
                ChallengeRating = 10,
                Exp = 5900,
                UrlId = 269
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 270,
                Name = "Storm Giant",
                ChallengeRating = 13,
                Exp = 10000,
                UrlId = 270
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 271,
                Name = "Succubus/Incubus",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 271
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 272,
                Name = "Swarm of Bats",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 272
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 273,
                Name = "Swarm of Beetles",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 273
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 274,
                Name = "Swarm of Centipedes",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 274
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 275,
                Name = "Swarm of Insects",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 275
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 276,
                Name = "Swarm of Poisonous Snakes",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 276
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 277,
                Name = "Swarm of Quippers",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 277
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 278,
                Name = "Swarm of Rats",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 278
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 279,
                Name = "Swarm of Ravens",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 279
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 280,
                Name = "Swarm of Spiders",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 280
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 281,
                Name = "Swarm of Wasps",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 281
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 282,
                Name = "Tarrasque",
                ChallengeRating = 30,
                Exp = 155000,
                UrlId = 282
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 283,
                Name = "Thug",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 283
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 284,
                Name = "Tiger",
                ChallengeRating = 1,
                Exp = 200,
                UrlId = 284
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 285,
                Name = "Treant",
                ChallengeRating = 9,
                Exp = 5000,
                UrlId = 285
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 286,
                Name = "Tribal Warrior",
                ChallengeRating = 0.125f,
                Exp = 25,
                UrlId = 286
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 287,
                Name = "Triceratops",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 287
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 288,
                Name = "Troll",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 288
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 289,
                Name = "Tyrannosaurus Rex",
                ChallengeRating = 8,
                Exp = 3900,
                UrlId = 289
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 290,
                Name = "Unicorn",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 290
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 291,
                Name = "Vampire",
                ChallengeRating = 13,
                Exp = 10000,
                UrlId = 291
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 292,
                Name = "Vampire Spawn",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 292
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 293,
                Name = "Veteran",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 293
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 294,
                Name = "Violet Fungus",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 294
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 295,
                Name = "Vrock",
                ChallengeRating = 6,
                Exp = 2300,
                UrlId = 295
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 296,
                Name = "Vulture",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 296
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 297,
                Name = "Warhorse",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 297
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 298,
                Name = "Warhorse Skeleton",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 298
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 299,
                Name = "Water Elemental",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 299
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 300,
                Name = "Weasel",
                ChallengeRating = 0,
                Exp = 10,
                UrlId = 300
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 301,
                Name = "Werebear",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 301
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 302,
                Name = "Wereboar",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 302
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 303,
                Name = "Wererat",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 303
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 304,
                Name = "Weretiger",
                ChallengeRating = 4,
                Exp = 1100,
                UrlId = 304
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 305,
                Name = "Werewolf",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 305
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 306,
                Name = "White Dragon Wyrmling",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 306
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 307,
                Name = "Wight",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 307
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 308,
                Name = "Will-o'-Wisp",
                ChallengeRating = 2,
                Exp = 450,
                UrlId = 308
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 309,
                Name = "Winter Wolf",
                ChallengeRating = 3,
                Exp = 700,
                UrlId = 309
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 310,
                Name = "Wolf",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 310
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 311,
                Name = "Worg",
                ChallengeRating = 0.5f,
                Exp = 100,
                UrlId = 311
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 312,
                Name = "Wraith",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 312
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 313,
                Name = "Wyvern",
                ChallengeRating = 6,
                Exp = 2300,
                UrlId = 313
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 314,
                Name = "Xorn",
                ChallengeRating = 5,
                Exp = 1800,
                UrlId = 314
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 315,
                Name = "Young Black Dragon",
                ChallengeRating = 7,
                Exp = 2900,
                UrlId = 315
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 316,
                Name = "Young Blue Dragon",
                ChallengeRating = 9,
                Exp = 5000,
                UrlId = 316
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 317,
                Name = "Young Brass Dragon",
                ChallengeRating = 6,
                Exp = 2300,
                UrlId = 317
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 318,
                Name = "Young Bronze Dragon",
                ChallengeRating = 8,
                Exp = 3900,
                UrlId = 318
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 319,
                Name = "Young Copper Dragon",
                ChallengeRating = 7,
                Exp = 2900,
                UrlId = 319
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 320,
                Name = "Young Gold Dragon",
                ChallengeRating = 10,
                Exp = 5900,
                UrlId = 320
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 321,
                Name = "Young Green Dragon",
                ChallengeRating = 8,
                Exp = 3900,
                UrlId = 321
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 322,
                Name = "Young Red Dragon",
                ChallengeRating = 10,
                Exp = 5900,
                UrlId = 322
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 323,
                Name = "Young Silver Dragon",
                ChallengeRating = 9,
                Exp = 5000,
                UrlId = 323
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 324,
                Name = "Young White Dragon",
                ChallengeRating = 6,
                Exp = 2300,
                UrlId = 324
            });
            context.Monsters.AddOrUpdate(new MonsterDataModel()
            {
                Id = 325,
                Name = "Zombie",
                ChallengeRating = 0.25f,
                Exp = 50,
                UrlId = 325
            });
            context.SaveChanges();


            context.Encounters.AddOrUpdate(new Encounter()
            {
                Id = 1,

            });
            context.SaveChanges();

            context.ActiveMonsters.AddOrUpdate(new ActiveMonster()
            {
                Id = 1,
                EncounterId = 1,
                MonsterId = 1,
                HealthPoints = 10,
                IsAlive = true
            });
            context.ActiveMonsters.AddOrUpdate(new ActiveMonster()
            {
                Id = 2,
                EncounterId = 1,
                MonsterId = 2,
                HealthPoints = 10,
                IsAlive = true
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
