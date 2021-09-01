using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Domain.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}
