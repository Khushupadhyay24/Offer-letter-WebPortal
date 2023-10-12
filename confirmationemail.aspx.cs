using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using iTextSharp.text.pdf.qrcode;
using Button = System.Windows.Forms.Button;
using System.Web.Services;
//using Button = System.Web.UI.WebControls.Button;

namespace EmployeeOL
{
    public partial class confirmationemail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static string btnAccept()
        {

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("khushupadhyay5020@gmail.com", "Khush upadhyay");
            mail.To.Add(new MailAddress("pariupadhyay456@gmail.com", "Hr department"));
            mail.Subject = "Offer letter Accept by the employeee";
            mail.Body = "<p>I accept the offer letter</p>";
            mail.IsBodyHtml = true;
           
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = true;
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new NetworkCredential("khushupadhyay5020@gmail.com", "nbpubsfvnvdrqhcv");
            smtp.Send(mail);

            //Response.Write("<script>alert('Email send to HR team.')</script>");
            return "<script>alert('Email send to HR team.')</script>";
        }
        public static string btnReject()
        {

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("khushupadhyay5020@gmail.com", "Khush upadhyay");
            mail.To.Add(new MailAddress("pariupadhyay456@gmail.com", "Hr department"));
            mail.Subject = "Offer letter Accept by the employeee";
            mail.Body = "<p>I Reject the offer letter</p>";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = true;
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new NetworkCredential("khushupadhyay5020@gmail.com", "nbpubsfvnvdrqhcv");
            smtp.Send(mail);

            //Response.Write("<script>alert('Email send to HR team.')</script>");
            return "<script>alert('Email send to HR team.')</script>";


        }

    }
}