﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _28_1_2025
{
    public partial class AddBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void AddBook_Click(object sender, EventArgs e)
        //{

        //    string file = Server.MapPath("BooksAdded.txt");
        //    if (!File.Exists(file))
        //    {
        //        using (StreamWriter sw = File.CreateText(file))
        //        {
        //            sw.WriteLine($"{BookId.Text} {BookName.Text} {Kind.Text} {Level.Text} ");
        //        }
        //    }
        //    else
        //    {
        //        using (StreamWriter sw = new StreamWriter(file, true))
        //        {
        //            sw.WriteLine($"{BookId.Text} {BookName.Text} {Kind.Text} {Level.Text} ");
        //        }

        //    }

        //}

        protected void AddBook_Click1(object sender, EventArgs e)
        {
            string file = Server.MapPath("~/App_Data/BookesAdded.txt");
            if (!File.Exists(file))
            {
                using (StreamWriter sw = File.CreateText(file))
                {
                    sw.WriteLine($"{BookId.Text} {BookName.Text} {Kind.Text} {Level.Text} ");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine($"{BookId.Text} {BookName.Text} {Kind.Text} {Level.Text} ");
                }

            }

        }
    }
}