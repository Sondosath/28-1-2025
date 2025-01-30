using System;
using System.IO;
using System.Web.UI;
using System.Xml.Linq;

namespace SimpleProfile
{
    public partial class edit : Page
    {
        string filePath;

        protected void Page_Load(object sender, EventArgs e)
        {
            filePath = Server.MapPath("register.txt");

            if (!IsPostBack)
            {
                if (Session["UserEmail"] == null)
                {
                    Response.Redirect("SignIn.aspx");
                    return;
                }

                string userEmail = Session["UserEmail"].ToString();
                if (File.Exists(filePath))
                {
                    string[] usersData = File.ReadAllLines(filePath);
                    foreach (string line in usersData)
                    {
                        string[] user = line.Split(',');
                        if (user.Length >= 2 && user[1] == userEmail)
                        {
                            txtName.Text = user[0];
                            txtEmail.Text = user[1];
                            break;
                        }
                    }
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string userEmail = Session["UserEmail"].ToString();
            string[] usersData = File.ReadAllLines(filePath);

            for (int i = 0; i < usersData.Length; i++)
            {
                string[] user = usersData[i].Split(',');
                if (user.Length >= 2 && user[1] == userEmail)
                {
                    usersData[i] = txtName.Text + "," + user[1]; // Update Name
                    File.WriteAllLines(filePath, usersData);
                    Response.Redirect("profile.aspx"); // Go back to profile
                    return;
                }
            }
        }
    }
}
