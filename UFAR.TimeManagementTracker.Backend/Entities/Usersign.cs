﻿public class UserSign
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public int PIN { get; set; }
    
    public string VerificationCode { get; set; } = string.Empty;
    public bool IsVerified { get; set; } = false;

 
}