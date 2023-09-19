using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmailSetting
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResult.Text = SendEmail("jarnail@sassypuma.com", "Mail Testing", "This is mail to test the mail settings.");
        }

        protected string SendEmail(string toAddress, string subject, string body)
        {
            //string result = "Message Sent Successfully..!!";

            //System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            //System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient("smtp.gmail.com");

            //mail.From = new System.Net.Mail.MailAddress("dokmeetesting@gmail.com");
            //mail.To.Add("jarnail@sassypuma.com");
            //mail.IsBodyHtml = true;
            //mail.Subject = "Testing Mail";

            //mail.Body = "This is testing mail.";
            //SmtpServer.Port = 587;
            //SmtpServer.EnableSsl = true;
            //SmtpServer.UseDefaultCredentials = false;
            //SmtpServer.Credentials = new System.Net.NetworkCredential("dokmeetesting@gmail.com", "dokmee123");


            //SmtpServer.Send(mail);

            //return result;


            string result = "Message Sent Successfully..!!";

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient("mail.content4work.de");

            mail.From = new System.Net.Mail.MailAddress("outgoing@content4work.de");
            mail.To.Add("jarnail@sassypuma.com");
            mail.IsBodyHtml = true;
            mail.Subject = "Torgau Mail Testing";

            mail.Body = "This is testing mail.";
            SmtpServer.Port = 25;
            SmtpServer.EnableSsl = false;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("outgoing@content4work.de", "outgoing");


            SmtpServer.Send(mail);

            return result;
        }
    }
}