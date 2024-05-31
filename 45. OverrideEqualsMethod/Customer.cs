﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEqualsMethod
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals (object obj) 
        {
            if(obj == null) return false;
            if (!(obj is Customer))
            {
                return false;
            }
            return this.FirstName == ((Customer)obj).FirstName &&
                this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
