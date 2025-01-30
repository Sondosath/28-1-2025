using System;
using System.IO;
using System.Web;
using System.Web.UI;

namespace _28_1_2025
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Ensure session variable is set
            if (Session["UserEmail"] == null)
            {
                Response.Redirect("SignIn.aspx"); // Redirect to login page if not logged in
                return;
            }
            Response.Write("<script>alert('Session UserEmail: " + Session["UserEmail"] + "');</script>");


            string userEmail = Session["UserEmail"].ToString();
            string file = Server.MapPath("register.txt");

            if (File.Exists(file))
            {
                string[] usersData = File.ReadAllLines(file);

                foreach (string line in usersData)
                {
                    string[] user = line.Split(' ');
                    if (user.Length >= 2 && user[1] == userEmail) // Ensure valid data
                    {
                        lblName.Text = user[0];  // Set Name
                        lblEmail.Text = user[1]; // Set Email
                        break;
                    }
                }
            }
            else
            {
                lblName.Text = "User Not Found";
                lblEmail.Text = "N/A";
            }
        }

        protected void editProfile_Click(object sender, EventArgs e)
        {


            Response.Redirect("editProfile.aspx");
        }
    }
}
