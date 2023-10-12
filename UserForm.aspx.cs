using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mime;
using System.Net;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeOL

{
    public partial class UserForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }



       

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U932T1B\\MSSQLSERVER01;Initial Catalog=userlogin;Integrated Security=True");

            String query = "INSERT INTO userform (Email,Upload) VALUES (@Email,@Upload)";
           
            
                using (SqlCommand command = new SqlCommand(query, con))
                {


                    command.Parameters.AddWithValue("@Email", txttoEmail.Text);
                    command.Parameters.AddWithValue("Upload", fldupload.FileName);

                    con.Open();
                    int i = command.ExecuteNonQuery();
                con.Close();
                // Check Error
            }
            

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("khushupadhyay5020@gmail.com", "Khush upadhyay");
            mail.To.Add(new MailAddress(txttoEmail.Text));
            mail.Subject = "Employee offer letter";
            mail.Body = "<p>Please click on the below link and complete the further process.</p> <p>https://localhost:44344/GenerateOtp.aspx</p>";
            mail.IsBodyHtml = true;
           
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl= true;
            smtp.UseDefaultCredentials= true;
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new NetworkCredential("khushupadhyay5020@gmail.com", "nbpubsfvnvdrqhcv");
            smtp.Send(mail);
            Response.Write("<script>alert('Details has been sent to the user's email');</script>");

            //Response.Write("<script>alert('Details has been sent to the user's email');</script>");
            

        }
    }
}

