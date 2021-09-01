using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.ViewModel;

namespace CleanArch.Application.Interface
{
    public interface IScheduleService
    {
        IEnumerable<ScheduleViewModel> GetSchedules();
    }
}
