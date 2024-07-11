using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AARAATOURS.ADMINMASTER
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string str;

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\Pen\CMC\Colombo Municipal Council\AARAATOURS\App_Data\aaraadata.mdf"";Integrated Security=True";
            con.Open();

            if (!IsPostBack)
            {
                bind_userdata();
            }
        }

        void bind_userdata()
        {
            try
            {
                str = "select * from UserTbl";
                da = new SqlDataAdapter(str, con);
                da.Fill(ds);

                UserGV.DataSource = ds;
                UserGV.DataBind();
            }
            catch
            {

            }
        }

        protected void UserGV_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void UserGV_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            UserGV.EditIndex = e.NewPageIndex;
            bind_userdata();
        }

        protected void UserGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_userdata();
        }
    }
}
