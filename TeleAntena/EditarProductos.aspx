<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="EditarProductos.aspx.cs" Inherits="TeleAntena.EditarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 472px;
        }
        .auto-style2 {
            width: 473px;
        }
        .auto-style3 {
            width: 765px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CP_Main" runat="server">
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style2 center" colspan="2" align="center"><strong>Ingresar Datos</strong></td>
        </tr>
        <tr>
            <td class="auto-style3">Código</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtCodigo" runat="server" OnTextChanged="TxtCodigo_TextChanged"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TxtCodigo" ForeColor="Red" runat="server" ErrorMessage="Campo Requerido" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" ControlToValidate="TxtCodigo" ForeColor="Red" runat="server" Type="Integer" Operator="GreaterThanEqual" ValueToCompare="0" ErrorMessage="Ingrese números positivos" Display="Dynamic"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Nombre</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ValidadorNombre" ControlToValidate="TxtNombre" ForeColor="Red" runat="server" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Marca</td>
            <td class="auto-style2">
                <asp:DropDownList ID="DropMarca" runat="server" CssClass="browser-default"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="ValidadorMarca" ControlToValidate="DropMarca" runat="server" ForeColor="Red" ErrorMessage="Elija una marca"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Tipo</td>
            <td class="auto-style2">
                <asp:DropDownList ID="DropTipo" runat="server" CssClass="browser-default"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="ValidadorTipo" ControlToValidate="DropTipo" runat="server" ForeColor="Red" ErrorMessage="Elija un tipo de producto"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Stock</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtStock" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ValidadorStock" ControlToValidate="TxtStock" runat="server" ForeColor="Red" ErrorMessage="Campo Requerido" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="ValidadorRangoStock" ControlToValidate="TxtStock" Type="Integer" ValueToCompare="0" Operator="GreaterThanEqual" runat="server" ForeColor="Red" ErrorMessage="El stock debe ser un número positivo" Display="Dynamic"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Link</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtLink" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ValidadorLink" ControlToValidate="TxtLink" runat="server" ForeColor="Red" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Detalle</td>
            <td class="auto-style2">
                <asp:TextBox ID="TxtDetalle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Imagen (Adjunte archivo solo si desea cambiar la imagen del producto)</td>
            <td class="auto-style9">
                <asp:FileUpload ID="fuImagen" runat="server" Width="167px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" colspan="2">
                <asp:Button ID="BtnEditar" runat="server" Text="Editar" OnClick="BtnEditar_Click" />
            </td>
        </tr>
    </table>
    <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
</asp:Content>
