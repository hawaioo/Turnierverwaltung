using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Turnierverwaltung;

namespace WebManschaftsverwaltung.View
{
    public partial class Personenverwaltung : System.Web.UI.Page
    {
       private Verwalter _kontroller;

        public Verwalter Kontroller { get => _kontroller; set => _kontroller = value; }

        protected void Page_Init(object sender, EventArgs e)
        {
            Kontroller = Global.Kontroller;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RolleBestaetigen(object sender, EventArgs e)
        {
            string selectedValue = RadioButtonList6.SelectedValue;
            if (selectedValue != "")
            {
                Label LabelID = new Label
                {
                    Text = "Spieler-ID: "
                };

                TextBox textBoxID = new TextBox
                {
                    ID = "TextBoxID",
                };
                textBoxID.Attributes.Add("runat", "server");

                Label LabelSportArt = new Label
                {
                    Text = "Sportart: "
                };

                TextBox textBoxSportArt = new TextBox
                {
                    ID = "TextBoxSportArt",
                };

                textBoxSportArt.Attributes.Add("runat", "server");

                Label LabelPosition = new Label
                {
                    Text = "Position: "
                };

                TextBox textBoxPosition = new TextBox
                {
                    ID = "TextBoxPosition",
                };
                textBoxPosition.Attributes.Add("runat", "server");

                Label LabelErfolge = new Label
                {
                    Text = "Erfolge:  ",
                };

                TextBox textBoxErfolge = new TextBox
                {
                    ID = "TextBoxErfolge",
                };

                textBoxErfolge.Attributes.Add("runat", "server");

                Label LabelDauer = new Label
                {
                    Text = "Beschäftigungsdauer:  ",
                };

                TextBox textBoxDauer = new TextBox
                {
                    ID = "TextBoxDauer",
                };

                textBoxDauer.Attributes.Add("runat", "server");


                Label LabelGeschwindigkeit = new Label
                {
                    Text = "Aufschlaggeschwindigkeit",
                };


                TextBox textBoxGeschwindigkeit = new TextBox
                {
                    ID = "TextBoxGeschwindigkeit",
                };

                textBoxGeschwindigkeit.Attributes.Add("runat", "server");


                Label LabelGehalt = new Label
                {
                    Text = "Gehalt",
                };


                TextBox textBoxGehalt = new TextBox
                {
                    ID = "TextBoxGehallt",
                };

                textBoxGehalt.Attributes.Add("runat", "server");

                switch (selectedValue)
                {

                    case "Handballspieler":
                        text_inputs.Controls.Add(LabelID);
                        text_inputs.Controls.Add(textBoxID);
                        text_inputs.Controls.Add(LabelSportArt);
                        text_inputs.Controls.Add(textBoxSportArt);
                        text_inputs.Controls.Add(LabelPosition);
                        text_inputs.Controls.Add(textBoxPosition);
                        text_inputs.Controls.Add(LabelErfolge);
                        text_inputs.Controls.Add(textBoxErfolge);
                        break;
                    case "Fussballspieler":
                        text_inputs.Controls.Add(LabelID);
                        text_inputs.Controls.Add(textBoxID);
                        text_inputs.Controls.Add(LabelSportArt);
                        text_inputs.Controls.Add(textBoxSportArt);
                        text_inputs.Controls.Add(LabelPosition);
                        text_inputs.Controls.Add(textBoxPosition);
                        text_inputs.Controls.Add(LabelErfolge);
                        text_inputs.Controls.Add(textBoxErfolge);
                        break;
                    case "Tennisspieler":
                        text_inputs.Controls.Add(LabelID);
                        text_inputs.Controls.Add(textBoxID);
                        text_inputs.Controls.Add(LabelSportArt);
                        text_inputs.Controls.Add(textBoxSportArt);
                        text_inputs.Controls.Add(LabelGeschwindigkeit);
                        text_inputs.Controls.Add(textBoxGeschwindigkeit);
                        text_inputs.Controls.Add(LabelErfolge);
                        text_inputs.Controls.Add(textBoxErfolge);
                        break;
                    case "Trainer":
                        text_inputs.Controls.Add(LabelDauer);
                        text_inputs.Controls.Add(textBoxDauer);
                        break;
                    case "Physiotherapeut":
                        text_inputs.Controls.Add(LabelGehalt);
                        text_inputs.Controls.Add(textBoxGehalt);
                        break;
                    default:
                        break;
                }
                Button2.Enabled = true;
            }
            else
            {
                text_inputs.Controls.Add(new Label { Text = "Bitte eine Rolle auswählen!" });
                return;
            }

        }

        protected void Anlegen(object sender, EventArgs e)
        {
            foreach (char input in text_inputs.Controls)
            {
                System.Diagnostics.Debug.WriteLine(input);
            }
            


            string selectedValue = RadioButtonList6.SelectedValue;
          
            Kontroller.neuePerson(selectedValue);
        }
    }
}