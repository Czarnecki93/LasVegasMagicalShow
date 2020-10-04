using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LasVegasMagicalShow
{
    public partial class Signup : System.Web.UI.Page
    {
        ArrayList userarray;
        protected void Page_Load(object sender, EventArgs e)
        {
            userarray = new ArrayList();
            TextBox_sp_password.TextMode = TextBoxMode.Password;
        }

        protected void Button_sp_signup_Click(object sender, EventArgs e)
        {
            if (RadioButtonList_usertype.SelectedValue == "Magician")
            {
                Magician m = new Magician(Convert.ToInt32(userarray.Count + 1), TextBox_sp_username.Text, TextBox_sp_password.Text, Convert.ToInt32(RadioButtonList_usertype.SelectedIndex));
                userarray = (ArrayList)Application["myusercollection"];
                userarray.Add(m);
                Response.Redirect("Index.aspx");
            }
            else
            {
                Staff s = new Staff(Convert.ToInt32(userarray.Count + 1), TextBox_sp_username.Text, TextBox_sp_password.Text, Convert.ToInt32(RadioButtonList_usertype.SelectedIndex));
                userarray = (ArrayList)Application["myusercollection"];
                userarray.Add(s);
                Response.Redirect("Index.aspx");
            }
        }
    }
}