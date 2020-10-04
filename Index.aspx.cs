using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LasVegasMagicalShow
{
    public partial class Index : System.Web.UI.Page
    {
        ArrayList userarray;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox_password.TextMode = TextBoxMode.Password;
            // If TextBoxUsername.Text exists in arraylist && password match, login and redirect to Admin.aspx
            // Else display "No user with these credentials found."
            if (Application["myusercollection"] == null)
            {
                userarray = new ArrayList();
                Application["myusercollection"] = userarray;
            }
            userarray = (ArrayList)Application["myusercollection"];

        }

        protected void Button_signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }

        protected void Button_login_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < userarray.Count; i++)
            {
                if (userarray[i].ToString() == (TextBox_username.Text))
                {
                    Response.Redirect("Admin.aspx");
                }
            }
        }
    }
}