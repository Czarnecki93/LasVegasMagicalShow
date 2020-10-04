using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LasVegasMagicalShow
{
    public abstract class Person
    {
        // Instance variables
        protected int id;
        protected string name;
        protected string password;

        // Constructor
        protected Person(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }

        // Id properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Name properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Password properties
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}