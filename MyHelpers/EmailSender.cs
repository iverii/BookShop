using SendGrid;
using SendGrid.Helpers.Mail;

namespace BestShop.MyHelpers
{
    public class EmailSender
    {
        public static async Task SendEmail(string toEmail, string username,
            string subject, string message)
        {
            string apiKey = "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";
            var client = new SendGridClient(apiKey);

            var from = new EmailAddress("iverii@proton.me", "iveri");
            var to = new EmailAddress(toEmail, username);
            var plainTextContent = message;
            var htmlContent = "";

            var msg = MailHelper.CreateSingleEmail(
                from, to, subject, plainTextContent, htmlContent);

            var response = await client.SendEmailAsync(msg);
        }
    }
}
