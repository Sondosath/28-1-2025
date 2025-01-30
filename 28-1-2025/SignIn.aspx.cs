using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;

namespace _28_1_2025
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("register.txt");

            string[] usersData = File.ReadAllLines(file);

            foreach (string user in usersData) 
            {
                string[] userData = user.Split(' ');


                if (userName.Text == "Admin" && password.Text == "123")
                {
                    result.Text = "Wellcom Admin";
                    result.Visible = true;
                    Session["UserEmail"] = "admin@example.com";
                    Response.Redirect("AdminCards.aspx");
                    return;  // breaak

                }

                else if (userName.Text == userData[0] && password.Text == userData[2])
                {
                    result.Text = "login successfully";
                    result.Visible = true;
                    Session["UserEmail"] = userData[1];
                    Response.Redirect("UserCards.aspx");
                    return;  // breaak

                }




            }

            result.Text = "Invalid username or password ";
            result.Visible = true;

        }
    }
    }
