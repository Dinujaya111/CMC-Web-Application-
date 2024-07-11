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
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kings\Downloads\CMC\CMC\Colombo Municipal Council\AARAATOURS\App_Data\aaraadata.mdf"";Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("Registration.aspx");
            }
            catch
            {

            }
        }

        protected void LinkButton_changepass_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("Changepass.aspx");
            }
            catch
            {

            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (DropDownList_login.SelectedValue.ToString() == "GTF_Members")
                {
                    string str = "select * from GTF_MembersTbl where email=@username and password=@password";
                    cmd = new SqlCommand(str, con);
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Response.Redirect("MainBooking.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Username Or Password')</script>");
                    }

                }

                else if (DropDownList_login.SelectedValue.ToString() == "Green_Captain")
                {
                    string str1 = "select * from Green_CaptainTbl where email=@username and password=@password";
                    cmd = new SqlCommand(str1, con);
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Response.Redirect("MainBooking.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Username Or Password')</script>");
                    }
                }

                else if (DropDownList_login.SelectedValue.ToString() == "Web_Master")
                {
                    string str1 = "select * from Web_MasterTbl where email=@username and password=@password";
                    cmd = new SqlCommand(str1, con);
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Response.Redirect("MainBooking.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Username Or Password')</script>");
                    }
                }

                else
                {
                    Response.Write("<script>alert('Invalid Login Type')</script>");
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
