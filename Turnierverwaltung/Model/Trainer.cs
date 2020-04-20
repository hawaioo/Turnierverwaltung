using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Model
{
    class Trainer : Person
    {
        #region Eigenschaften
        private int _beschaeftigungsdauer;
        #endregion

        #region Accessoren/Modifier
        public int Beschaeftigungsdauer { get => _beschaeftigungsdauer; set => _beschaeftigungsdauer = value; }
        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Trainer() : base()
        {
            Beschaeftigungsdauer = 1;
        }
        // Spezialkonstruktor
        public Trainer(string name, int alter, bool geschlecht, int dauer) : base(name, alter, geschlecht)
        {
            Beschaeftigungsdauer = dauer;
        }
        // Kopierkonstruktor
        public Trainer(Trainer value) : base(value)
        {
            Beschaeftigungsdauer = value.Beschaeftigungsdauer;
        }
        #endregion

        #region Worker
        public void meineBeschaeftigungsdauer()
        {
            Console.WriteLine(Beschaeftigungsdauer);
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

        public int compareByDauer(Trainer t)
        {

            if (this.Beschaeftigungsdauer > t.Beschaeftigungsdauer)
            {
                return 1;
            }
            else
            {

            }

            if (this.Beschaeftigungsdauer > t.Beschaeftigungsdauer)
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