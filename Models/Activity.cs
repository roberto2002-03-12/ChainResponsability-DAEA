using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability.Models
{
    public class Activity
    {
        string activityType;
        string description;
        int days;

        public Activity(string activityType, string description, int days)
        {
            this.activityType = activityType;
            this.description = description;
            this.days = days;
        }

        public string ActivityType
        {
            get { return activityType; }
            set { activityType = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Days
        {
            get { return days; }
            set { days = value; }
        }
    }
}
