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
        ArrayList localarray;
        protected void Page_Load(object sender, EventArgs e)
        {
            localarray = (ArrayList)Application["users"];
            TextBox_password.TextMode = TextBoxMode.Password;
            // If TextBoxUsername.Text exists in arraylist && password match, login and redirect to Admin.aspx
            // Else display "No user with these credentials found."
            if (localarray != null)
            {
                for (int i = 0; i < localarray.Count; i++)
                {
                    ListBox1.Items.Add(localarray[i].ToString());
                }
            }
            else
            {
                ListBox1.Items.Add("No users");
            }
        }

        protected void Button_signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }

        protected void Button_login_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < localarray.Count; i++)
            {
                if (localarray[i].ToString().Contains(TextBox_username.Text))
                {
                    Response.Redirect("Admin.aspx");
                    break;
                }
            }
        }
    }
}