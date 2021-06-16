using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APITopicTwister.Model
{
    public class Round
    {
        [Key]
        public string RoundID { get; set; }
        public virtual ICollection<Turn> Turns { get; set; }
        public virtual Letter Letter { get; set; }
    }
}
