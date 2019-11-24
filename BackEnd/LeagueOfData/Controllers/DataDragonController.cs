using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using LeagueDataAccess;
using LeagueEntities.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LeagueOfData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataDragonController : ControllerBase
    {
        readonly IWebHostEnvironment env;
        readonly LeagueContext context;

        public DataDragonController(
            IWebHostEnvironment env,
            LeagueContext context)
        {
            this.env = env;
            this.context = context;
        }

        [HttpGet("FetchChampionsData")]
        public void FetchChampionsData()
        {
            var champs = new List<TempChampion>();

            using (HttpClient client = new HttpClient())
            {
                using (StreamReader r = new StreamReader(
                    $"{env.WebRootPath}/Assets/champions.json"))
                {
                    string json = r.ReadToEnd();
                    var array = JObject.Parse(json);

                    foreach (var a in array)
                    {
                        champs.Add(JsonConvert.DeserializeObject<TempChampion>(a.Value.ToString()));
                    }
                }
            }

            new Mapper(context).MapChampion(champs);
        }

        [HttpGet("FetchItemsData")]
        public void FetchItemsData()
        {
            var items = new List<Item>();

            using (HttpClient client = new HttpClient())
            {
                using (StreamReader r = new StreamReader(
                    $"{env.WebRootPath}/Assets/items.json"))
                {
                    string json = r.ReadToEnd();
                    var array = JArray.Parse(json);

                    foreach (var a in array)
                    {
                        items.Add(new Item
                        {
                            ID = a["id"].Value<int>(),
                            ItemName = a["name"].Value<string>()
                        });
                    }
                }
            }

            new Mapper(context).MapItem(items);
        }
    }

    public class Mapper
    {
        readonly LeagueContext context;

        public Mapper(LeagueContext context)
        {
            this.context = context;
        }

        public void MapChampion(List<TempChampion> champions)
        {
            context.Database.BeginTransaction();
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Champions ON");

            foreach (var champ in champions)
            {
                var dbChamp = new Champion
                {
                    ID = champ.Key,
                    ChampionName = champ.Name,
                    ChampionTitle = champ.Title,
                    ChampionDescription = champ.Blurb ?? string.Empty
                };
                context.Add(dbChamp);

                var dbInfo = new ChampionStats
                {
                    ResourceType = champ.Partype,
                    Attack = champ.Info.Attack,
                    Defense = champ.Info.Defense,
                    Magic = champ.Info.Magic,
                    Difficulty = champ.Info.Difficulty,
                    HitPoints = champ.Stats.Hp,
                    HitPointsPerLevel = champ.Stats.HpPerLevel,
                    ManaPoints = champ.Stats.Mp,
                    ManaPointsPerLevel = champ.Stats.MpPerLevel,
                    MoveSpeed = champ.Stats.Movespeed,
                    Armor = champ.Stats.Armor,
                    ArmorPerLevel = champ.Stats.ArmorPerLevel,
                    SpellBlock = champ.Stats.Spellblock,
                    SpellBlockPerLevel = champ.Stats.SpellblockPerLevel,
                    AttackRange = champ.Stats.AttackRange,
                    HitPointsRegen = champ.Stats.HpRegen,
                    HitPointsRegenPerLevel = champ.Stats.HpRegenPerLevel,
                    ManaPointsRegen = champ.Stats.MpRegen,
                    ManaPointsRegenPerLevel = champ.Stats.MpRegenPerLevel,
                    CritChance = champ.Stats.Crit,
                    CritChancePerLevel = champ.Stats.CritPerLevel,
                    AttackDamage = champ.Stats.AttackDamage,
                    AttackDamagePerLevel = champ.Stats.AttackDamagePerLevel,
                    ChampionID = champ.Key
                };
                context.Add(dbInfo);

                foreach (var tag in champ.Tags)
                {
                    int tagID = 0;

                    switch (tag)
                    {
                        case "Fighter":
                            tagID = 1;
                            break;

                        case "Tank":
                            tagID = 2;
                            break;

                        case "Mage":
                            tagID = 3;
                            break;

                        case "Assassin":
                            tagID = 4;
                            break;

                        case "Support":
                            tagID = 5;
                            break;

                        case "Marksman":
                            tagID = 6;
                            break;
                    }

                    context.Add(new ChampionTags
                    {
                        ChampionID = champ.Key,
                        TagID = tagID
                    });
                }
            }

            context.SaveChanges();
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Champions OFF;");
            context.Database.CommitTransaction();
        }

        public void MapItem(List<Item> items)
        {
            context.Database.BeginTransaction();
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Items ON");
            context.AddRange(items);
            context.SaveChanges();
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Items OFF;");
            context.Database.CommitTransaction();
        }
    }

    public class TempChampion
    {
        public string ID { get; set; }
        public int Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public string Partype { get; set; }
        public Info Info { get; set; }
        public List<string> Tags { get; set; }
        public Stats Stats { get; set; }
    }

    public class Info
    {
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Magic { get; set; }
        public int Difficulty { get; set; }
    }

    public class Tag
    {
        public string Name { get; set; }
    }

    public class Stats
    {
        public decimal Hp { get; set; }
        public decimal HpPerLevel { get; set; }
        public decimal Mp { get; set; }
        public decimal MpPerLevel { get; set; }
        public decimal Movespeed { get; set; }
        public decimal Armor { get; set; }
        public decimal ArmorPerLevel { get; set; }
        public decimal Spellblock { get; set; }
        public decimal SpellblockPerLevel { get; set; }
        public decimal AttackRange { get; set; }
        public decimal HpRegen { get; set; }
        public decimal HpRegenPerLevel { get; set; }
        public decimal MpRegen { get; set; }
        public decimal MpRegenPerLevel { get; set; }
        public decimal Crit { get; set; }
        public decimal CritPerLevel { get; set; }
        public decimal AttackDamage { get; set; }
        public decimal AttackDamagePerLevel { get; set; }
        public decimal AttackSpeedPerLevel { get; set; }
        public decimal AttackSpeed { get; set; }
    }
}