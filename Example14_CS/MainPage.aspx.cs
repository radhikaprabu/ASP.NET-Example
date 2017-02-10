using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Diagnostics;

namespace Example14_CS
{
    public partial class MainPage : System.Web.UI.Page
    {
        //***** Procedure: Page_Load()
        protected void Page_Load(object sender, EventArgs e)
        {
            //** Check login validation SESSION variable or cookie
            if (Session.Contents["AppLoggedIn"] == null)
            {
                Response.Redirect("./Login.aspx");
            }

            if (!IsPostBack)
            {
                lblError.Text = "";
            }
        }

        //***** Procedure: btnSubmit()
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblError.Text = "You clicked SUBMIT";
        }
    }
}