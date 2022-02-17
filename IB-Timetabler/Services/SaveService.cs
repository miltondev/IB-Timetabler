using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    public class SaveService {
        
        private readonly IBTimetablerContext _ibTimetablerContext;

        public SaveService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Save>> GetAllSavesAsync() {
            return await _ibTimetablerContext.Saves.ToListAsync();
        }
        
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Saves.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        public async Task InsertSaveAsync(Save save) {
            await _ibTimetablerContext.Saves.AddAsync(save);
            await _ibTimetablerContext.SaveChangesAsync();
        }

        public async Task UpdateSaveAsync(Save save) {
            _ibTimetablerContext.Saves.Update(save);
            await _ibTimetablerContext.SaveChangesAsync();
        }
        
        public async Task<Save> GetSaveAsync(long id) {
            return await _ibTimetablerContext.Saves.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
        
        public async Task DeleteSaveAsync(Save save) {
            _ibTimetablerContext.Remove(save);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}