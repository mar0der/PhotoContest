﻿namespace PhotoContest.App.Jobs
{
    using Quartz;
    using Quartz.Impl;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class JobScheduler
    {
        public static void StartFinilizeContestJob()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<FinilizeContestJob>().Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithDailyTimeIntervalSchedule
                  (s =>
                    s.WithInterval(20, IntervalUnit.Second)
                  )
                .Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}