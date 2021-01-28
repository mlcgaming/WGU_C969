using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGU_C969.C969Exceptions {
    public class InvalidAppointmentDateTimeException : Exception {
        private string innerMessage;

        public string InnerMessage {
            get { return innerMessage; }
        }

        public InvalidAppointmentDateTimeException(string innerMessage) : base("Invalid Appointment Time Selected") {
            this.innerMessage = innerMessage;
        }
    }
}
