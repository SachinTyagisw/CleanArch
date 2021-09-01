using System;
using System.Collections.Generic;
using System.Text;
using CleanArc.Domain.Entities;

namespace CleanArch.Application.ViewModel
{
   public class ScheduleViewModel
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}
