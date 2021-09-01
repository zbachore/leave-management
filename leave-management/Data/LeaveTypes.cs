using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace leave_management.Data
{
public class LeaveTypes
{
[Key]
    public int Id {get; set;}
    [Required]
    public string Name {get; set;}
    public DateTime DateCreated {get; set;}

}
}