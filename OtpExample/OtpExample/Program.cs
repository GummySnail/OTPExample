using OtpExample;

var otp = new OTP();
var smtp = new Email();
var user = new User("f_df_79@mail.ru", "rootroot");

Console.WriteLine("Enter email:\t");
var enteredEmail = Console.ReadLine();
Console.WriteLine("Enter password:\t");
var enteredPassword = Console.ReadLine();
if (user.Email == enteredEmail && user.Password == enteredPassword)
{
    var code = otp.GenerateOTP();
    user.TempCode = code;
    smtp.SendEmail(enteredEmail, code);    
}

while (true)
{
    Console.WriteLine("Enter code:\t");
    var enteredCode = Console.ReadLine();
    if (enteredCode == user.TempCode)
    {
        user.TempCode = null;
        break;
    }
    Console.WriteLine("Wrong code");
}
Console.WriteLine("You successfully sign in");


