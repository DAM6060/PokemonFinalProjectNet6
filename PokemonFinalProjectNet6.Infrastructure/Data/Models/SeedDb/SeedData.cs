using Microsoft.AspNetCore.Identity;
using PokemonFinalProjectNet6.Infrastructure.Constants;

namespace PokemonFinalProjectNet6.Infrastructure.Data.Models.SeedDb
{
    public class SeedData
    {
        public SeedData()
        {
            SeedUsers();
            SeedPlayer();
            SeedTeams();
            SeedMoves();
            SeedAbility();
            SeedPokemon();
            SeedPokemonsMoves();
        }

        public List<PokemonMove> PokemonsMoves { get; set; }

        public IdentityUser AdminUser { get; set; }
        public IdentityUser PlayerUser { get; set; }        

        public Player Player1 { get; set; }

        public Player Player2 { get; set; }

        public Team Team1 { get; set; }

        public Team Team2 { get; set; }

        public Pokemon Venausor1 { get; set; }

        public Pokemon Venausor2 { get; set; }

        public Pokemon Infernoape1 { get; set; }

        public Pokemon Infernoape2 { get; set; }

        public Pokemon Tyranitar { get; set; }

        public Pokemon Scizor { get; set; }

        public Ability Chlorophyll { get; set; }

        public Ability IronFist { get; set; }

        public Ability Technichian { get; set; }

        public Ability Adaptability { get; set; }

        public Move FlameThrower { get; set; }

        public Move ThunderPunch { get; set; }

        public Move GigaDrain { get; set; }

        public Move SleepPowder { get; set; }

        public Move SolarBeam { get; set; }

        public Move Earthquake { get; set; }

        public Move WingAttack { get; set; }

        public Move BugBite { get; set; }

        public Move UTurn { get; set; }

        public Move CloseCombat { get; set; }

        public Move BulletPunch { get; set; }

        public Move SuperPower { get; set; }

        public Move EarthPower { get; set; }

        public Move RockSlide { get; set; }

        public Move Crunch { get; set; }

        public Move IceBeam { get; set; }

        public Move FirePunch { get; set; }

        public Move BrickBreak { get; set; }

        public Move SludgeBomb { get; set; }

        public Move Reflect { get; set; }

        public Move LeechSeed { get; set; }


        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            AdminUser = new IdentityUser
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "DimitarAdmin@admin.com",
                NormalizedUserName = "DIMITARADMIN@ADMIN.COm",
                Email = "ddimitar98@gmail.com",
                NormalizedEmail = "DDIMITAR98@GMAIL.COM"
            };

            

            AdminUser.PasswordHash =
                 hasher.HashPassword(AdminUser, "Dimi123");

            PlayerUser = new IdentityUser
            {

                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "DimitarPlayer@player.com",
                NormalizedUserName = "DIMITARPLAYER@PLAYER.COM",
                Email = "varnasharks.afc@gmail.com",
                NormalizedEmail = "VARNASHARKS.AFC@GMAIL.COM"
            };
            
