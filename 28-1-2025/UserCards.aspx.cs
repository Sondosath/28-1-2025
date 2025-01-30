using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _28_1_2025
{
    public partial class UserCards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void seeMeetingRoom_Click(object sender, EventArgs e)
        {
            Response.Redirect("seeMeetingRoom.aspx");
        }

        protected void seeBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("Showbooks.aspx");

        }

        protected void profile_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("profile.aspx");
        }
    }
}