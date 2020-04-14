using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Model
{
    class Mannschaft
    {
        #region Eigenschaften
        List<Person> _personen;
        string _sportart;
        #endregion

        #region Accessoren/Modifier
        public List<Person> Personen { get => _personen; set => _personen = value; }
        public string Sportart { get => _sportart; set => _sportart = value; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Mannschaft()
        {
            Personen = null;
            Sportart = "unbekannt";
        }
        // Spezialkonstruktor
        public Mannschaft(List<Person> personen, string sportart)
        {
            Personen = personen;
            Sportart = sportart;
        }
        // Kopierkonstruktor
        public Mannschaft(Mannschaft value)
        {
            Personen = value.Personen;
            Sportart = value.Sportart;
        }
        #endregion

        #region Worker
        public int MitgliederAnzahl()
        {
            return Personen.Count();
        }

        public void neuesMitglied(Person p)
        {
           Personen.Add(p);
        }
            #endregion
        }
}