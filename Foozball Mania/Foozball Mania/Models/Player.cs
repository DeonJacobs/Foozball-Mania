using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Foozball_Mania.Models
{
    public class Player
    {

        [Key]
        public int PlayerId { get; set; }
        [Required]
        [StringLength(255)]
        public virtual string Name { get; set; }
        public virtual string FamilyName { get; set; }
    }
}