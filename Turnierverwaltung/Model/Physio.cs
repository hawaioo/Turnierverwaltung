using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Model
{
    class Physio : Person
    {
        #region Eigenschaften
        int _gehalt;
        #endregion

        #region Accessoren/Modifier
        public int Gehalt { get => _gehalt; set => _gehalt = value; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Physio() : base()
        {
            Gehalt = 4000;
        }
        // Spezialkonstruktor
        public Physio(string name, int alter, bool geschlecht, int gehalt) : base(name, alter, geschlecht)
        {
            Gehalt = gehalt;
        }
        // Kopierkonstruktor
        public Physio(Physio value) : base(value)
        {
            Gehalt = value.Gehalt;
        }
        #endregion

        #region Worker
        public void meinGehalt()
        {
            Console.WriteLine(Gehalt);
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