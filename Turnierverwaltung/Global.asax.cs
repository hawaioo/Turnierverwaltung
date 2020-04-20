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
            Handballspieler h1 = new Handballspieler("Tom", 18, true, 1, "Handball", "Mittelfeld", 3);
            Handballspieler h2 = new Handballspieler("Hanna", 24, false, 2, "Handball", "Torwart", 8);

            // fussballspieler param string name, int alter, bool geschlecht, string position, int id, string sportart, int erfolge
            Fussballspieler f1 = new Fussballspieler("Daniel", 19, true, "Stürmer", 3, "Fussball", 5);
            Fussballspieler f2 = new Fussballspieler("Daniel", 27, true, "Verteidiger", 4, "Fussball", 10);

            Tennisspieler t1 = new Tennisspieler("Lara", 22, false, 5, "Tennis", 120, 8);

            Trainer tr1 = new Trainer("Klaus", 40, true, 4);
            Physio p1 = new Physio("Janna", 56, false, 4250);

            Kontroller.Personen.Add(h1);
            Kontroller.Personen.Add(h2);
            Kontroller.Personen.Add(f1);
            Kontroller.Personen.Add(f2);
            Kontroller.Personen.Add(t1);
            Kontroller.Personen.Add(tr1);
            Kontroller.Personen.Add(p1);

            List<Person> tempLIst = new List<Person>
            {
                f1,
                f2
            };

            Mannschaft m1 = new Mannschaft(tempLIst, "Fussball", "FC Eitorf");
            Mannschaft m2 = new Mannschaft();

            Kontroller.Mannschaften.Add(m1);
            Kontroller.Mannschaften.Add(m2);
        }
    }
}