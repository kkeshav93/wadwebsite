﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myaccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       NameofAccount.Text = Session["name"].ToString();

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}