using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Turnierverwaltung;
using Turnierverwaltung.Model;

namespace Turnierverwaltung
{
    public class Verwalter
    {
        List<Mannschaft> _mannschaften;
        List<Person> _personen;

        bool _asc;
        public List<Person> Personen { get => _personen; set => _personen = value; }
        internal List<Mannschaft> Mannschaften { get => _mannschaften; set => _mannschaften = value; }
        public bool Asc { get => _asc; set => _asc = value; }
        string MyConnectionString;

        public void loadData()
        {
            MySqlConnection Conn = new MySqlConnection();
            Conn.ConnectionString = this.MyConnectionString;
            Conn.Open();

            string SQLString = "Select * from personen";
            MySqlCommand cmd = new MySqlCommand(SQLString, Conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                Trainer t = new Trainer();
            }
            rdr.Close();
            Conn.Close();
        }


        public Verwalter()
        {
            Asc = true;
            Personen = new List<Person>();
            Mannschaften = new List<Mannschaft>();
            MyConnectionString = "server=127.0.0.1;database=mannschaftsverwaltung;uid=root;password=''";
        }

        public void neuerFussballSpieler(string name, int alter, bool geschlecht, int id, string sportart, string position, int erfolge)
        {
            //Param order string name, int alter, bool geschlecht, int anzahlSpiele, string position, int id, string sportart, int erfolge) 
            this.Personen.Add(new Fussballspieler(name, alter, geschlecht, position, id, sportart, erfolge));
        }

        public void neuerHandballSpieler(string name, int alter, bool geschlecht, int id, string sportart, string position, int erfolge)
        {
            //Param order string name, int alter, bool geschlecht, int id, string sportart, string position, int erfolge, int anzahlSpiele
            this.Personen.Add(new Handballspieler(name, alter, geschlecht, id, sportart, position, erfolge));
        }

        public void neuerTennisspieler(string name, int alter, bool geschlecht, int id, string sportart, int aufschlaggeschwindigkeit, int erfolge)
        {
            //Param order string name, int alter, bool geschlecht, int id, string sportart, int aufschlagGeschwindigkeit, int erfolge, int anzahlSpiele
            this.Personen.Add(new Tennisspieler(name, alter, geschlecht, id, sportart, aufschlaggeschwindigkeit, erfolge));
        }

        public void neuerTrainer(string name, int alter, bool geschlecht, int dauer)
        {
            this.Personen.Add(new Trainer(name, alter, geschlecht, dauer));
        }

        public void neuerPhysio(string name, int alter, bool geschlecht, int gehalt)
        {
            this.Personen.Add(new Physio(name, alter, geschlecht, gehalt));
        }

        public void neueMannschaft(string name, string sportart)
        {
            List<Person> TempList = new List<Person>();
            this.Mannschaften.Add(new Mannschaft(TempList, sportart, name));
        }

        public void sortName()
        {
            for(int i = 0; i < Personen.Count -1; i++)
            {
                // aufsteigend
                if(Personen[i].compareByName(Personen[i + 1]) == 1)
                {
                    Person temp = Personen[i];
                    Personen[i] = Personen[i + 1];
                    Personen[i + 1] = temp;
                } 
                else
                {
                    //
                }
            }
        }

        public void sortAlter()
        {
            for (int i = 0; i < Personen.Count -1; i++)
            {
                // aufsteigend
                if (Personen[i].compareByAlter(Personen[i + 1]) == 1)
                {
                    Person temp = Personen[i];
                    Personen[i] = Personen[i + 1];
                    Personen[i + 1] = temp;
                }
                else
                {
                    //
                }
            }
        }

        public void sortGeschlecht()
        {
            for (int i = 0; i < Personen.Count -1; i++)
            {
                // aufsteigend
                if (Personen[i].compareByGeschlecht(Personen[i + 1]) == 1)
                {
                    Person temp = Personen[i];
                    Personen[i] = Personen[i + 1];
                    Personen[i + 1] = temp;
                }
                else
                {
                    //
                }
            }
        }

