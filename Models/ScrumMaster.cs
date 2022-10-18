using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability.Models
{
    public class ScrumMaster : Handler
    {
        public override void HandleRequest(Activity activity)
        {
            if (activity.ActivityType == "organize")
            {
                Console.WriteLine("{0} acepto la actividad {1}", 
                    this.GetType().Name, activity.Description);
            }
            else if (successor != null)
            {
                successor.HandleRequest(activity);
            }
        }
    }
}
