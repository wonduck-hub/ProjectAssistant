using Microsoft.EntityFrameworkCore;
using ProjectAssistant1.Models.Models.ChatRoomModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssistant1.Models.Models.PersonalScheduleModel
{
    public class PersonalScheduleRepository : IPersonalScheduleRepository
    {
        private readonly ProjectAssistantDbContext _context;

        public PersonalScheduleRepository(ProjectAssistantDbContext context)
        {
            this._context = context;
        }
        public async Task<PersonalSchedule> AddPersonalScheduleAsync(PersonalSchedule s, string userId)
        {
            Debug.Assert(s != null, "PersonalSchedule is null");
            this._context.PersonalSchedules.Add(s);
            s.User = await _context.AspNetUsers.FirstOrDefaultAsync(u => u.Id == userId);
            await _context.SaveChangesAsync();

            return s;
        }

        public Task DeletePersonalScheduleById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PersonalSchedule>> GetPersonalScheduleByUserId(string userId)
        {
            Debug.Assert(userId != null, "Workspace id is null");

            return await _context.PersonalSchedules.Where(w => w.UserId == userId).ToListAsync();
        }

        public Task<PersonalSchedule> GetPersonalScheduleByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonalSchedule>> GetPersonalSchedulesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PersonalSchedule> UpdatePersonalScheduleAsync(PersonalSchedule s)
        {
            throw new NotImplementedException();
        }
    }
}
