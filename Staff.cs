﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LasVegasMagicalShow
{
    public class Staff : Person
    {
        protected int salary;

        // Constructor
        public Staff(int id, string name, string password, int level, int salary) : base(id, name, password, level)
        {
            this.salary = salary;
        }

        public Staff(int id, string name, string password, int level) : base(id, name, password, level)
        {
            salary = 2000;
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override string ToString()
        {
            return name + " - Staff";
        }
    }
}