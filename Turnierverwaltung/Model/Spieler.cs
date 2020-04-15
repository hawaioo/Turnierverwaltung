using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Model
{
    public abstract class Spieler : Person
    {
        #region Eigenschaften
        string _sportart;
        int _erfolge;
        #endregion

        #region Accessoren/Modifier
        public string Sportart { get => _sportart; set => _sportart = value; }
        public int Erfolge { get => _erfolge; set => _erfolge = value; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Spieler() : base()
        {
            Alter = 18;
            Geschlecht = false;
            Erfolge = 0;
        }
        // Spezialkonstruktor
        public Spieler(string sa, string name, int alter, bool geschlecht, int erfolge) : base(name, alter, geschlecht)
        {
            Sportart = sa;
            Erfolge = erfolge;
        }
        // Kopierkonstruktor
        public Spieler(Spieler value) : base(value)
        {
            Sportart = value.Sportart;
            Erfolge = value.Erfolge;
        }
        #endregion

        #region Workers
        public int compareByErfolg(Spieler s)
        {
            if (this.Erfolge > s.Erfolge)
            {
                return 1;
            }
            else
            {

            }

            if (this.Erfolge < s.Erfolge)
            {
                return -1;
            }
            else
            {

            }

            return 0;
        }
        #endregion
    }
}