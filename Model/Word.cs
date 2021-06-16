using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APITopicTwister.Model
{
    public class Word
    {
        [Key]
        public string WordID { get; set; }
        public virtual Letter Letter { get; set; }
        
    }
}
