using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntries = new HashSet<EngineerMachine>();
    }
    [DisplayName("Install Date")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd hh:mm tt}")]

    public DateTime InstallDate { get; set; }
    public int MachineId { get; set; }

    [DisplayName("Machine Name")]
    public string MachineName { get; set; }


    public ICollection<EngineerMachine> JoinEntries { get; }
  }
}  