using ProjectAssistant1.Models.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.PersonalScheduleModel
{
    public class PersonalSchedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public bool IsSuccess { get; set; }
        public string TaskDetails { get; set; }
        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public string UserId { get; set; }
        public bool IsDeleted { get; set; }

        // Navigation property for the ChatRoom foreign key
        virtual public User User { get; set; }


        public PersonalSchedule()
        {
        }

        public PersonalSchedule(string name, DateTimeOffset? startDate, DateTimeOffset? endDate, string taskDetail)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            TaskDetails = taskDetail;
            IsSuccess = false;
            IsDeleted = false;
        }
    }

}
