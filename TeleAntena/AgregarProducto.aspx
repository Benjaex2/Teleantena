<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="~/AgregarProducto.aspx.cs" Inherits="TeleAntena.AgregarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CP_Main" runat="server">
        <h5 class="center"><strong>Ingrese los datos del producto a agregar</strong></h5>
    <div class="container text-darken-1">
        <div class="row">
            <div class="input-field col s10">
                <asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox>
                <asp:Label id="label1" AssociatedControlId="TxtCodigo" Text="Codigo" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtCodigo" ForeColor="Red" runat="server" ErrorMessage="Campo Requerido" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" ControlToValidate="TxtCodigo" ForeColor="Red" runat="server" Type="Integer" Operator="GreaterThanEqual" ValueToCompare="0" ErrorMessage="Ingrese números positivos" Display="Dynamic"></asp:CompareValidator>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s10">
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                <asp:Label id="label2" AssociatedControlId="TxtNombre" Text="Nombre" runat="server"/>
                <asp:RequiredFieldValidator ID="ValidadorNombre" ControlToValidate="TxtNombre" ForeColor="Red" runat="server" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <h7>Marca:</h7>
            <asp:DropDownList ID="DropMarca" runat="server" OnSelectedIndexChanged="DropMarca_SelectedIndexChanged" CssClass="browser-default"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="ValidadorMarca" ControlToValidate="DropMarca" runat="server" ForeColor="Red" ErrorMessage="Elija una marca"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <h7>Tipo de Producto:</h7>
            <asp:DropDownList ID="DropTipo" runat="server" CssClass="browser-default" OnSelectedIndexChanged="DropTipo_SelectedIndexChanged"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="ValidadorTipo" ControlToValidate="DropTipo" runat="server" ForeColor="Red" ErrorMessage="Elija un tipo de producto"></asp:RequiredFieldValidator>
        </div>
        <div class="row">
            <div class="input-field col s10">
                <asp:TextBox ID="TxtStock" runat="server"></asp:TextBox>
                <asp:Label id="label3" AssociatedControlId="TxtStock" Text="Stock" runat="server"/>
                <asp:RequiredFieldValidator ID="ValidadorStock" ControlToValidate="TxtStock" runat="server" ForeColor="Red" ErrorMessage="Campo Requerido" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="ValidadorRangoStock" ControlToValidate="TxtStock" Type="Integer" ValueToCompare="0" Operator="GreaterThanEqual" runat="server" ForeColor="Red" ErrorMessage="El stock debe ser un número positivo" Display="Dynamic"></asp:CompareValidator>
            </div>    
        </div>
        <div class="row">
            <div class="input-field col s10">
                <asp:TextBox ID="TxtLink" runat="server"></asp:TextBox> 
                <asp:Label id="label4" AssociatedControlId="TxtLink" Text="Link" runat="server"/>
                <asp:RequiredFieldValidator ID="ValidadorLink" ControlToValidate="TxtLink" runat="server" ForeColor="Red" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s10">
                <asp:TextBox ID="TxtDetalle" runat="server"></asp:TextBox>
                <asp:Label id="label5" AssociatedControlId="TxtDetalle" Text="Detalle de Producto" runat="server"/>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s10">
                 <asp:Label id="label6" Text="Imagen del Producto:  " runat="server"/>
                <asp:FileUpload ID="fuImagen" runat="server" Width="300px" />
                <asp:RequiredFieldValidator ID="ValidadorImagen" ControlToValidate="fuImagen" runat="server" ForeColor="Red" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s10">
                <asp:Button ID="BtnAgregar" class='col s12 btn-large waves-effect indigo'  runat="server"  Text="Registrar" OnClick="BtnAgregar_Click" />
            </div>
        </div>
        <div class="fw-bdold text-center fs-5">
            <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
        </div>     
    </div>
</asp:Content>
