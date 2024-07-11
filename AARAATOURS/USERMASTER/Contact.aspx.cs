using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AARAATOURS.USERMASTER
{
    public partial class WebForm9 : System.Web.UI.Page
    {
       // SqlConnection con = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=aaraadata.mdb;Trusted_Connection=True;");
       SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\Pen\CMC\Colombo Municipal Council\AARAATOURS\App_Data\aaraadata.mdf"";Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_contact_submit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string str1 = "insert into ContactTbl (fname,femail,fmsg) values (@name, @email, @msg)";
                cmd = new SqlCommand(str1, con);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@msg", txt_msg.Text);
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Feedback Sent Successfully')</script>");
            }
            catch (Exception ex1)
            {
                Response.Write("<script>alert('Fill All Details')</script>");
                Response.Write(ex1.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
