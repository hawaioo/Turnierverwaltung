using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Model
{
    class Tennisspieler : Spieler
    {
        #region Eigenschaften
        private int _aufschlagGeschwindigkeit;
        #endregion

        #region Accessoren/Modifier
        public int AufschlagGeschwindigkeit { get => _aufschlagGeschwindigkeit; set => _aufschlagGeschwindigkeit = value; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Tennisspieler() : base()
        {
            AufschlagGeschwindigkeit = 120;
        }
        // Spezialkonstruktor
        public Tennisspieler(string name, int alter, bool geschlecht, int id, string sportart, int aufschlagGeschwindigkeit, int erfolge) : base(sportart, name, alter, geschlecht, erfolge, id)
        {
            AufschlagGeschwindigkeit = aufschlagGeschwindigkeit;
        }
        // Kopierkonstruktor
        public Tennisspieler(Tennisspieler value) : base(value)
        {
            AufschlagGeschwindigkeit = value.AufschlagGeschwindigkeit;
        }
        #endregion

        #region Worker
        public void getGeschwindigkeit()
        {
            Console.WriteLine(AufschlagGeschwindigkeit);
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
                // mehr geschossen
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

        public int compareBySpeed(Tennisspieler t)
        {
            if (this.AufschlagGeschwindigkeit > t.AufschlagGeschwindigkeit)
            {
                // mehr geschossen
                return 1;
            }
            else
            {

            }

            if (this.AufschlagGeschwindigkeit < t.AufschlagGeschwindigkeit)
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