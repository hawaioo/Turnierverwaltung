<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mannschaftsverwaltung.aspx.cs" Inherits="WebManschaftsverwaltung.View.Mannschaftsverwaltung" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" style="font-weight:700; font-size: 2rem">Mannschaftsart:</asp:Label>
     <asp:RadioButtonList ID="RadioButtonList7" runat="server" RepeatDirection="Horizontal">
        <asp:ListItem Value="Fussball" style="margin-right: 20px;">Fussball</asp:ListItem>
        <asp:ListItem Value="Tennis" style="margin-right: 20px;">Tennis</asp:ListItem>
        <asp:ListItem Value="Handball" style="margin-right: 20px;">Handball</asp:ListItem>
    </asp:RadioButtonList>

     <asp:Button CssClass="btn btn-primary" ID="ButtonErstellen" runat="server" OnClick="MErstellen" Text="Mannschaftsart auswählen" />
    <br />
    <br />
    <div runat="server" ID="text_inputs2">
        <asp:Label ID="LabelName" runat="server" Text="Mannschaftsname:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxName" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>

        <asp:Label ID="LabelSportArt" runat="server" Text="Sportart:" Visible="false"></asp:Label>
        <asp:TextBox ID="TextBoxSportArt" runat="server" Visible="false" CssClass="form-control"></asp:TextBox>        

    </div>

    <asp:Button CssClass="btn btn-primary" ID="ButtonAnlegen" runat="server" OnClick="MAnlegen" Enabled="false" Text="Mannschaft anlegen" />
    <br />
    <br />
    <asp:Table ID="TableMannschaft" runat="server" CellPadding="10" GridLines="Both"  Width="50%"  HorizontalAlign="Center" Font-Bold="true">
        <asp:TableRow>
             <asp:TableHeaderCell>
                <asp:Button ID="ButtonName" runat="server" onClick="sortMName" Text="Name" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>

            <asp:TableHeaderCell runat="server" ID="TableSportart">
                <asp:Button ID="ButtonSportart" runat="server" onClick="sortMSportart" Text="Sportart" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" ID="TableAnzahl">
                <asp:Button ID="ButtonAnzahl" runat="server" onClick="sortAnzahlMitglieder" Text="Anzahl Mitglieder" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>
            <asp:TableHeaderCell>
                Personenliste
            </asp:TableHeaderCell>
             <asp:TableHeaderCell>
                <asp:Button ID="ButtonaddMitglied" runat="server" onClick="addMitglied" Text="Mitglied hinzufügen" Width="100%" CssClass="btn"/>
            </asp:TableHeaderCell>
        </asp:TableRow>

    </asp:Table>
</asp:Content>
