namespace Foozball_Mania.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Foozball_Mania.Models.DataSource.MatchDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Foozball_Mania.Models.DataSource.MatchDb context)
        {
            //context.Players.AddOrUpdate(d => new { d.Name, d.FamilyName },
            //new Player
            //{
            //    Name = "Peter",
            //    FamilyName = "Best"
            //},
            //new Player
            //{
            //    Name = "William",
            //    FamilyName = "Green"
            //}
            //);

            context.MatchResults.AddOrUpdate(d => new { d.TimeStamp, d.PlayerWin, d.PlayerLoose, d.PlayerWTotal, d.PlayerLTotal},
            new MatchResult
            {
                TimeStamp = DateTime.Now.ToString("yyyy-MM-dd-HH"),
                PlayerWin = "John Cola",
                PlayerLoose = "Peter Sprite",
                PlayerWTotal = 10,
                PlayerLTotal = 4
            }
            );
        }
    }
}
