using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using BlazorScheduler;

namespace ProjectAssistant1.AppointmentClass
{
    public class MyAppointment
    {
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Color { get; set; }
        public string? Class { get; set; }
        public bool IsWorkspaceWork { get; set; }

    }
}
