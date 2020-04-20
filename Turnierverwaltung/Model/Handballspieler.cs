using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Model
{
    class Handballspieler : Spieler
    {
        #region Eigenschaften
        private string _Position;
        #endregion

        #region Accessoren/Modifier
        public string Position { get => _Position; set => _Position = value; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Handballspieler() : base()
        {
            Position = "Torwart";
        }
        // Spezialkonstruktor
        public Handballspieler(string name, int alter, bool geschlecht, int id, string sportart, string position, int erfolge) : base(sportart, name, alter, geschlecht, erfolge, id)
        {
            Position = position;
        }
        // Kopierkonstruktor
        public Handballspieler(Handballspieler value) : base(value)
        {
            Position = value.Position;
        }
        #endregion

        #region Worker
        public void meinePosition()
        {
            Console.WriteLine(Position);
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

        public override int compareByAlter(Person p)
        {

            if (this.Alter > p.Alter)
            {
                return 1;
            }
            else
            {

            }

            if (this.Alter < p.Alter)
            {
                return -1;
            }
            else
            {

            }

            return 0;
        }

        public override int compareByGeschlecht(Person p)
        {

            if (this.Geschlecht == true && p.Geschlecht != true)
            {
                return 1;
            }
            else
            {

            }

            if (this.Geschlecht != true && p.Geschlecht == true)
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