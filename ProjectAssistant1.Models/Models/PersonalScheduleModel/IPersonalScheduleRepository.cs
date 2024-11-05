using ProjectAssistant1.Models.Models.ChatModel;
using ProjectAssistant1.Models.Models.ChatRoomModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.PersonalScheduleModel
{
    public interface IPersonalScheduleRepository
    {
        Task<PersonalSchedule> AddPersonalScheduleAsync(PersonalSchedule s, string userId);
        Task<List<PersonalSchedule>> GetPersonalSchedulesAsync();
        Task<PersonalSchedule> GetPersonalScheduleByIdAsync(int id);
        Task<List<PersonalSchedule>> GetPersonalScheduleByUserId(string userId);
        Task<PersonalSchedule> UpdatePersonalScheduleAsync(PersonalSchedule s);
        Task DeletePersonalScheduleById(int id);
    }
}
