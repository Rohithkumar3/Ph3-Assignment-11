using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_11
{
    public partial class Article : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            SqlConnection con = new SqlConnection("server=LAPTOP-CL65602K\\SQLEXPRESS;database=ContentDB;trusted_connection=true;");
            try
            {

                SqlCommand cmd = new SqlCommand("insert into Articles(ArticleId,Title,Content,PublishDate) values(@Articleid,@title,@content,@publishdate) ", con);
                cmd.Parameters.AddWithValue("@Articleid", int.Parse(TxtId.Text));
                cmd.Parameters.AddWithValue("@title", TxtTitle.Text);
                cmd.Parameters.AddWithValue("@content", TxtContent.Text);
                cmd.Parameters.AddWithValue("@publishdate", DateTime.Parse(CalPublishDate.SelectedDate.ToString()));
                con.Open();
                cmd.ExecuteNonQuery();
                LblMsg.Text = "Article Inserted!!!";


            }
            catch (Exception ex)
            {
                LblMsg.Text += "Error!!!" + ex.Message;
            }
            finally { con.Close(); }
        }
    }
}