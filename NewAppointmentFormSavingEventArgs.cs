using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGU_C969.DBItems;

namespace WGU_C969 {
    public class NewAppointmentFormSavingEventArgs : EventArgs {
        private Appointment appointment;
        public Appointment Appointment {
            get { return appointment; }
        }

        public NewAppointmentFormSavingEventArgs(Appointment appointment) {
            this.appointment = appointment;
        }
    }
}
