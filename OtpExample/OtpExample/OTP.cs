using System.Security.Cryptography;
using System.Text;

namespace OtpExample;

public class OTP
{
    public string GenerateOTP()
    {
        Random rnd = new Random();
        var randomNumber = rnd.Next(100000, 999999).ToString();
        return randomNumber;
    }
}