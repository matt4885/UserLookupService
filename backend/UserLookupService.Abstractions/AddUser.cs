namespace UserLookupService.Abstractions;

public class AddUser
{
    public string? GivenName { get; set; } = "";
    public string? FamilyName { get; set; } = "";
    public string? Email { get; set; } = "";
    public DateTime DateOfBirth { get; set; }
    public string? Address { get; set; } = "";
}
