using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace X22_Lab5_6.Models;
public class Contact 
{
    public uint ContactId { get; set; }
    public string? Name { get; set; }
    [PersonalData]
    public uint StreetNumber { get; set; } = 1;
    [PersonalData]
    public string? StreetName { get; set; }
    [PersonalData]
    [RegularExpression(@"^[A-Za-z][0-9][A-Za-z][ ]*[0-9][A-Za-z][0-9]$")]
    public string? PostalCode { get; set; }
    [PersonalData]
    public string? City { get; set; }
    [PersonalData]
    public string? Province { get; set; }
    [PersonalData]
    public string? Phone { get; set; }
}