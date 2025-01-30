using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _28_1_2025
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("BookesAdded.txt");

            string[] usersData = File.ReadAllLines(file);

            foreach (string user in usersData)
            {
                string[] userData = user.Split(' ');


                if (userData[0] == searchTextBox.Text )
                {
                    result.Text = $" {user} ";
                    result.Visible = true;
                    return;

                }

            }
        }
    }
}