using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Foozball_Mania.Models
{
    public class MatchResult
    {
        [Key]
        public int MatchResultId { get; set; }
        public string TimeStamp { get; set; }
        public string PlayerWin { get; set; }
        public string PlayerLoose { get; set; }
        public int PlayerWTotal { get; set; }
        public int PlayerLTotal { get; set; }
        
    }
}