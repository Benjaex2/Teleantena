<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="~/AgregarCapacitacion.aspx.cs" Inherits="TeleAntena.AgregarCapacitacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 54px;
        }
        .auto-style2 {
            height: 63px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CP_Main" runat="server">
    <h5 class="center"><strong>Ingrese los datos de la capacitación</strong></h5>
    <div class="container">
        <div class="row">
            <div class="input-field col s10">
                <asp:Label id="label6" Text="Producto:  " runat="server"/>
                <asp:DropDownList ID="DropProducto" runat="server" CssClass="browser-default"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="ValidadorProducto" ControlToValidate="DropProducto" runat="server" ForeColor="Red" ErrorMessage="Elija un producto"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s10">
                <asp:Label id="label2" Text="Tipo de Capacitación:  " runat="server"/>
                <asp:DropDownList ID="DropCapa" runat="server" CssClass="auto-style3 browser-default">
                    <asp:ListItem Selected="True" Value="1"> Manual </asp:ListItem>
                    <asp:ListItem Selected="False" Value="2"> Video </asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="ValidadorCapacitacion" ControlToValidate="DropCapa" runat="server" ForeColor="Red" ErrorMessage="Elija un tipo de capacitacion"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s10">
                <asp:TextBox ID="TxtLink" runat="server"></asp:TextBox>
                <asp:Label id="label4" AssociatedControlId="TxtLink" Text="Link" runat="server"/>
                <asp:RequiredFieldValidator ID="ValidadorLink" ControlToValidate="TxtLink" runat="server" ForeColor="Red" ErrorMessage="Ingrese un link" ></asp:RequiredFieldValidator>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="BtnAgregar_Click" />
        <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
