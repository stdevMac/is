using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Country
    {
        [Key]
        public int Country_ID { get; set; }
        public string Country_Name { get; set; }
        public int Region_ID { get; set; }
    }
}
