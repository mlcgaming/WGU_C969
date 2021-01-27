using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGU_C969.DBItems;

namespace WGU_C969 {
    public class LoginFormUserLoggedInEventArgs {
        private UserAccount user;
        public UserAccount User {
            get { return user; }
        }

        public LoginFormUserLoggedInEventArgs(UserAccount user) {
            this.user = user;
        }
    }
}
