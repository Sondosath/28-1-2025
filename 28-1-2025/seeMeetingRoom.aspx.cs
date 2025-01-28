using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _28_1_2025
{
    public partial class seeMeetingRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string file = Server.MapPath("~/App_Data/meetingRoom.txt");
            string[] booksData = File.ReadAllLines(file);

            if (File.Exists(file))
            {
                foreach (string user in booksData)
                {
                    string[] bookData = user.Split(' ');
                    string book = $"<tr><td style=\"border:solid 2px black;\"> {bookData[0]} </td><td style=\"border:solid 2px black;\"> {bookData[1]} </td><td style=\"border:solid 2px black;\"> {bookData[2]} </td><td style=\"border:solid 2px black;\"> {bookData[3]} </td></tr> ";
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
    }
}
