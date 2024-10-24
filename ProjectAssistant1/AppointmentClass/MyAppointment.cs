using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using BlazorScheduler;

namespace ProjectAssistant1.AppointmentClass
{
    public class MyAppointment : Appointment
    {
        public bool IsWorkspaceWork { get; set; }

    }
}
