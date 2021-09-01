using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace leave_management.Data
{
public class LeaveAllocation
{
[Key]
    public int Id {get; set;}
    public string NumberOfDays {get; set;}
    public DateTime DateCreated {get; set;}
    [ForeignKey("EmployeeId")]
    public Employee Employee { get; set; }
    public string EmployeeId { get; set; }
    [ForeignKey("LeaveTypeId")]
    public string LeaveType { get; set; }
    public string LeaveTypeId { get; set; }

    }
}