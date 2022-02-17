﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IB_Timetabler.Models;

namespace IB_Timetabler.Services {
    
    public class RoomService {

        private readonly IBTimetablerContext _ibTimetablerContext;

        public RoomService(IBTimetablerContext ibTimetablerContext) {
            _ibTimetablerContext = ibTimetablerContext;
        }

        public async Task<List<Room>> GetAllRoomsAsync() {
            return await _ibTimetablerContext.Rooms.ToListAsync();
        }
        
        public async Task<long> GetNextId() {
            try {
                return await _ibTimetablerContext.Rooms.Select(x => x.Id).OrderBy(x => x).LastAsync() + 1;
            }
            catch (InvalidOperationException) {
                return 1;
            }
        }
        
        public async Task InsertRoomAsync(Room room) {
            await _ibTimetablerContext.Rooms.AddAsync(room);
            await _ibTimetablerContext.SaveChangesAsync();
        }

        public async Task DeleteRoomAsync(Room room) {
            _ibTimetablerContext.Remove(room);
            await _ibTimetablerContext.SaveChangesAsync();
        }
    }
}