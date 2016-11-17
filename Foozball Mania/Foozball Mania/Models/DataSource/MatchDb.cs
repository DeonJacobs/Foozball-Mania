using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Foozball_Mania.Models.DataSource
{
    //Class inherits from EntityFramework DbContext taking care of data access to SQL server.
    public class MatchDb : DbContext, IMatchDataSource
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<MatchResult> MatchResults { get; set; }

        IQueryable<Player> IMatchDataSource.Players
        {
            get { return Players;  }
                        
        }

        IQueryable<MatchResult> IMatchDataSource.MatchResults
        {
            get { return MatchResults;  }        
            
        }
        
        

    }
}