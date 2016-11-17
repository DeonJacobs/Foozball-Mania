using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Foozball_Mania.Models
{
    public class ResultReturn
    {
        public string PlayerWin { get; set; }
        public string PlayerLoose { get; set; }
        public int PlayerWScore { get; set; }
        public int PlayerLScore { get; set; }
                
    }
}