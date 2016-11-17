using Foozball_Mania.Models.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foozball_Mania.Models.Stats
{
    public class StatsCalculate : IStatsCalculate
    {
        MatchDb MatchDb = new MatchDb();

        public List<WLStat> OnePlayerStats(PlayerSelection playerSelection)
        {
            List<WLStat> OnePlayerStats = new List<WLStat>();

            //One player stats to be calculated
            //Linq query retreiving all win matches for selected player
            var winResult = from r in MatchDb.MatchResults
                            where r.PlayerWin == playerSelection.Player1
                            select new
                            {
                                r.TimeStamp,
                                r.PlayerWTotal
                            };
            //Linq query retreiving all loose mathces for selected player
            var looseResult = from r in MatchDb.MatchResults
                              where r.PlayerLoose == playerSelection.Player1
                              select new
                              {
                                  r.TimeStamp,
                                  r.PlayerLTotal
                              };

            //join the two results on TimeStamp variable 
            var joinResult = (from winr in winResult
                             join losr in looseResult on winr.TimeStamp equals losr.TimeStamp
                             orderby winr.TimeStamp
                             select new WLStat()
                             {
                                DateHr = winr.TimeStamp,
                                WinCnt = winr.PlayerWTotal,
                                LossCnt = losr.PlayerLTotal
                             }).ToList();

            //Still need to complete stats analyis:
            // group by function
            // 2 player statistics
            return (joinResult);
        }
    }
}