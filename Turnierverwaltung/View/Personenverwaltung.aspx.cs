using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Turnierverwaltung;
using Turnierverwaltung.Model;

namespace WebManschaftsverwaltung.View
{
    public partial class Personenverwaltung : System.Web.UI.Page
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

        protected void RolleBestaetigen(object sender, EventArgs e)
        {
            string selectedValue = RadioButtonList6.SelectedValue;
            if (selectedValue != "")
            {
               foreach(Control c in text_inputs.Controls)
                {
                    c.Visible = false;
                }

                switch (selectedValue)
                {
                    case "Handball":
                        LabelID.Visible = true;
                        TextBoxID.Visible = true;
                        LabelSportArt.Visible = true;
                        TextBoxSportArt.Visible = true;
                        TextBoxSportArt.Text = "Handball";
                        TextBoxSportArt.Enabled = false;
                        LabelPosition.Visible = true;
                        TextBoxPosition.Visible = true;
                        LabelErfolge.Visible = true;
                        TextBoxErfolge.Visible = true;
                        break;
                    case "Fussball":
                        LabelID.Visible = true;
                        TextBoxID.Visible = true;
                        LabelSportArt.Visible = true;
                        TextBoxSportArt.Visible = true;
                        TextBoxSportArt.Text = "Fussball";
                        TextBoxSportArt.Enabled = false;
                        LabelPosition.Visible = true;
                        TextBoxPosition.Visible = true;
                        LabelErfolge.Visible = true;
                        TextBoxErfolge.Visible = true;
                        break;
                    case "Tennis":
                        LabelID.Visible = true;
                        TextBoxID.Visible = true;
                        LabelSportArt.Visible = true;
                        TextBoxSportArt.Text = "Tennis";
                        TextBoxSportArt.Enabled = false;
                        TextBoxSportArt.Visible = true;
                        LabelGeschwindigkeit.Visible = true;
                        TextBoxGeschwindigkeit.Visible = true;
                        LabelErfolge.Visible = true;
                        TextBoxErfolge.Visible = true;
                        break;
                    case "Trainer":
                        LabelDauer.Visible = true;
                        TextBoxDauer.Visible = true;
                        break;
                    case "Physiotherapeut":
                        LabelGehalt.Visible = true;
                        TextBoxGehalt.Visible = true;
                        break;
                    default:
                        break;
                }
                Button2.Enabled = true;
            }
            else
            {
                text_inputs.Controls.Add(new Label { Text = "Bitte eine Rolle auswählen!" });
                Button2.Enabled = false;
                return;
            }

        }

        protected void Anlegen(object sender, EventArgs e)
        {
            string selectedValue = RadioButtonList6.SelectedValue;

            int id = 0;
            int alter = 0;
            int erfolge = 0;
            int aufschlaggeschwindigkeit = 0;
            int dauer = 0;
            int gehalt = 0;
            bool geschlecht = false;

            Int32.TryParse(TextBoxAlter.Text, out alter);
            Int32.TryParse(TextBoxID.Text, out id);
            Int32.TryParse(TextBoxErfolge.Text, out erfolge);
            Int32.TryParse(TextBoxGeschwindigkeit.Text, out aufschlaggeschwindigkeit);
            Int32.TryParse(TextBoxDauer.Text, out dauer);
            Int32.TryParse(TextBoxGehalt.Text, out gehalt);

            if (TextBoxGeschlecht.Text[0] == "M"[0] || TextBoxGeschlecht.Text[0] == "m"[0])
            {
                geschlecht = true;
            }

            switch (selectedValue)
            {
                case "Handball":
                    Kontroller.neuerHandballSpieler(TextBoxName.Text, alter, geschlecht, id, "Handball", TextBoxPosition.Text, erfolge);
                    break;
                case "Fussball":
                    Kontroller.neuerHandballSpieler(TextBoxName.Text, alter, geschlecht, id, "Fussball", TextBoxPosition.Text, erfolge);
                    break;
                case "Tennis":
                    Kontroller.neuerTennisspieler(TextBoxName.Text, alter, geschlecht, id, "Tennis", aufschlaggeschwindigkeit, erfolge);
                    break;
                case "Trainer":
                    Kontroller.neuerTrainer(TextBoxName.Text, alter, geschlecht, dauer);
                    break;
                case "Physiotherapeut":
                    Kontroller.neuerPhysio(TextBoxName.Text, alter, geschlecht, gehalt);
                    break;
                default:
                    break;
            }
            Button2.Enabled = false;
            this.BefuelleTabelle();
        }

