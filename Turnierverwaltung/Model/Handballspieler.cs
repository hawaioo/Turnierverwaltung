using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Model
{
    class Handballspieler : Spieler
    {
        #region Eigenschaften
        private int _id;
        private string _Position;
        int _erfolge;
        #endregion

        #region Accessoren/Modifier
        public int ID { get => _id; set => _id = value; }
        public string Position { get => _Position; set => _Position = value; }
        public int Erfolge { get => _erfolge; set => _erfolge = value; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Handballspieler() : base()
        {
            ID = 1;
            Position = "Torwart";
            Erfolge = 0;
        }
        // Spezialkonstruktor
        public Handballspieler(string name, int alter, bool geschlecht, int id, string sportart, string position, int erfolge, int anzahlSpiele) : base(sportart, anzahlSpiele, name, alter, geschlecht)
        {
            ID = id;
            Position = position;
            Erfolge = erfolge;
        }
        // Kopierkonstruktor
        public Handballspieler(Handballspieler value) : base(value)
        {
            ID = value.ID;
            Position = value.Position;
            Erfolge = value.Erfolge;
        }
        #endregion

        #region Worker
        public void meineID()
        {
            Console.WriteLine(ID);
        }

        public override int compareByErfolg(Spieler s)
        {
            Handballspieler t = (Handballspieler)s;

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