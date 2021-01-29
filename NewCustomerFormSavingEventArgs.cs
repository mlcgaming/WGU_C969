using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGU_C969.DBItems;

namespace WGU_C969 {
    public class NewCustomerFormSavingEventArgs : EventArgs {
        private Customer customer;

        public Customer Customer {
            get { return customer; }
        }

        public NewCustomerFormSavingEventArgs(Customer customer) {
            this.customer = customer;
        }
    }
}
