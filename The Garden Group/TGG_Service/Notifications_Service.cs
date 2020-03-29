using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using MongoDB.Driver;
using MongoDB.Bson;

namespace TGG_Service
{
    public class Notifications_Service
    {
        public void CreateEmail(string ToEmail, string FromEmail, string Subject, TGG_Model.Status status)
        {
            //create empty message
            string Message = "";

            if (status == TGG_Model.Status.PastDeadline)
            {
                Message = "Dear" + ToEmail+ ", \n" +
                    "Unfortunatly your ticket:'" + Subject +"' has expired passed it's deadline. Therefor it has received status:'" + status.ToString() + ". \n" +
                    "We try to solve you ticket as soon as possible. If your ticket isn't solved within 48 hours please contact the helpdesk."
                    ;
            }
            else if (status == TGG_Model.Status.Pending)
            {
                Message = "Dear" + ToEmail + ", \n" +
                    "Good news! We are currently working on your ticket: '" + Subject + "'. Your ticket status is currently: '" + status.ToString() + "'.";
                    ;
            }
            else if (status == TGG_Model.Status.Solved)
            {
                Message = "Dear" + ToEmail + ", \n" +
                    "Good news! Your ticket:'"+Subject+"' has status:'"+status.ToString()+"'. That means that your ticket should be solved! If your problem isn't fixed please contact the helpdesk."
            }

            if (Message != "")
            {
                //try to create and send email
                try
                {
                    //SMTP mailserver 
                    SmtpClient mySmtpClient = new SmtpClient("mail.inholland-project.nl");

                    // set smtp-client with basicAuthentication
                    mySmtpClient.UseDefaultCredentials = false;
                    System.Net.NetworkCredential basicAuthenticationInfo = new
                       System.Net.NetworkCredential("nodesk@inholland-project.nl", "Pindakaas01");
                    mySmtpClient.Credentials = basicAuthenticationInfo;

                    // add from,to mailaddresses
                    MailAddress from = new MailAddress("nodesk@inholland-project.nl", "NoDesk_Service");
                    MailAddress to = new MailAddress(ToEmail, ToEmail);
                    MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                    // add ReplyTo
                    MailAddress replyto = new MailAddress("nodesk@inholland-project.nl");
                    myMail.ReplyToList.Add(replyto);

                    // set subject and encoding
                    myMail.Subject = Subject;
                    myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                    // set body-message and encoding
                    myMail.Body = Message;
                    myMail.BodyEncoding = System.Text.Encoding.UTF8;
                    // text or html
                    myMail.IsBodyHtml = true;

                    //send email
                    mySmtpClient.Send(myMail);
                }

                //catch exception if one occurs
                catch (SmtpException ex)
                {
                    throw new ApplicationException
                      ("SmtpException has occured: " + ex.Message);
                }

                //throw exeption back as error message.
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
