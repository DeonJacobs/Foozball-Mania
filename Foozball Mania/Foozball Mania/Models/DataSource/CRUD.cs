using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foozball_Mania.Models.DataSource
{
    public class CRUD : ICRUD
    {
        private MatchDb _matchDb = new MatchDb();
        private MatchResult _matchResult = new MatchResult();
        public string UpdateMatchResult(ResultReturn result)
        {
            string updateResult ="Success";
            try
            {
                _matchResult.TimeStamp = DateTime.Now.ToString("yyyy-MM-dd-HH");
                _matchResult.PlayerWin = result.PlayerWin;
                _matchResult.PlayerLoose = result.PlayerLoose;
                _matchResult.PlayerWTotal = result.PlayerWScore;
                _matchResult.PlayerLTotal = result.PlayerLScore;

                _matchDb.MatchResults.Add(_matchResult);
                _matchDb.SaveChanges();
            }
            catch (Exception e)
            {
                //handle exception
                updateResult = "Failed";
            }
            return (updateResult);
        }
    }
}