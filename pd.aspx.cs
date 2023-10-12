using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace EmployeeOL

{
    public partial class pd : System.Web.UI.Page
    {


        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        BindGrid();
        //    }
        //}
        //private void BindGrid()
        //{
        //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-U932T1B\\MSSQLSERVER01;Initial Catalog=userlogin;Integrated Security=True");

        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.CommandText = "select Id, Name from tblPdfFiles";
        //        cmd.Connection = con;
        //        con.Open();
        //        GridView1.DataSource = cmd.ExecuteReader();
        //        GridView1.DataBind();
        //        con.Close();
        //    }
        //}

        //protected void Upload(object sender, EventArgs e)
        //{
        //    string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
        //    string contentType = FileUpload1.PostedFile.ContentType;
        //    using (Stream fs = FileUpload1.PostedFile.InputStream)
        //    {
        //        using (BinaryReader br = new BinaryReader(fs))
        //        {
        //            byte[] bytes = br.ReadBytes((Int32)fs.Length);
        //            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U932T1B\\MSSQLSERVER01;Initial Catalog=userlogin;Integrated Security=True");

        //            string query = "insert into tblPdfFiles values (@Name, @ContentType, @Data)";
        //            using (SqlCommand cmd = new SqlCommand(query))
        //            {
        //                cmd.Connection = con;
        //                cmd.Parameters.AddWithValue("@Name", filename);
        //                cmd.Parameters.AddWithValue("@ContentType", contentType);
        //                cmd.Parameters.AddWithValue("@Data", bytes);
        //                con.Open();
        //                cmd.ExecuteNonQuery();
        //                con.Close();
        //            }
        //        }
        //    }

        //    Response.Redirect(Request.Url.AbsoluteUri);
        //}
        //protected void DownloadFile(object sender, EventArgs e)
        //{
        //    int id = int.Parse((sender as LinkButton).CommandArgument);
        //    byte[] bytes;

        //    string fileName, contentType;
        //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-U932T1B\\MSSQLSERVER01;Initial Catalog=userlogin;Integrated Security=True");

        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.CommandText = "select Name, Data, ContentType from tblPdfFiles where Id=@Id";
        //        cmd.Parameters.AddWithValue("@Id", id);
        //        cmd.Connection = con;
        //        con.Open();
        //        using (SqlDataReader sdr = cmd.ExecuteReader())
        //        {
        //            sdr.Read();
        //            bytes = (byte[])sdr["Data"];
        //            contentType = sdr["ContentType"].ToString();
        //            fileName = sdr["Name"].ToString();
        //        }
        //        con.Close();
        //    }

        //    Response.Clear();
        //    Response.Buffer = true;
        //    Response.Charset = "";
        //    Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //    Response.ContentType = contentType;
        //    Response.AppendHeader("Content-Disposition", "inline; filename=" + fileName);
        //    Response.BinaryWrite(bytes);
        //    Response.Flush();
        //    Response.End();
        //}

        //protected void btnUploadClick(object sender, EventArgs e)
        //{



        //    HttpPostedFile file = Request.Files["myFile"];
        //    if (file != "")
        //    {
        //        //string filename = Path.GetFileName(.PostedFile.FileName);
        //        //Save images into Images folder
        //        //file.SaveAs(Server.MapPath("~/foldername/" + filename);


        //        string fname = Path.GetFileName(file.FileName);
        //        string contentType = file.PostedFile.ContentType;
        //        file.SaveAs(Server.MapPath(Path.Combine("~/PdfFiles/", fname)));

        //        using (Stream fs = file.HttpPostedFile.InputStream)
        //        {
        //            using (BinaryReader br = new BinaryReader(fs))
        //            {
        //                byte[] bytes = br.ReadBytes((Int32)fs.Length);
        //                SqlConnection con = new SqlConnection("Data Source=DESKTOP-U932T1B\\MSSQLSERVER01;Initial Catalog=userlogin;Integrated Security=True");

        //                string query = "insert into tblPdfFiles values (@Name, @ContentType, @Data, @fileurl)";
        //                using (SqlCommand cmd = new SqlCommand(query))
        //                {
        //                    cmd.Connection = con;
        //                    cmd.Parameters.AddWithValue("@Name", file);
        //                    cmd.Parameters.AddWithValue("@ContentType", contentType);
        //                    cmd.Parameters.AddWithValue("@Data", bytes);
        //                    cmd.Parameters.AddWithValue("@fileurl", "~/PdfFiles/" + file);
        //                    con.Open();
        //                    cmd.ExecuteNonQuery();
        //                    con.Close();
        //                }
        //            }
        //        }
        //    }
        //}

    }
}