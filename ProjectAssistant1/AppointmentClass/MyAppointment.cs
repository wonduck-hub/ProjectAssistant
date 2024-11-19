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
        public int ScheduleId { get; set; }
        public string ScheduleDetail { get; set; }
        public DateTimeOffset? Start { get; set; }
        public DateTimeOffset? End { get; set; }
        public string Color { get; set; }
        public string? Class { get; set; }
        public bool IsWorkspaceWork { get; set; }

    }
}
