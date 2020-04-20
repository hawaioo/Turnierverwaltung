using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Turnierverwaltung.Model;


namespace Turnierverwaltung
{
    public class Global : HttpApplication
    {
        private static Verwalter _kontroller;
        public static Verwalter Kontroller { get => _kontroller; set => _kontroller = value; }

        void Application_Start(object sender, EventArgs e)
        {
            // Code, der beim Anwendungsstart ausgeführt wird
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Kontroller = new Verwalter();
            //string name, int alter, bool geschlecht, int id, string sportart, string position, int erfolge
            Handballspieler h1 = new Handballspieler("Tom", 18, false, 1, "Handball", "Mittelfeld", 3);
            Handballspieler h2 = new Handballspieler("Dennis", 24, false, 2, "Handball", "Torwart", 8);
            //Fussballspieler f1 = new Fussballspieler("Daniel", 19, true, 3, "Fussball")
            Kontroller.Personen.Add(h1);
            Kontroller.Personen.Add(h2);
        }
    }
}