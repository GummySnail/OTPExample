namespace OtpExample;

public class User
{
    public User(string email, string password)
    {
        Email = email;
        Password = password;
    }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsOTPVerificated { get; set; } = false;
    public string TempCode = null;
}