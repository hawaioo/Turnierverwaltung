<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mannschaftsverwaltung.aspx.cs" Inherits="WebManschaftsverwaltung.View.Mannschaftsverwaltung" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:RadioButtonList ID="RadioButtonList7" runat="server">
        <asp:ListItem Value="Fussball">Fussball</asp:ListItem>
        <asp:ListItem Value="Tennis">Tennis</asp:ListItem>
        <asp:ListItem Value="Handball">Handball</asp:ListItem>
    </asp:RadioButtonList>

     <asp:Button ID="ButtonErstellen" runat="server" OnClick="MErstellen" Text="Mannschaftsart auswählen" />

    <div runat="server" ID="text_inputs2">
        <asp:Label ID="LabelName" runat="server" Text="Mannschaftsname:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server" Visible="false"></asp:TextBox>

        <asp:Label ID="LabelSportArt" runat="server" Text="Sportart:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxSportArt" runat="server" Visible="false"></asp:TextBox>        

    </div>

    <asp:Button ID="ButtonAnlegen" runat="server" OnClick="MAnlegen" Enabled="false" Text="Mannschaft anlegen" />

    <asp:Table ID="TableMannschaft" runat="server" CellPadding="10" GridLines="Both"  Width="50%"  HorizontalAlign="Center" Font-Bold="true">
        <asp:TableRow>
             <asp:TableHeaderCell>
                <asp:Button ID="ButtonName" runat="server" onClick="sortMName" Text="Name" Width="100%"/>
            </asp:TableHeaderCell>

            <asp:TableHeaderCell runat="server" ID="TableSportart">
                <asp:Button ID="ButtonSportart" runat="server" onClick="sortMSportart" Text="Sportart" Width="100%"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TableAnzahl">
                <asp:Button ID="ButtonAnzahl" runat="server" onClick="sortAnzahlMitglieder" Text="Anzahl Mitglieder" Width="100%"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                Personenliste
            </asp:TableHeaderCell>
             <asp:TableHeaderCell>
                <asp:Button ID="ButtonaddMitglied" runat="server" onClick="addMitglied" Text="Mitglied hinzufügen" Width="100%"/>
            </asp:TableHeaderCell>
        </asp:TableRow>

    </asp:Table>
</asp:Content>
