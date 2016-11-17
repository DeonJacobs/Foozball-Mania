using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foozball_Mania.Models.DataSource
{
    public interface IMatchDataSource
    {
        IQueryable<Player> Players { get; }
        IQueryable<MatchResult> MatchResults { get; } 
    }
}
