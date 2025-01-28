using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace _28_1_2025
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Register_Click1(object sender, EventArgs e)
        {
            string file = Server.MapPath("register.txt");
            if (!File.Exists(file))
            {
                using (StreamWriter sw = File.CreateText(file))
                {


                    sw.WriteLine($"{userName.Text} {email.Text} {Password.Text}");


                    // File.Create(file);
                }
            }
            else
            {

                using (StreamWriter sw = new StreamWriter(file, true))
                {

                    sw.WriteLine($"{userName.Text} {email.Text} {Password.Text}");

                }
            }

            Response.Redirect("SignIn.aspx");


        }
    }
}