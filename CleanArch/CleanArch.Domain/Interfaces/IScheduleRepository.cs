using System;
using System.Collections.Generic;
using System.Text;
using CleanArc.Domain.Entities;

namespace CleanArc.Domain.Interfaces
{
    public interface IScheduleRepository
    {
        IEnumerable<Schedule> GetSchedules();
    }
}
