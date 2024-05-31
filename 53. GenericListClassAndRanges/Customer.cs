using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListClassAndRanges
{
    public class Customer:IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
        
        public int CompareTo(Customer other)
        {
            //if (this.Salary > other.Salary) 
            //    return 1;
            //else if(this.Salary < other.Salary) 
            //    return -1;
            //else return 0;
           

            //Or
            //return this.Salary.CompareTo(other.Salary);
            return this.Name.CompareTo(other.Name);
        }

        //or sort function
        public class SortByName:IComparer<Customer>
        {
            public int Compare(Customer x, Customer y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}
