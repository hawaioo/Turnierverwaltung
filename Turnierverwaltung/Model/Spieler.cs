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
        int _anzahlSpiele;


        #endregion

        #region Accessoren/Modifier
        public string Sportart { get => _sportart; set => _sportart = value; }
        public int AnzahlSpiele { get => _anzahlSpiele; set => _anzahlSpiele = value; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Spieler() : base()
        {
            Alter = 18;
            Geschlecht = false;
        }
        // Spezialkonstruktor
        public Spieler(string sa, int anzahlSpiele, string name, int alter, bool geschlecht) : base(name, alter, geschlecht)
        {
            Sportart = sa;
            AnzahlSpiele = anzahlSpiele;
        }
        // Kopierkonstruktor
        public Spieler(Spieler value) : base(value)
        {
            Sportart = value.Sportart;
            AnzahlSpiele = value.AnzahlSpiele;
        }
        #endregion

        #region Workers
        public abstract int compareByErfolg(Spieler s);
        #endregion
    }
}