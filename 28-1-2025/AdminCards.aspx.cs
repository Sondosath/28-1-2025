using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _28_1_2025
{
    public partial class AdminCards : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void AddRoom_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("AddRoom.aspx");

        //}

        protected void AddBooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBooks.aspx");
        }

        protected void Showbooks_Click(object sender, EventArgs e)
        {
            Response.Redirect("Showbooks.aspx");

        }
    }
}