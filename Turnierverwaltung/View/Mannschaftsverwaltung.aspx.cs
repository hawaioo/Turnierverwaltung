using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Turnierverwaltung.Model;
using Turnierverwaltung;

namespace WebManschaftsverwaltung.View
{
    public partial class Mannschaftsverwaltung : System.Web.UI.Page
    {
        private Verwalter _kontroller;

        public Verwalter Kontroller { get => _kontroller; set => _kontroller = value; }

        protected void Page_Init(object sender, EventArgs e)
        {
            Kontroller = Global.Kontroller;
            BefuelleTabelle();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        public void MErstellen(object sender, EventArgs e)
        {
            string selectedValue = RadioButtonList7.SelectedValue;

            if(selectedValue != "")
            {
                switch (selectedValue)
                {
                    case "Handball":
                        LabelName.Visible = true;
                        TextBoxName.Visible = true;
                        LabelSportArt.Visible = true;
                        TextBoxSportArt.Visible = true;
                        TextBoxSportArt.Text = "Handball";

                        break;
                    case "Fussball":
                        LabelName.Visible = true;
                        TextBoxName.Visible = true;
                        LabelSportArt.Visible = true;
                        TextBoxSportArt.Visible = true;
                        TextBoxSportArt.Text = "Fussball";
                        break;
                    case "Tennis":
                        LabelName.Visible = true;
                        TextBoxName.Visible = true;
                        LabelSportArt.Visible = true;
                        TextBoxSportArt.Visible = true;
                        TextBoxSportArt.Text = "Tennis";
                        break;
                    default:

                        break;
                }
                ButtonAnlegen.Enabled = true;
            }
            else
            {
                text_inputs2.Controls.Add(new Label { Text = "Bitte eine Sportart auswählen!" });
                ButtonAnlegen.Enabled = false;
            }
        }

        public void MAnlegen(object sender, EventArgs e)
        {
            Kontroller.neueMannschaft(TextBoxName.Text, TextBoxSportArt.Text);
        }

        public void sortMName(object sender, EventArgs e)
        {
            if(Kontroller.Asc == true)
            {
                Kontroller.Mannschaften.Sort(delegate (Mannschaft m, Mannschaft n) {
                    return m.Name.CompareTo(n.Name);
                });
                Kontroller.Asc = !Kontroller.Asc;
            }
            else
            {
                Kontroller.Mannschaften.Sort(delegate (Mannschaft m, Mannschaft n) {
                    return n.Name.CompareTo(m.Name);
                });
                Kontroller.Asc = !Kontroller.Asc;
            }
        }

        public void sortMSportart(object sender, EventArgs e)
        {
            if (Kontroller.Asc == true)
            {
                Kontroller.Mannschaften.Sort(delegate (Mannschaft m, Mannschaft n) {
                    
                    return m.Sportart.CompareTo(n.Sportart);
                });
                Kontroller.Asc = !Kontroller.Asc;
            }
            else
            {
                Kontroller.Mannschaften.Sort(delegate (Mannschaft m, Mannschaft n) {
                    return n.Sportart.CompareTo(m.Sportart);
                });
                Kontroller.Asc = !Kontroller.Asc;
            }
        }

        public void sortAnzahlMitglieder(object sender, EventArgs e)
        {
            if (Kontroller.Asc == true)
            {
                Kontroller.Mannschaften.Sort(delegate (Mannschaft m, Mannschaft n) {

                    return m.Personen.Count.CompareTo(n.Personen.Count);
                });
                Kontroller.Asc = !Kontroller.Asc;
            }
            else
            {
                Kontroller.Mannschaften.Sort(delegate (Mannschaft m, Mannschaft n) {
                    return n.Personen.Count.CompareTo(m.Personen.Count);
                });
                Kontroller.Asc = !Kontroller.Asc;
            }
        }

        public void addMitglied(object s, EventArgs e)
        {

        }

        private void BefuelleTabelle()
        {
            foreach(Mannschaft m in Kontroller.Mannschaften)
            {
                TableRow r = new TableRow();

                TableCell c = new TableCell();
                c.Text = m.Name;
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = m.Sportart;
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = m.Personen.Count.ToString();
                r.Cells.Add(c);


                DropDownList ddl = GenerierePersonenListe(m);
                c = new TableCell();
                c.Controls.Add(ddl);
                r.Cells.Add(c);

                TableMannschaft.Rows.Add(r);
            }
           
        }

        private DropDownList GenerierePersonenListe(Mannschaft m)
        {
            DropDownList ddl = new DropDownList();
            ddl.ID = "ddlID";
            switch(m.Sportart)
            {
                case "Handball":
                    foreach(Person p in Kontroller.Personen)
                    {
                        if (!(p is Fussballspieler) && !(p is Tennisspieler))
                        {
                           ddl.Items.Add(new ListItem($"{p.Name}, {p.Alter}, {p.GetType()}", $"{p}"));
                        }
                    }
                    break;
                case "Fussball":
                    foreach (Person p in Kontroller.Personen)
                    {
                        if (!(p is Handballspieler) && !(p is Tennisspieler))
                        {
                            ddl.Items.Add(new ListItem($"{p.Name}, {p.Alter}, {p.GetType()}", $"{p}"));
                        }
                    }
                    break;
                case "Tennis":
                    foreach (Person p in Kontroller.Personen)
                    {
                        if (!(p is Handballspieler) && !(p is Fussballspieler))
                        {
                            ddl.Items.Add(new ListItem($"{p.Name}, {p.Alter}, {p.GetType().Name}", $"{p}"));
                        }
                    }
                    break;
                default:
                    break;
            }
            return ddl;
        }
    }
}