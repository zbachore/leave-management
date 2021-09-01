using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace leave_management.Data
{
public class LeaveHistory
{
[Key]
    public int Id {get; set;}
        [ForeignKey("RequestingEmployeeId")]
    public Employee RequestingEmployee {get; set;}
    public string RequestingEmployeeId {get; set;}
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public LeaveTypes LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public DateTime DateRequested { get; set; }
    public DateTime DateActioned { get; set; }
    public bool? Approved { get; set; }
    public Employee ApprovedBy { get; set; }
    public string ApprovedById { get; set; }
    }
}