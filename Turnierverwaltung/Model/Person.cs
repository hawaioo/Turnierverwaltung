using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Model
{
    public abstract class Person
    {
        #region Eigenschaften
        string _name;
        int _alter;
        bool _geschlecht;

        #endregion

        #region Accessoren/Modifier
        public string Name { get => _name; set => _name = value; }
        public int Alter { get => _alter; set => _alter = value; }
        public bool Geschlecht { get => _geschlecht; set => _geschlecht = value; }

        #endregion

        #region Konstruktoren
        // Standardkonstruktor
        public Person()
        {
            Name = "Name";
            Alter = 18;
            Geschlecht = false;
        }
        // Spezialkonstruktor
        public Person(string Name, int Alter, bool Geschlecht)
        {
            this.Name = Name;
            this.Alter = Alter;
            this.Geschlecht = Geschlecht;
        }
        // Kopierkonstruktor
        public Person(Person value)
        {
            Name = value.Name;
            Alter = value.Alter;
            Geschlecht = value.Geschlecht;
        }

        #endregion

        #region Workers
        public abstract int compareByName(Person p);

        public abstract int compareByAlter(Person p);

        public abstract int compareByGeschlecht(Person p);
        #endregion
    }
}