        protected void sortName(object sender, EventArgs e)
        {
            Kontroller.sortName();
        }

        protected void sortAlter(object sender, EventArgs e)
        {
            Kontroller.sortAlter();
        }

        protected void sortGeschlecht(object sender, EventArgs e)
        {
            Kontroller.sortGeschlecht();
        }

        protected void sortSpielerID(object sender, EventArgs e)
        {
            Kontroller.sortSpielerId();
        }
        protected void sortSpeed(object sender, EventArgs e)
        {
            Kontroller.sortSpeed();
            System.Diagnostics.Debug.WriteLine("This is a log");
        }
        protected void sortErfolge(object sender, EventArgs e)
        {
            Kontroller.sortErfolge();
        }

        protected void sortGehalt(object sender, EventArgs e)
        {
            Kontroller.sortGehalt();
            System.Diagnostics.Debug.WriteLine("This is a log");
        }

        protected void sortDauer(object sender, EventArgs e)
        {
            Kontroller.sortDauer();
            System.Diagnostics.Debug.WriteLine("This is a log");
        }

        private void BefuelleTabelle()
        {
            foreach (Person p in this.Kontroller.Personen)
            {
                TableRow r = new TableRow();
                TableCell c = new TableCell();

                c.Text = p.GetType().Name;
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = p.Name;
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = p.Alter.ToString();
                r.Cells.Add(c);

                string Geschlecht = "weiblich";
                if (p.Geschlecht == true)
                {
                    Geschlecht = "männlich";
                }
                c = new TableCell();
                c.Text = Geschlecht;
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = getSportArt(p);
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = getSpielerID(p);
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = getPosition(p);
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = getAufschlaggeschwindigkeit(p);
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = getErfolge(p);
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = getGehalt(p);
                r.Cells.Add(c);

                c = new TableCell();
                c.Text = getDauer(p);
                r.Cells.Add(c);

                Table1.Rows.Add(r);
            }
        }

        private string getSportArt(Person p)
        {
            if(p is Handballspieler)
            {
                return ((Handballspieler)p).Sportart;
            }
            else if (p is Tennisspieler)
            {
                return ((Tennisspieler)p).Sportart;
            }
            else if (p is Fussballspieler)
            {
                return ((Fussballspieler)p).Sportart;
            }
            else
            {
                return "N/A";
            }
        }

        private string getSpielerID(Person p)
        {
            if(p is Spieler)
            {
                return ((Spieler)p).Id.ToString();
            } 
            else
            {
                return "N/A";
            }
        }

        private string getPosition(Person p)
        {
            if(p is Fussballspieler)
            {
                return ((Fussballspieler)p).Position;
            }
            else
            {
                return "N/A";
            }
        }

        private string getAufschlaggeschwindigkeit(Person p)
        {
            if(p is Tennisspieler)
            {
                return ((Tennisspieler)p).AufschlagGeschwindigkeit.ToString() + " km/h";
            } 
            else
            {
                return "N/A";
            }
        }

        private string getErfolge(Person p)
        {
            if(p is Tennisspieler)
            {
                return ((Tennisspieler)p).Erfolge.ToString();
            } 
            else if(p is Handballspieler)
            {
                return ((Handballspieler)p).Erfolge.ToString();
            }
            else if(p is Fussballspieler)
            {
                return ((Fussballspieler)p).Erfolge.ToString();
            }
            else
            {
                return "N/A";
            }
        }

        private string getGehalt(Person p)
        {
            if (p is Physio)
            {
                return ((Physio)p).Gehalt.ToString() + " €";
            }
            else
            {
                return "N/A";
            }
        }
        private string getDauer(Person p)
        {
            if (p is Trainer)
            {
                return ((Trainer)p).Beschaeftigungsdauer.ToString() + " Jahre";
            }
            else
            {
                return "N/A";
            }
        }
    }
}