        public void sortErfolge()
        {
            List<Person> tempList = new List<Person>();

            for (int i = 0; i < Personen.Count; i++)
            {
                if(Personen[i] is Spieler)
                {
                    tempList.Add(Personen[i]);
                } else
                {
                    
                }
            }

            for(int i = 0; i < tempList.Count -1; i++)
            {
                if (((Spieler)tempList[i]).compareByErfolg(((Spieler)tempList[i + 1])) == 1)
                {
                    Person temp = tempList[i];
                    tempList[i] = tempList[i + 1];
                    tempList[i + 1] = temp;
                }
            }

            for(int i = 0; i < Personen.Count; i++)
            {
                if(!(Personen[i] is Spieler))
                {
                    tempList.Add(Personen[i]);
                }
                else
                {
                    
                }
            }
            Personen = tempList;
        }

        public void sortGehalt()
        {
            List<Person> tempList = new List<Person>();

            for (int i = 0; i < Personen.Count; i++)
            {
                if (Personen[i] is Physio)
                {
                    tempList.Add(Personen[i]);
                }
                else
                {

                }
            }

            if (tempList.Count < 2)
            {

            }
            else
            {
                for (int i = 0; i < tempList.Count - 1; i++)
                {
                    if (((Physio)tempList[i]).compareByGehalt(((Physio)tempList[i + 1])) == 1)
                    {
                        Person temp = tempList[i];
                        tempList[i] = tempList[i + 1];
                        tempList[i + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < Personen.Count; i++)
            {
                if (!(Personen[i] is Physio))
                {
                    tempList.Add(Personen[i]);
                }
                else
                {

                }
            }
            Personen = tempList;

        }

        public void sortDauer()
        {
            List<Person> tempList = new List<Person>();

            for (int i = 0; i < Personen.Count; i++)
            {
                if (Personen[i] is Trainer)
                {
                    tempList.Add(Personen[i]);
                }
                else
                {

                }
            }

            if (tempList.Count < 2)
            {

            }
            else
            {
                for (int i = 0; i < tempList.Count - 1; i++)
                {
                    if (((Trainer)tempList[i]).compareByDauer(((Trainer)tempList[i + 1])) == 1)
                    {
                        Person temp = tempList[i];
                        tempList[i] = tempList[i + 1];
                        tempList[i + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < Personen.Count; i++)
            {
                if (!(Personen[i] is Trainer))
                {
                    tempList.Add(Personen[i]);
                }
                else
                {

                }
            }
            Personen = tempList;
        }

        public void sortSpeed()
        {
            List<Person> tempList = new List<Person>();

            for (int i = 0; i < Personen.Count; i++)
            {
                if (Personen[i] is Tennisspieler)
                {
                    tempList.Add(Personen[i]);
                }
                else
                {

                }
            }

            if (tempList.Count < 2)
            {

            }
            else
            {
                for (int i = 0; i < tempList.Count - 1; i++)
                {
                    if (((Tennisspieler)tempList[i]).compareBySpeed(((Tennisspieler)tempList[i + 1])) == 1)
                    {
                        Person temp = tempList[i];
                        tempList[i] = tempList[i + 1];
                        tempList[i + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < Personen.Count; i++)
            {
                if (!(Personen[i] is Tennisspieler))
                {
                    tempList.Add(Personen[i]);
                }
                else
                {

                }
            }

            Personen = tempList;
        }

        public void sortSpielerId()
        {
            List<Person> tempList = new List<Person>();

            for (int i = 0; i < Personen.Count; i++)
            {
                if (Personen[i] is Spieler)
                {
                    tempList.Add(Personen[i]);
                }
                else
                {

                }
            }

            for (int i = 0; i < tempList.Count - 1; i++)
            {
                if (((Spieler)tempList[i]).compareBySpielerId(((Spieler)tempList[i + 1])) == 1)
                {
                    Person temp = tempList[i];
                    tempList[i] = tempList[i + 1];
                    tempList[i + 1] = temp;
                }
            }

            for (int i = 0; i < Personen.Count; i++)
            {
                if (!(Personen[i] is Spieler))
                {
                    tempList.Add(Personen[i]);
                }
                else
                {

                }
            }
            Personen = tempList;
        }

        public void generateTable()
        {
            foreach (Person p in Personen)
            {
                if (p.GetType() == typeof(Handballspieler))
                {

                }

                if (p.GetType() == typeof(Fussballspieler))
                {

                }

                if (p.GetType() == typeof(Tennisspieler))
                {

                }

                if (p.GetType() == typeof(Trainer))
                {

                }

                if (p.GetType() == typeof(Physio))
                {

                }


            }
        }
    }
}