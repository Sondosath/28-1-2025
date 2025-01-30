using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection.Emit;

namespace _28_1_2025
{
    public partial class Showbooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string file = Server.MapPath("~/App_Data/BookesAdded.txt");
            string[] booksData = File.ReadAllLines(file);

            if (File.Exists(file))
            {
                foreach (string user in booksData)
                {
                    string[] bookData = user.Split(' ');
                    string book = $"<tr><td> {bookData[0]} </td><td> {bookData[1]} </td><td> {bookData[2]} </td><td> {bookData[3]} </td></tr> ";
                    booksTableBody.InnerHtml += book;


                }

            }
            else
            {
                using (StreamWriter sw = File.CreateText(file))
                {

                    foreach (string user in booksData)
                    {
                        string[] bookData = user.Split(' ');
                        string book = $"<tr><td> {bookData[0]} </td><td> {bookData[1]} </td><td> {bookData[2]} </td><td> {bookData[3]} </td></tr> ";
                        booksTableBody.InnerHtml += book;


                    }
                }

            }

           
        }

        protected void searchBox_Click(object sender, EventArgs e)
        {
            Response.Redirect("search.aspx");
        }
    }
}