using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APITopicTwister.Model
{
    public class Turn
    {
        [Key]
        public string TurnID { get; set; }
        public virtual Player Player { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
