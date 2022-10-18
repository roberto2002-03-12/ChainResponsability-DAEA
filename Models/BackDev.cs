using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability.Models
{
    public class BackDev : Handler
    {
        public override void HandleRequest(Activity activity)
        {
            if (activity.ActivityType == "dev back")
            {
                Console.WriteLine("{0} acepto la actividad {1}",
                    this.GetType().Name, activity.Description);
            }
            else 
            {
                Console.WriteLine("esta actividad necesita reunión de trabajadores");
            }
        }
    }
}
