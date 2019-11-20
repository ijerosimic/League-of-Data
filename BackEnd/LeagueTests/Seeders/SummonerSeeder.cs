using LeagueDataAccess;
using LeagueEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueTests.Seeders
{
    public static class SummonersSeeder
    {
        public static LeagueContext SeedDbWithFiveSummoners(
            this LeagueContext context)
        {
            context.Summoners.AddRange(
                new Summoner
                {
                    ID = "m7AAGJrMEY_BO-doJ_kS7WtUu1Y3Co4VZC6uwQhkn960LKg",
                    AccountID = "4gzX2nA07W0cRo07d2PzfwK8GsGsvnuhhhrl6nJmCiSh_HhsBaWzTF4B",
                    PuuID = "IQ4P4RYUh2b9HKgQA7ToK-IFVOk7Om9Pgtu0zPRuRDcuq30DpWcMnGPfaVO-g_3_TfG9HXUnbjbmzg",
                    SummonerName = "Peasant Slayer",
                    SummonerLevel = 48,
                    ServerID = 2,
                    ProfileIconNumber = 2
                },
                new Summoner
                {
                    ID = "V05Y-rXHSb-k4QVBqotnMg-h613l0FZ1nhHh6lZK1Hyq0FQ",
                    AccountID = "huDSrcdoL641P1Cl_qb5Fn482RmH8CSnTVGnvWaI2Tntsg",
                    PuuID = "wUU6zHnRHoPANkg8Hu-GzpDu2kSWW-Q-DUJr5em-rGIje82tfkLPyNf-lBS-r27dxuiOTAg2TNUYYg",
                    SummonerName = "Shimeshugar",
                    SummonerLevel = 99,
                    ServerID = 1,
                    ProfileIconNumber = 2
                },
                new Summoner
                {
                    ID = "-uVM7qgbYUtTbd9JwkAKguKkS6nj8jmm2fYPb2aOhT0N0sA",
                    AccountID = "rKb2TFXFSOzaV_HkOCjlnFMXF7kSAPTVXLGkfGxkLBKU8Q",
                    PuuID = "yQ4OOOwGe9cJXzndsssMNydOKKXqISSKrdY6L2xIPyDfy5CB1H-x6b4XTvwcfFWT6mvwL4rGFA7JFQ",
                    SummonerName = "Koomuch",
                    SummonerLevel = 90,
                    ServerID = 1,
                    ProfileIconNumber = 2
                },
                new Summoner
                {
                    ID = "ICRohXMWj5jWzLJrxgH82_xYJypMhum3UG_ZkI9UecRJNWk",
                    AccountID = "E5vIgzYH88uYhb9LGTKuQG3IEoV8j9ny7pSP-ifKuWsx5Q",
                    PuuID = "C_XMHirlQ00s1Mg01HdI054DL3OPXo0EYMWuHO0xhqJs11RtZOvjdjifCJnm3x3KfsG1uQ76vjeqWQ",
                    SummonerName = "ubnix",
                    SummonerLevel = 47,
                    ServerID = 1,
                    ProfileIconNumber = 2
                },
                new Summoner
                {
                    ID = "0sIa8mv2kdRhUicAKIb0pMCtA9eEYivCAfAW7ZGBZz5qlME0",
                    AccountID = "_C6SbKcmVJlqt39rRSrezcQfQBbtF_AalXyoOpwK6Cl5wwkCj2tATFEt",
                    PuuID = "fI3yFRsBsPj-M-BlsWxMRNQ15xjBVPx-af2DNhTma6F21r9231E-b61p36WyJ79ydFsIcqyZxNJcCg",
                    SummonerName = "Major Alexander",
                    SummonerLevel = 60,
                    ServerID = 2,
                    ProfileIconNumber = 2
                }
                );

            context.SaveChanges();

            return context;
        }
    }
}
