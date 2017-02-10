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
    public partial class Login : System.Web.UI.Page
    {
        //***** Procedure: Page_Load()
        protected void Page_Load(object sender, EventArgs e)
        {
            String strURL;

            //***** Verify SSL is being used, if SSL is required for the site. If required and SSL not used, redirect
            if (!Request.IsSecureConnection)
            {
                strURL = Request.Url.ToString().Replace("http:", "https:");

                //** This line is used only for IIS express in Visual Studio. From Solution Properties. Remove after testing.
                //** THIS MUST BE CHECKED WHEN SOLUTION IS OPENED TO GET CORRECT IIS EXPRESS PORTS
                strURL = strURL.Replace("48620", "44301");

                Response.Redirect(strURL);
            }

            if (!IsPostBack)
            {
                lblError.Text = "";
            }
        }

        //***** Procedure: btnSubmit()
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (txtUser.Text.Trim().Length < 1)
            {
                lblError.Text = "Please enter a username!";
            }
            else if (txtPassword.Text.Trim().Length < 1)
            {
                lblError.Text = "Please enter a password!";
            }
            else if (txtUser.Text.Trim().ToUpper() != "CCIS2645")
            {
                lblError.Text = "Invalid username / password!";
            }
            else if (txtPassword.Text.Trim() != "ASP.Net")
            {
                lblError.Text = "Invalid username / password!";
            }
            else
            {
                Session.Contents["AppLoggedIn"] = "YES";
                Response.Redirect("./MainPage.aspx");
            }
        }
    }
}