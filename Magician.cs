using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace LasVegasMagicalShow
{
    public class Magician : Person
    {
        // Constructor
        public Magician(int id, string name, string password, int level) : base(id, name, password, level)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.level = level;
        }
        public override string ToString()
        {
            return name + " - " + level;
        }
    }
}