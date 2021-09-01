using System;
using System.Collections.Generic;
using System.Text;
using CleanArc.Domain.Entities;
using CleanArc.Domain.Interfaces;
using CleanArc.Infra.Data.Context;

namespace CleanArc.Infra.Data.Repository
{
    public class ScheduleRepository : IScheduleRepository
    {
        private ScheduleDBContext _ctx;

        public ScheduleRepository(ScheduleDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Schedule> GetSchedules()
        {
            return _ctx.Schedules;
        }
    }
}
