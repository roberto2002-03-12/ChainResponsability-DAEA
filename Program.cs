using ChainResponsability.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Handler jorge = new ScrumMaster();
            Handler kevin = new FrontDeveloper();
            Handler emilio = new BackDev();

            //declarar los sucesores
            jorge.SetSuccessor(kevin);
            kevin.SetSuccessor(emilio);

            //crear actividades
            Activity act = new Activity("dev back", "realiza una api", 3);
            jorge.HandleRequest(act);

            act = new Activity("dev front", "realiza el login", 1);
            jorge.HandleRequest(act);

            act = new Activity("organize", "mira quien trabaja bien", 1);
            jorge.HandleRequest(act);

            act = new Activity("meeting", "lanzar a producción", 2);
            jorge.HandleRequest(act);

            Console.ReadKey();

        }
    }
}
