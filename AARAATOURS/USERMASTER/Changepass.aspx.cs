using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AARAATOURS.USERMASTER
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string str;

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\Pen\\CMC\\Colombo Municipal Council\\AARAATOURS\\App_Data\\aaraadata.mdf\";Integrated Security=True"].ConnectionString;
            con.Open();
        }

        protected void LinkButton_login_cpass_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("Login.aspx");
            }
            catch
            {

            }
        }

        protected void btn_Change_pass1_Click(object sender, EventArgs e)
        {
            try
            {
                string str1 = "select mobile,email from UserTbl where email='" + txt_changepass_email.Text + "' and mobile='" + txt_changepass_mobile.Text + "'";
                da = new SqlDataAdapter(str1, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    str = "update UserTbl set password='" + txt_changepass_newpass.Text + "' where mobile=" + txt_changepass_mobile.Text + " and password='" + txt_chnagepass_oldpass.Text + "'";
                    cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();

                    Response.Write("<script>alert('Input Correct Values')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
