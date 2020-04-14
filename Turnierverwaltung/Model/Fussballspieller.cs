using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Model
{
    class Fussballspieler : Spieler
    {
        #region Eigenschaften
        private int _fussballspielerId;
        int _erfolge;
        string _position;

        #endregion

        #region Accessoren/Modifier
        public int FussballspielerId { get => _fussballspielerId; set => _fussballspielerId = value; }

        public int Erfolge { get => _erfolge; set => _erfolge = value; }
        public string Position { get => _position; set => _position = value; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Fussballspieler() : base()
        {
            FussballspielerId = 1;
            Erfolge = 0;
            Position = "Torwart";
        }
        // Spezialkonstruktor
        public Fussballspieler(string name, int alter, bool geschlecht, int anzahlSpiele, string position, int id, string sportart, int erfolge) : base(sportart, anzahlSpiele, name, alter, geschlecht)
        {
            FussballspielerId = id;
            Erfolge = erfolge;
            Position = position;
        }
        // Kopierkonstruktor
        public Fussballspieler(Fussballspieler value) : base(value)
        {
            FussballspielerId = value.FussballspielerId;
            Erfolge = value.Erfolge;
            Position = value.Position;
        }
        #endregion

        #region Worker
        public void meineID()
        {
            Console.WriteLine(FussballspielerId);
        }

        public override int compareByErfolg(Spieler s)
        {
            Fussballspieler t = (Fussballspieler)s;

            if (this.Erfolge > t.Erfolge)
            {
                // mehr geschossen
                return 1;
            }
            else
            {

            }

            if (this.Erfolge < t.Erfolge)
            {
                return -1;
            }
            else
            {

            }

            return 0;
            throw new NotImplementedException();
        }

        public override int compareByName(Person t)
        {
            char[] charArr = Name.ToCharArray();
            char[] charArr2 = t.Name.ToCharArray();
            int a = char.ToUpper(charArr[0]);
            int b = char.ToUpper(charArr2[0]);

            if (a > b)
            {
                return 1;
            }
            if (a < b)
            {
                return -1;
            }
            return 0;

            throw new NotImplementedException();
        }

        #endregion
    }
}