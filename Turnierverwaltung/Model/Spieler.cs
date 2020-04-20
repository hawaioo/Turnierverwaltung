using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Model
{
    public abstract class Spieler : Person
    {
        #region Eigenschaften
        int _id;
        string _sportart;
        int _erfolge;
        #endregion

        #region Accessoren/Modifier
        public string Sportart { get => _sportart; set => _sportart = value; }
        public int Erfolge { get => _erfolge; set => _erfolge = value; }
        public int Id { get => _id; set => _id = value; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Spieler() : base()
        {
            Id = 0;
            Alter = 18;
            Geschlecht = false;
            Erfolge = 0;
        }
        // Spezialkonstruktor
        public Spieler(string sa, string name, int alter, bool geschlecht, int erfolge, int id) : base(name, alter, geschlecht)
        {
            Id = id;
            Sportart = sa;
            Erfolge = erfolge;
        }
        // Kopierkonstruktor
        public Spieler(Spieler value) : base(value)
        {
            Id = value.Id;
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

        public int compareBySpielerId(Spieler s)
        {
            return 0;
        }
        #endregion
    }
}