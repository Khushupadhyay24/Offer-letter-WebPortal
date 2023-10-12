using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;



namespace EmployeeOL
{
    public partial class GenerateOtp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-U932T1B\\MSSQLSERVER01;Initial Catalog=userlogin;Integrated Security=True");

            //String query = "INSERT INTO generateotp (Email,otp) VALUES (@Email,@otp)";


            //using (SqlCommand command = new SqlCommand(query, con))
            //{


            //    command.Parameters.AddWithValue("@Email", txtEmail.Text);
            //    command.Parameters.AddWithValue("@otp", txtotp.Text);

            //    con.Open();
            //    int i = command.ExecuteNonQuery();
            
            //}
            Random r = new Random();
            string OTP = r.Next(100000, 999999).ToString();

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("khushupadhyay5020@gmail.com", "Khush upadhyay");
            mail.To.Add(new MailAddress(txtEmail.Text));
            mail.Subject = " Otp verification";
            mail.Body = "Your Otp is:" + OTP;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = true;
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new NetworkCredential("khushupadhyay5020@gmail.com", "nbpubsfvnvdrqhcv");
            smtp.Send(mail);

            Response.Write("<script>alert('OTP send successfully your registered Email ID.')</script>");
            Session["OTP"] = OTP;

            //con.Close();

           

        }



        protected void btnVerify_Click(object sender, EventArgs e)
        {

            if (txtotp.Text == Session["OTP"].ToString())
            {
                Response.Write("<script>alert('You have enter correct otp')</script>");
                //Session["OTP"] = null;
                //if (txtotp.Text == Session["OTP"].ToString())
                //{


                //    string FilePath = Server.MapPath("employee-offer-letter.pdf");
                //    WebClient User = new WebClient();
                //    Byte[] FileBuffer = User.DownloadData(FilePath);
                //    if (FileBuffer != null)
                //    {
                //        Response.ContentType = "application/msword";
                //        Response.AddHeader("content-length", FileBuffer.Length.ToString());
                //        Response.BinaryWrite(FileBuffer);
                //    }
            }
            else
            {
                Response.Write("<script>alert('Please enter correct otp')</script>");
            }
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (txtotp.Text == Session["OTP"].ToString())
            {
                // Storing email to Session variable  
                Session["txtEmail"] = txtEmail.Text;
            }
            if (Session["txtEmail"] != null)
            {
                Lbl1.Text = Session["txtEmail"].ToString();
            }
            txtotp.Text = "";
            txtEmail.Text = "";
            Response.Redirect("pd.aspx");
        }
    }
  
    }



    

//        string fileLocation = "userform.db";
//        using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP - U932T1B\\MSSQLSERVER01; Initial Catalog = userlogin; Integrated Security = True"))
//        {
//            connection.Open();
//            SqlCommand command = new SqlCommand("SELECT upload FROM userform WHERE Id=2", connection);
//            command.Parameters.AddWithValue("@id", fileLocation);
//            SqlDataReader reader = command.ExecuteReader();
//            if (reader.Read())
//            {
//                fileLocation = reader.GetString(0);
//            }
//        }
//        byte[] fileData = File.ReadAllBytes(fileLocation);

//        // convert the PDF file to Word format
//        PdfLoadedDocument pdfDocument = new PdfLoadedDocument(fileData);
//        DocToPDFConverter converter = new DocToPDFConverter(pdfDocument);
//        WordDocument worddocument = converter.ConvertToWord(pdfDocument);
//        byte[] wordData = worddocument.Save();

//        // send the Word document to the user
//        Response.Clear();
//        Response.ContentType = "application/msword";
//        Response.AddHeader("content-disposition", "inline;filename=OfferLetter.docx");
//        Response.BinaryWrite(wordData);
//        Response.End();
//    }

//}


