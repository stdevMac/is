using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Domain
{
    public class State
    {
        [Key]
        public int State_ID { get; set; }
        public string State_Name { get; set; }
    }
}
