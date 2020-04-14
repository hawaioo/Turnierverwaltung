<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personenverwaltung.aspx.cs" Inherits="WebManschaftsverwaltung.View.Personenverwaltung" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:RadioButtonList ID="RadioButtonList6" runat="server">
        <asp:ListItem Value="Fussballspieler">Fussballspieler</asp:ListItem>
        <asp:ListItem Value="Tennisspieler">Tennisspieler</asp:ListItem>
        <asp:ListItem Value="Handballspieler">Handballspieler</asp:ListItem>
        <asp:ListItem Value="Trainer">Trainer</asp:ListItem>
        <asp:ListItem Value="Physiotherapeut">Physiotherapeut</asp:ListItem>
    </asp:RadioButtonList>

    <asp:Button ID="Button1" runat="server" OnClick="RolleBestaetigen" Text="Rolle bestätigen" />

    <br />
    <br />
    <div runat="server" ID="text_inputs">
         <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>

        <asp:Label ID="LabelAlter" runat="server" Text="Alter"></asp:Label>
        <asp:TextBox ID="TextBoxAlter" runat="server"></asp:TextBox>

        <asp:Label ID="LabelGeschlecht" runat="server" Text="Geschlecht"></asp:Label>
        <asp:TextBox ID="TextBoxGeschlecht" runat="server"></asp:TextBox>

        <br />
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </div>
    <br />
    <asp:Button ID="Button2" runat="server" onClick="Anlegen" Text="Person anlegen" Enabled="false"/>

    <br />
    <br />

    <asp:Table ID="Table1" runat="server" CellPadding="10" GridLines="Both"  Width="100%"  HorizontalAlign="Center" Font-Bold="true">
        <asp:TableRow>
            <asp:TableHeaderCell>
                Name
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                Alter
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                Geschlecht
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                Sportart
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                ID
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                Position
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                Aufschlaggeschwindigkeit
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                Erfolge
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                Gehalt
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                Beschäftigungsdauer
            </asp:TableHeaderCell>

        </asp:TableRow>

    </asp:Table>

</asp:Content>