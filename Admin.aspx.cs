using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LasVegasMagicalShow
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label_login.Text = "Logged in as: " + Session["currentUser"];
            // Be able to edit info. 
            // If magician
            // Be able to edit favorite tricks

            // Be able to see other people. 
            // If level == Magician
            // Only see magicians. / Hide staff.


            // Else level == Staff
            // Be able to see both staff and magicians.
        }
    }
}