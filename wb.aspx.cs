using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EmployeeOL
{
    public partial class wb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-U932T1B\\MSSQLSERVER01;Initial Catalog=userlogin;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("Select * from LoginTb where Username=@Username and Password=@Password",con);

            //cmd.Parameters.AddWithValue("@Username", txtusername.Text);
            //cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Open();
            //int i = cmd.ExecuteNonQuery();
            //con.Close();
            //if (dt.Rows.Count > 0)
            //{
            //    Response.Redirect("UserForm.aspx");


            //}
            //else
            //{
            //    Response.Write("<script>alert('Please enter valid Username and Password')</script>");

            //}
            String query = "INSERT INTO LoginTb (Username,Password) VALUES (@Username,@Password)";
           
            
                using (SqlCommand command = new SqlCommand(query, con))
                {

                    
                    command.Parameters.AddWithValue("@Username", txtusername.Text);
                    command.Parameters.AddWithValue("@Password", txtpassword.Text);
                   

                    con.Open();
                    int result = command.ExecuteNonQuery();




                    if (result < 0)

                    
                        Response.Write("<script>alert('Welcome to India Bison')</script>");
                        con.Close();
                        Response.Redirect("UserForm.aspx");
                    

                } 
            }
           
        }

    }
    


    
