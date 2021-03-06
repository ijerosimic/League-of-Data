﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueEntities.Models
{
    public class Tag
    {
        public Tag()
        {
            ChampionTags = new HashSet<ChampionTags>();
        }

        public int ID { get; set; }
        public string TagName { get; set; }

        public ICollection<ChampionTags> ChampionTags { get; set; }
    }
}
