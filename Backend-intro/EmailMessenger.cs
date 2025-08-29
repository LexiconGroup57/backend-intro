using System.Net.Mail;

namespace Backend_intro;

public class EmailMessenger : IMessage
{
    public void SalesConfirmation(string message)
    {
        // Sales confirmation
        SmtpClient emailClient = new SmtpClient("smtp.example.com")
        {
            // configuration
        };
        MailMessage mail = new MailMessage("", "");
        mail.Subject = "Order confirmation";
        mail.Body = "Thank you for your order!";
        emailClient.Send(mail);

    }

}