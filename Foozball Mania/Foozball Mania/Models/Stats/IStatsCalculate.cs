using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foozball_Mania.Models.Stats
{
    interface IStatsCalculate
    {
        List<WLStat> OnePlayerStats(PlayerSelection playerSelection);
    }
}
