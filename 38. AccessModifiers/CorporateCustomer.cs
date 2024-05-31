using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class CorporateCustomer: Customer
    {
        public void PrintID()
        {
            CorporateCustomer cc = new CorporateCustomer();
            cc.ID = 101;
        }
    }
}
