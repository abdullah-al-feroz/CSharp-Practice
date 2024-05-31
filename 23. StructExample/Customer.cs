using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public int Id
        {
            set
            {
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name={0}", this.Id, this.Name);
        }
    }
}
