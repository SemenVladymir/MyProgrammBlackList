using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgrammBlackList.Models
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Duration { get; set; }
        public int? UserId { get; set; }
        public int? TimeOfWork { get; set; }
        public DateTime? Today { get; set; }
        public int? TimeLastSeans { get; set; }
        public App()
        {
            Id = 0;
            Name = string.Empty;
            StartTime = DateTime.MinValue;
            EndTime = DateTime.MinValue;
            Duration = 0;
            UserId = 0;
            TimeOfWork = 0;
            Today = DateTime.Now.Date;
            TimeLastSeans = 0;
        }

        public App(int id, string name, DateTime? startTime, DateTime? endTime, int? duration, int? userId, int? timeOfWork, DateTime today, int? lastTime)
        {
            Id = id;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
            UserId = userId;
            TimeOfWork = timeOfWork;
            Today = today;
            TimeLastSeans = lastTime;
        }

        //public override string ToString()
        //{
        //    return $"App name - {Name}, startTime - {StartTime}, duration - {Duration}min";
        //}
    }
}
