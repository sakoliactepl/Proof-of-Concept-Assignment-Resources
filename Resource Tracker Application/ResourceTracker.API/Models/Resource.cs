using System.ComponentModel.DataAnnotations;

namespace ResourceTracker.API.Models
{
public class Resource
{
    [Key]
    public int EmpId { get; set; }

    [Required]
    public string ResourceName { get; set; } = string.Empty;

    [Required]
    public string Designation { get; set; } = string.Empty;

    public string? ReportingTo { get; set; }

    [Required]
    public bool Billable { get; set; }

    public string? TechnologySkill { get; set; }

    public string? ProjectAllocation { get; set; }

    public string? Location { get; set; }

    [Required]
    [EmailAddress]
    public string EmailId { get; set; } = string.Empty;

    [Required]
    public DateTime CteDoj { get; set; }

    public string? Remarks { get; set; }
}
}