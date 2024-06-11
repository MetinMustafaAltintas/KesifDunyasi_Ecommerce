using System.Net.Mail;
using System.Net;
using System.Text;
using Project.COMMON.Models;

namespace Project.COMMON.Tools
{
    public static class MailService
    {
        //Mail'in sifresi : BilgeAdam123
        public static void Send(string receiver,  string password = "oktczfjzfohickzn", string body = "Test mesajıdır", string subject = "Keşif Dünyası", string sender = "yzlm3170@gmail.com" , string senderName = "Keşif Dünyası")
        {
            MailAddress senderEmail = new(sender, senderName);
            MailAddress receiverEmail = new(receiver);

            //Bizim Email işlemlerimiz SMTP'ye göre yapılır...
            //Kullandıgınız gmail hesabınızın baska uygulamalar tarafından mesaj gönderme sistemini acmanız lazım...

            SmtpClient smtp = new()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password)

            };


            using (MailMessage message = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
            {
                smtp.Send(message);
            }

        }
        public static void MailOrder(string receiverEmail, List<OrderedProducts> productList, string password = "oktczfjzfohickzn", string subject = "Satın Aldığınız Ürünler", string senderEmail = "yzlm3170@gmail.com")
        {
            StringBuilder htmlContent = new StringBuilder();
            htmlContent.Append("<html>");
            htmlContent.Append("<head></head>");
            htmlContent.Append("<body>");
            htmlContent.Append("<p>Merhaba,</p>");
            htmlContent.Append("<p>Aşağıda satın aldığınız ürünlerin listesini bulabilirsiniz:</p>");
            htmlContent.Append("<table border='1'>");
            htmlContent.Append("<tr><th>Ürün Adı</th><th>Adet</th><th>Fiyat</th></tr>");

            decimal total = 0; // Toplam fiyatı hesaplamak için bir değişken tanımlayın

            foreach (var product in productList)
            {
                htmlContent.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", product.Name, product.Quantity, product.PriceFormatted);
                total += product.Price; // Her ürünün fiyatını toplam fiyata ekleyin
            }

            // Toplam fiyatı tabloya ekleyin
            htmlContent.AppendFormat("<tr><td><b>Toplam</b></td><td></td><td><b>{0}</b></td></tr>", total.ToString("C"));

            htmlContent.Append("</table>");
            htmlContent.Append("<p>Teşekkürler!</p>");
            htmlContent.Append("</body>");
            htmlContent.Append("</html>");

            Send(receiverEmail, password, htmlContent.ToString(), subject, senderEmail);
        }
    }
}
