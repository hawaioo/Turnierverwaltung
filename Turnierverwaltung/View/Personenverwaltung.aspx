<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personenverwaltung.aspx.cs" Inherits="WebManschaftsverwaltung.View.Personenverwaltung" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:Label runat="server" style="font-weight:700; font-size: 2rem">Personenart:</asp:Label>
    <asp:RadioButtonList ID="RadioButtonList6" runat="server" RepeatDirection="Horizontal" CssClass="custom-radio" >
        <asp:ListItem Value="Fussball" style="margin-right: 20px;">Fussballspieler</asp:ListItem>
        <asp:ListItem Value="Tennis" style="margin-right: 20px;">Tennisspieler</asp:ListItem>
        <asp:ListItem Value="Handball" style="margin-right: 20px;">Handballspieler</asp:ListItem>
        <asp:ListItem Value="Trainer" style="margin-right: 20px;">Trainer</asp:ListItem>
        <asp:ListItem Value="Physiotherapeut" style="margin-right: 20px;">Physiotherapeut</asp:ListItem>
    </asp:RadioButtonList>

    <asp:Button ID="Button1" runat="server" OnClick="RolleBestaetigen" Text="Rolle bestätigen" CssClass="btn btn-primary"/>

    <br />
    <br />
    <div runat="server">
        <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server" CssClass="form-control"></asp:TextBox>

        <asp:Label ID="LabelAlter" runat="server" Text="Alter"></asp:Label>
        <asp:TextBox ID="TextBoxAlter" runat="server" CssClass="form-control"></asp:TextBox>

        <asp:Label ID="LabelGeschlecht" runat="server" Text="Geschlecht"></asp:Label>
        <asp:TextBox ID="TextBoxGeschlecht" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <br />
    <br />
    <div runat="server" ID="text_inputs">
        <asp:Label ID="LabelID" runat="server" Text="Spieder-ID:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxID" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>

        <asp:Label ID="LabelSportArt" runat="server" Text="Sportart:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxSportArt" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>      

        <asp:Label ID="LabelPosition" runat="server" Text="Spielposition:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxPosition" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>       

        <asp:Label ID="LabelAnzahlSpiele" runat="server" Text="Anzahl Spiele:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxAnzahlSpiele" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>  

        <asp:Label ID="LabelErfolge" runat="server" Text="Erfolge:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxErfolge" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>

        <asp:Label ID="LabelDauer" runat="server" Text="Beschäftigungsdauer:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxDauer" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>
        
        <asp:Label ID="LabelGeschwindigkeit" runat="server" Text="fAufschlaggeschwindigkeit:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxGeschwindigkeit" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>
             
         <asp:Label ID="LabelGehalt" runat="server" Text="Gehalt:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxGehalt" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>

    </div>
    <br />
    <asp:Button ID="Button2" runat="server" onClick="Anlegen" Text="Person anlegen" Enabled="false" CssClass="btn btn-primary"/>

    <br />
    <br />

    <asp:Table ID="Table1" runat="server" CellPadding="10" GridLines="Both"  Width="100%"  HorizontalAlign="Center" Font-Bold="true">
        <asp:TableRow>
             <asp:TableHeaderCell>
                Rolle
            </asp:TableHeaderCell>

            <asp:TableHeaderCell runat="server" ID="TableName">
                <asp:Button ID="ButtonName" runat="server" onClick="sortName" Text="Name" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TableAlter">
                <asp:Button ID="ButtonAlter" runat="server" onClick="sortAlter" Text="Alter" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TableGeschlecht">
                <asp:Button ID="ButtonGeschlecht" runat="server" onClick="sortGeschlecht" Text="Geschlecht" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TableSportArt">
                Sportart
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TableSpielerID">
                <asp:Button ID="ButtonSpielerID" runat="server" onClick="sortSpielerID" Text="ID" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TablePosition">
                Position
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TableSpeed">
                <asp:Button ID="ButtonSpeed" runat="server" onClick="sortSpeed" Text="Speed" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TableErfolge">
                <asp:Button ID="ButtonErfolge" runat="server" onClick="sortErfolge" Text="Erfolge" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TableGehalt">
                <asp:Button ID="ButtonGehalt" runat="server" onClick="sortGehalt" Text="Gehalt" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TableDauer">
                <asp:Button ID="ButtonDauer" runat="server" onClick="sortDauer" Text="Dauer" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>

        </asp:TableRow>

    </asp:Table>

</asp:Content>