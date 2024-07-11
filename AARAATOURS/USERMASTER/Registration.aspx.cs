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
    public partial class WebForm7 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string str;
        int id1 = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kings\Downloads\CMC\CMC\Colombo Municipal Council\AARAATOURS\App_Data\aaraadata.mdf"";Integrated Security=True";
            con.Open();

            str = "select max(UserID) as UserID from UserTbl";

            da = new SqlDataAdapter(str, con);
            da.Fill(ds);

            if (ds.Tables[0].Rows[0]["UserID"] != DBNull.Value)
            {
                id1 = int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
                id1++;
            }
            else
            {
                id1 = 1;
            }

            lbl_u_id.Text = id1.ToString();
        }

        protected void LinkButton_login_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("Login.aspx");
            }
            catch
            {

            }
        }

        protected void btn_submit_user_Click(object sender, EventArgs e)
        {
            try
            {
                str = "insert into UserTbl values(@UserID, @UserName, @UserMobile, @UserEmail, @UserPassword)";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@UserID", lbl_u_id.Text);
                cmd.Parameters.AddWithValue("@UserName", txt_user_name.Text);
                cmd.Parameters.AddWithValue("@UserMobile", txt_user_mobile.Text);
                cmd.Parameters.AddWithValue("@UserEmail", txt_user_email.Text);
                cmd.Parameters.AddWithValue("@UserPassword", txt_Confirm_pass.Text);
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Registration Successfully')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("Fill All Details");
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
