using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Region
    {
        [Key]
        public int Region_ID { get; set; }
        public string Region_Name { get; set; }
    }
}
