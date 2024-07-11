using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace AARAATOURS.ADMINMASTER
{
    public partial class WebForm4 : System.Web.UI.Page
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
                bind_feedback();
            }
        }

        void bind_feedback()
        {
            str = "select * from ContactTbl ";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds);

            FeedbackGV.DataSource = ds;
            FeedbackGV.DataBind();
        }

        protected void FeedbackGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_feedback();
        }

        protected void FeedbackGV_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            FeedbackGV.EditIndex = e.NewPageIndex;
            bind_feedback();
        }
    }
}
