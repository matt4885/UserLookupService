﻿namespace UserLookupService.Data;

public class User
{
    public Guid Id { get; set; }
    public string? GivenName { get; set; } = "";
    public string? FamilyName { get; set; } = "";
    public string? Email { get; set; } = "";
    public DateTime DateOfBirth { get; set; }
    public string? Address { get; set; } = "";
    public string? State { get; set; } = "";
    public string? ZipCode { get; set; } = "";
}
