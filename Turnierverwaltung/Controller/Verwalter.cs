using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Turnierverwaltung;
using Turnierverwaltung.Model;

namespace Turnierverwaltung
{
    public class Verwalter
    {
        List<Person> _personen;
        public List<Person> Personen { get => _personen; set => _personen = value; }

        public Verwalter()
        {
            Fussballspieler s = new Fussballspieler();

        }

        public void neuePerson(string Rolle)
        {
            switch (Rolle)
            {
                case "Handballspieler":
                    Personen.Add(new Handballspieler());
                    break;
                case "Fussballspieler":
                    break;
                case "Tennisspieler":
                    break;
                case "Trainer":
                    break;
                case "Physiotherapeut":
                    break;
                default:
                    break;
            }
        }

        public void generateTable()
        {
            foreach (Person p in Personen)
            {
                if (p.GetType() == typeof(Handballspieler))
                {

                }

                if (p.GetType() == typeof(Fussballspieler))
                {

                }

                if (p.GetType() == typeof(Tennisspieler))
                {

                }

                if (p.GetType() == typeof(Trainer))
                {

                }

                if (p.GetType() == typeof(Physio))
                {

                }


            }
        }
    }
}