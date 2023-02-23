using System.Net.Mail;

namespace OtpExample;

public class Email
{
    public void SendEmail(string receiverEmail, string code)
    {
        try
        {
            MailMessage newMail = new MailMessage();
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            newMail.From = new MailAddress("innoclinic001@gmail.com", "Clinic");
            newMail.To.Add(receiverEmail);
            newMail.Subject = "Verification Code";
            //newMail.IsBodyHtml = true;
            newMail.Body = $"Your verification code is {code}";
            client.EnableSsl = true;
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential("innoclinic001@gmail.com", "iumwhdmragwpvjkz");
            client.Send(newMail);
            Console.WriteLine("Email Sent");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        
    }
}