            PlayerUser.PasswordHash =
                 hasher.HashPassword(PlayerUser, "Sharks123");
        }
        public void SeedPlayer()
        {
            Player1 = new Player
            {
                Id = 1,
                Name = "Dimitrakis",
                UserId = PlayerUser.Id
            };
            Player2 = new Player
            {
                Id = 2,
                Name = "Dimetros",
                UserId = AdminUser.Id
            };
        }

        public void SeedPokemonsMoves()
        {
            PokemonsMoves = new List<PokemonMove>()
            {
                new PokemonMove()
                {
                    PokemonId = Venausor1.Id,
                    MoveId = EarthPower.Id
                },
                new PokemonMove()
                {
                    PokemonId = Venausor1.Id,
                    MoveId = GigaDrain.Id
                },
                new PokemonMove()
                {
                    PokemonId = Venausor1.Id,
                    MoveId = SleepPowder.Id
                },
                new PokemonMove()
                {
                    PokemonId = Venausor1.Id,
                    MoveId = SludgeBomb.Id
                },
                new PokemonMove()
                {
                    PokemonId = Infernoape1.Id,
                    MoveId = FirePunch.Id
                },
                new PokemonMove()
                {
                    PokemonId = Infernoape1.Id,
                    MoveId = CloseCombat.Id
                },
                new PokemonMove()
                {
                    PokemonId = Infernoape1.Id,
                    MoveId = ThunderPunch.Id
                },
                new PokemonMove()
                {
                    PokemonId = Infernoape1.Id,
                    MoveId = UTurn.Id
                },
                new PokemonMove()
                {
                    PokemonId = Tyranitar.Id,
                    MoveId = Earthquake.Id
                },
                new PokemonMove()
                {
                    PokemonId = Tyranitar.Id,
                    MoveId = Crunch.Id
                },
                new PokemonMove()
                {
                    PokemonId = Tyranitar.Id,
                    MoveId = RockSlide.Id
                },
                new PokemonMove()
                {
                    PokemonId = Tyranitar.Id,
                    MoveId = IceBeam.Id
                },
                new PokemonMove()
                {
                    PokemonId = Scizor.Id,
                    MoveId = BulletPunch.Id
                },
                new PokemonMove()
                {
                    PokemonId = Scizor.Id,
                    MoveId = BugBite.Id
                },
                new PokemonMove()
                {
                    PokemonId = Scizor.Id,
                    MoveId = SuperPower.Id
                },
                new PokemonMove()
                {
                    PokemonId = Scizor.Id,
                    MoveId = WingAttack.Id
                },
                new PokemonMove()
                {
                    PokemonId = Venausor2.Id,
                    MoveId = Reflect.Id
                },
                new PokemonMove()
                {
                    PokemonId = Venausor2.Id,
                    MoveId = GigaDrain.Id
                },
                new PokemonMove()
                {
                    PokemonId = Venausor2.Id,
                    MoveId = LeechSeed.Id
                },
                new PokemonMove()
                {
                    PokemonId = Venausor2.Id,
                    MoveId = SleepPowder.Id
                },
                new PokemonMove()
                {
                    PokemonId = Infernoape2.Id,
                    MoveId = FlameThrower.Id
                },
                new PokemonMove()
                {
                    PokemonId = Infernoape2.Id,
                    MoveId = CloseCombat.Id
                },
                new PokemonMove()
                {
                    PokemonId = Infernoape2.Id,
                    MoveId = Earthquake.Id
                },
                new PokemonMove()
                {
                    PokemonId = Infernoape2.Id,
                    MoveId = UTurn.Id
                }               
            };
        }

        public void SeedTeams()
        {
            Team1 = new Team()
            {
                Id = 1,
                Name = "Team1",
                PlayerId = Player1.Id,
                Wins = 10,
                Losses = 5
            };

            Team2 = new Team()
            {
                Id = 2,
                Name = "Team2",
                PlayerId = Player1.Id,
                Wins = 100,
                Losses = 0
            };
        }
        public void SeedPokemon()
        {
            Venausor1 = new Pokemon()
            {
                Id = 1,
                Name = "Venusaur",
                PokeDexNumber = 3,
                Type1 = PokemonTypeCustom.Grass,
                Type2 = PokemonTypeCustom.Poison,
                AbilityId = Chlorophyll.Id,
                BaseHP = 80,
                BaseAttack = 82,
                BaseDefense = 83,
                BaseSpecialAttack = 100,
                BaseSpecialDefense = 100,
                BaseSpeed = 80,
                GenerationCustom = 1,
                EvHP = 0,
                EvAttack = 0,
                EvDefence = 0,
                EvSpecialAttack = 0,
                EvSpecialDefense = 4,
                EvSpeed = 0,
                HP = 80,
                Attack = 82,
                Defense = 83,
                SpecialAttack = 100,
                SpecialDefense = 100,
                Speed = 80,
                TeamId = Team1.Id,
                PlayerId = Player1.Id          

            };

            Infernoape1 = new Pokemon()
            {
                Id = 2,
                Name = "Infernape",
                PokeDexNumber = 392,
                Type1 = PokemonTypeCustom.Fire,
                Type2 = PokemonTypeCustom.Fighting,
                AbilityId = IronFist.Id,
                BaseHP = 76,
                BaseAttack = 104,
                BaseDefense = 71,
                BaseSpecialAttack = 104,
                BaseSpecialDefense = 71,
                BaseSpeed = 108,
                GenerationCustom = 4,
                EvHP = 0,
                EvAttack = 0,
                EvDefence = 0,
                EvSpecialAttack = 0,
                EvSpecialDefense = 0,
                EvSpeed = 0,
                HP = 76,
                Attack = 104,
                Defense = 71,
                SpecialAttack = 104,
                SpecialDefense = 71,
                Speed = 108,
                TeamId = Team1.Id,
                PlayerId = Player1.Id
            };

            Tyranitar = new Pokemon()
            {
                Id = 3,
                Name = "Tyranitar",
                PokeDexNumber = 248,
                Type1 = PokemonTypeCustom.Rock,
                Type2 = PokemonTypeCustom.Dark,
                AbilityId = Adaptability.Id,
                BaseHP = 100,
                BaseAttack = 134,
                BaseDefense = 110,
                BaseSpecialAttack = 95,
                BaseSpecialDefense = 100,
                BaseSpeed = 61,
                GenerationCustom = 2,
                EvHP = 0,
                EvAttack = 0,
                EvDefence = 0,
                EvSpecialAttack = 0,
                EvSpecialDefense = 0,
                EvSpeed = 0,
                HP = 100,
                Attack = 134,
                Defense = 110,
                SpecialAttack = 95,
                SpecialDefense = 100,
                Speed = 61,
                TeamId = Team1.Id,
                PlayerId = Player1.Id
            };

            Scizor = new Pokemon()
            {
                Id = 4,
                Name = "Scizor",
                PokeDexNumber = 212,
                Type1 = PokemonTypeCustom.Bug,
                Type2 = PokemonTypeCustom.Steel,
                AbilityId = Technichian.Id,
                BaseHP = 70,
                BaseAttack = 130,
                BaseDefense = 100,
                BaseSpecialAttack = 55,
                BaseSpecialDefense = 80,
                BaseSpeed = 65,
                GenerationCustom = 2,
                EvHP = 0,
                EvAttack = 0,
                EvDefence = 0,
                EvSpecialAttack = 0,
                EvSpecialDefense = 0,
                EvSpeed = 0,
                HP = 70,
                Attack = 130,
                Defense = 100,
                SpecialAttack = 55,
                SpecialDefense = 80,
                Speed = 65,
                TeamId = Team2.Id,
                PlayerId = Player1.Id
            };

            Infernoape2 = new Pokemon()
            {
                Id = 5,
                Name = "Infernape",
                PokeDexNumber = 392,
                Type1 = PokemonTypeCustom.Fire,
                Type2 = PokemonTypeCustom.Fighting,
                AbilityId = IronFist.Id,
                BaseHP = 76,
                BaseAttack = 104,
                BaseDefense = 71,
                BaseSpecialAttack = 104,
                BaseSpecialDefense = 71,
                BaseSpeed = 108,
                GenerationCustom = 4,
                EvHP = 0,
                EvAttack = 0,
                EvDefence = 0,
                EvSpecialAttack = 0,
                EvSpecialDefense = 0,
                EvSpeed = 0,
                HP = 76,
                Attack = 104,
                Defense = 71,
                SpecialAttack = 104,
                SpecialDefense = 71,
                Speed = 108,
                TeamId = Team2.Id,
                PlayerId = Player1.Id
            };
            Venausor2 = new Pokemon()
            {
                Id = 6,
                Name = "Venusaur",
                PokeDexNumber = 3,
                Type1 = PokemonTypeCustom.Grass,
                Type2 = PokemonTypeCustom.Poison,
                AbilityId = Chlorophyll.Id,
                BaseHP = 80,
                BaseAttack = 82,
                BaseDefense = 83,
                BaseSpecialAttack = 100,
                BaseSpecialDefense = 100,
                BaseSpeed = 80,
                GenerationCustom = 1,
                EvHP = 0,
                EvAttack = 0,
                EvDefence = 0,
                EvSpecialAttack = 0,
                EvSpecialDefense = 0,
                EvSpeed = 0,
                HP = 80,
                Attack = 82,
                Defense = 83,
                SpecialAttack = 100,
                SpecialDefense = 100,
                Speed = 80,
                TeamId = Team2.Id,
                PlayerId= Player1.Id

            };


        }
        public void SeedAbility()
        {
            Chlorophyll = new Ability
            {
                Id = 1,
                Name = "Chlorophyll",
                Description = "Boosts the Pokémon's Speed stat in harsh sunlight.",
                PhaseOfCombatActivaton = PhaseOfCombatAbility.StartOfTurn,
            };

            IronFist = new Ability
            {
                Id = 2,
                Name = "Iron Fist",
                Description = "Powers up punching moves.",
                PhaseOfCombatActivaton = PhaseOfCombatAbility.BeforeAttack,
            };

            Technichian = new Ability
            {
                Id = 3,
                Name = "Technician",
                Description = "Powers up the Pokémon's weaker moves.",
                PhaseOfCombatActivaton = PhaseOfCombatAbility.BeforeAttack,
            };

            Adaptability = new Ability
            {
                Id = 4,
                Name = "Adaptability",
                Description = "Powers up moves of the same type.",
                PhaseOfCombatActivaton = PhaseOfCombatAbility.BeforeAttack,
            };
        }

        public void SeedMoves()
        {
            FlameThrower = new Move
            {
                Id = 1,
                Name = "Flame Thrower",
                Type = "Fire",
                Power = 90,
                Accuracy = 100,
                PowerPoints = 15,
                Ailment = "Burn",
                AilmentChance = 10,
                DamageClass = DamageClass.Special,
                Description = "The target is scorched with an intense blast of fire. This may also leave the target with a burn."
            };

            ThunderPunch = new Move
            {
                Id = 2,
                Name = "Thunder Punch",
                Type = "Electric",
                Power = 75,
                Accuracy = 100,
                PowerPoints = 15,
                Ailment = "Paralysis",
                AilmentChance = 10,
                DamageClass = DamageClass.Physical,
                Description = "The target is punched with an electrified fist. This may also leave the target with paralysis."
            };

            GigaDrain = new Move
            {
                Id = 3,
                Name = "Giga Drain",
                Type = "Grass",
                Power = 75,
                Accuracy = 100,
                PowerPoints = 10,
                Effect = "Heal",
                EffectChance = 100,
                DamageClass = DamageClass.Special,
                IsEffectUser = true,
                HealAmount = 50,
                HealType = HealType.OpponentHP,
                Description = "A nutrient-draining attack. The user's HP is restored by half the damage taken by the target."
            };

            SleepPowder = new Move
            {
                Id = 4,
                Name = "Sleep Powder",
                Type = "Grass",
                Power = 0,
                Accuracy = 75,
                PowerPoints = 15,
                Ailment = "Sleep",
                AilmentChance = 100,
                DamageClass = DamageClass.Status,
                Description = "The user scatters a big cloud of sleep-inducing dust around the target."
            };

            SolarBeam = new Move
            {
                Id = 5,
                Name = "Solar Beam",
                Type = "Grass",
                Power = 120,
                Accuracy = 100,
                PowerPoints = 10,
                AilmentChance = 0,
                DamageClass = DamageClass.Special,
                Description = "In this two-turn attack, the user gathers light, then blasts a bundled beam on the next turn."
            };

            Earthquake = new Move
            {
                Id = 6,
                Name = "Earthquake",
                Type = "Ground",
                Power = 100,
                Accuracy = 100,
                PowerPoints = 10,
                DamageClass = DamageClass.Physical,
                Description = "The user sets off an earthquake that strikes every Pokémon around it."

            };

            WingAttack = new Move
            {
                Id = 7,
                Name = "Wing Attack",
                Type = "Flying",
                Power = 60,
                Accuracy = 100,
                PowerPoints = 35,
                DamageClass = DamageClass.Physical,
                Description = "The target is struck with large, imposing wings spread wide to inflict damage."
            };

            BugBite = new Move
            {
                Id = 8,
                Name = "Bug Bite",
                Type = "Bug",
                Power = 60,
                Accuracy = 100,
                PowerPoints = 20,
                DamageClass = DamageClass.Physical,
                Description = "The user bites the target. If the target is holding a Berry, the user eats it and gains its effect."
            };

            UTurn = new Move
            {
                Id = 9,
                Name = "U-Turn",
                Type = "Bug",
                Power = 70,
                Accuracy = 100,
                PowerPoints = 20,
                Effect = "Force Switch",
                EffectChance = 100,
                DamageClass = DamageClass.Physical,
                IsEffectUser = true,
                Description = "After making its attack, the user rushes back to switch places with a party Pokémon in waiting."
            };

            CloseCombat = new Move
            {
                Id = 10,
                Name = "Close Combat",
                Type = "Fighting",
                Power = 120,
                Accuracy = 100,
                PowerPoints = 5,
                Effect = "Lower Def and SpDef",
                DamageClass = DamageClass.Physical,
                IsEffectUser = true,
                Description = "The user fights the target up close without guarding itself. This also lowers the user's Defense and Sp. Def stats."
            };

            BulletPunch = new Move
            {
                Id = 11,
                Name = "Bullet Punch",
                Type = "Steel",
                Power = 40,
                Accuracy = 100,
                PowerPoints = 30,
                DamageClass = DamageClass.Physical,
                Priority = 1,
                Description = "The user strikes the target with tough punches as fast as bullets."
            };

            SuperPower = new Move
            {
                Id = 12,
                Name = "Super Power",
                Type = "Fighting",
                Power = 120,
                Accuracy = 100,
                PowerPoints = 5,
                Effect = "Lower Attack and Defense",
                EffectChance = 100,
                DamageClass = DamageClass.Physical,
                IsEffectUser = true,
                Description = "The user attacks the target with great power. However, this also lowers the user's Attack and Defense stats."
            };

            EarthPower = new Move
            {
                Id = 13,
                Name = "Earth Power",
                Type = "Ground",
                Power = 90,
                Accuracy = 100,
                PowerPoints = 10,
                Effect = "Lower SpDef",
                EffectChance = 10,
                DamageClass = DamageClass.Special,
                IsEffectUser = false,
                Description = "The user makes the ground under the target erupt with power. This may also lower the target's Sp. Def stat."
            };

            RockSlide = new Move
            {
                Id = 14,
                Name = "Rock Slide",
                Type = "Rock",
                Power = 75,
                Accuracy = 90,
                PowerPoints = 10,
                Effect = "Flinch",
                EffectChance = 30,
                DamageClass = DamageClass.Physical,
                IsEffectUser = false,
                Description = "Large boulders are hurled at the opposing Pokémon to inflict damage. This may also make the opposing Pokémon flinch."
            };

            Crunch = new Move
            {
                Id = 15,
                Name = "Crunch",
                Type = "Dark",
                Power = 80,
                Accuracy = 100,
                PowerPoints = 15,
                Effect = "Lower SpDef",
                EffectChance = 20,
                DamageClass = DamageClass.Physical,
                IsEffectUser = false,
                Description = "The user crunches up the target with sharp fangs. This may also lower the target's Sp. Def stat."
            };

            IceBeam = new Move
            {
                Id = 16,
                Name = "Ice Beam",
                Type = "Ice",
                Power = 90,
                Accuracy = 100,
                PowerPoints = 10,
                Ailment = "Freeze",
                AilmentChance = 10,
                DamageClass = DamageClass.Special,
                Description = "The target is struck with an icy-cold beam of energy. This may also leave the target frozen."
            };

            FirePunch = new Move
            {
                Id = 17,
                Name = "Fire Punch",
                Type = "Fire",
                Power = 75,
                Accuracy = 100,
                PowerPoints = 15,
                Ailment = "Burn",
                AilmentChance = 10,
                DamageClass = DamageClass.Physical,
                Description = "The target is punched with a fiery fist. This may also leave the target with a burn."
            };

            BrickBreak = new Move
            {
                Id = 18,
                Name = "Brick Break",
                Type = "Fighting",
                Power = 75,
                Accuracy = 100,
                PowerPoints = 15,
                Effect = "Breaks Light Screen and Reflect",
                EffectChance = 100,
                DamageClass = DamageClass.Physical,
                IsEffectUser = false,
                Description = "The user attacks with a swift chop. It can also break barriers, such as Light Screen and Reflect."
            };

            SludgeBomb = new Move
            {
                Id = 19,
                Name = "Sludge Bomb",
                Type = "Poison",
                Power = 90,
                Accuracy = 100,
                PowerPoints = 10,
                Ailment = "Poison",
                AilmentChance = 30,
                DamageClass = DamageClass.Special,
                Description = "Unsanitary sludge is hurled at the target. This may also poison the target."
            };

            Reflect = new Move
            {
                Id = 20,
                Name = "Reflect",
                Type = "Psychic",
                Power = 0,
                Accuracy = 0,
                PowerPoints = 20,
                Effect = "Doubles Defense",
                EffectChance = 100,
                EffectDuration = 5,
                DamageClass = DamageClass.Status,
                IsEffectUser = true,
                Description = "A wondrous wall of light is put up to reduce damage from physical attacks for five turns."
            };

            LeechSeed = new Move
            {
                Id = 21,
                Name = "Leech Seed",
                Type = "Grass",
                Power = 0,
                Accuracy = 90,
                PowerPoints = 10,
                Effect = "Drain HP",
                EffectChance = 100,
                Ailment = "Seeded",
                AilmentChance = 100,
                DamageClass = DamageClass.Status,
                IsEffectUser = false,
                HealAmount = 12,
                HealType = HealType.OpponentHP,
                Description = "A seed is planted on the target. It steals some HP from the target every turn."
            };
        }
    }
}
