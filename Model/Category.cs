using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APITopicTwister.Model
{
    public class Category
    {
        [Key]
        public string CategoryID { get; set; }
        
    }
}
