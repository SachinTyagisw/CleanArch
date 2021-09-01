using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanArc.Domain.Interfaces;
using CleanArch.Application.Interface;
using CleanArch.Application.ViewModel;

namespace CleanArch.Application.Services
{
    public class ScheduleService : IScheduleService
    {
        private IScheduleRepository _scheduleRepository;

        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        public IEnumerable<ScheduleViewModel> GetSchedules()
        {
            return null; //_scheduleRepository.GetSchedules();
        }

        public ScheduleViewModel GetSchedule()
        {
            var schedules = _scheduleRepository.GetSchedules();
            return new ScheduleViewModel()
            {
                Destination = schedules.First().Destination,
                Id = schedules.First().Id,
                Source = schedules.First().Source
            };
        }
    }
}
