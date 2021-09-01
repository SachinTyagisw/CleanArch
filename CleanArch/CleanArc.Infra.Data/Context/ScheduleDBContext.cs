using System;
using System.Collections.Generic;
using System.Text;
using CleanArc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArc.Infra.Data.Context
{
    public class ScheduleDBContext: DbContext
    {
        public ScheduleDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Schedule> Schedules { get; set; }

    }
}
