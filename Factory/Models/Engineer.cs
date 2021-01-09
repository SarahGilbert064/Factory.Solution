using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.JoinEntries = new HashSet<EngineerMachine>();
        }
        [DisplayName("Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd hh:mm tt}")]
        public DateTime StartDate { get; set; }
        public int EngineerId { get; set; }

        [DisplayName("Engineer Name")]
        public string EngineerName { get; set; }
        public virtual ICollection<EngineerMachine> JoinEntries { get; set; } 
    }
}

