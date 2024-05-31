using System;

namespace AccessModifiers
{
    public class Customer
    {
        private int _id;
    
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    
}
}
