﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LasVegasMagicalShow
{
    public partial class Admin : System.Web.UI.Page
    {
        object user;
        object userlvl;
        ArrayList allusers;
        protected void Page_Load(object sender, EventArgs e)
        {
            allusers = (ArrayList)Application["users"];
            user = Session["currentUser"];
            userlvl = Session["currentLevel"];
            Label_login.Text = "Logged in as: " + user;
            if (userlvl.ToString() == "Magician")
            {
                for (int i = 0; i < allusers.Count; i++)
                {
                    if (allusers[i].GetType().Name == "Magician")
                    {
                        ListBoxUsers.Items.Add(allusers[i].ToString());
                    }
                }
            }
            else
            {
                foreach (var user in allusers)
                {
                    ListBoxUsers.Items.Add(user.ToString());
                }
            }
            
            
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