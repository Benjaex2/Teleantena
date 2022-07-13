<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="~/BuscarProducto.aspx.cs" Inherits="TeleAntena.BuscarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style>
        #fondo{
            position: fixed;
            top: 0px;
            left: 0px;
            right: 0px;
            bottom: 0px;
            overflow: hidden;
            padding: 0px;
            margin: 0px;
            background-color: white;
            opacity: 0.8;
            z-index: 10000;
        }
        #imagen {

            position: fixed;
            top: 0%;
            left: 0%;
            height: 100%;
            width: 100%;
            z-index: 10001;
            background-image: url('Img/load.gif');
            background-repeat: no-repeat;
            background-position: center;
        }
    </style>
</asp:Content>

<asp:Content ID="Content7" ContentPlaceHolderID="CP_Main" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanelProducto"  runat="server" BorderStyle="Ridge" Width="672px" align="center" CssClass="auto-style12">
        <ContentTemplate>
            <table align="center">
                <tr>
                    <td class="auto-style11" colspan="2">
                        <asp:Label ID="LblCodigo" runat="server" Text="Ingrese el código del producto a buscar:"></asp:Label>
                        <asp:TextBox ID="TxtBuscar" runat="server" Style="margin-left: 27px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                        <asp:Button ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click" Style="margin-left: 25px; " Text="Buscar" />
                    </td>
                </tr>
            </table>

            <asp:Label ID="LbMensajeError" runat="server" Text=""></asp:Label>

            <asp:Panel ID="PanelProducto" Visible="false" runat="server">
                <!--Los label no se pueden modificar, por eso se tiene que trabajar con txt-->
            <table class="auto-style1" align="center">
                <tr>
                    <td class="auto-style2" colspan="2" align="center"><strong>Datos del Producto</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2">Código:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TxtCodigo" Enabled="false" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Nombre:</td>
                    <td class="auto-style3">
                        <asp:Label ID="LbNombre" Enabled="false"  runat="server" Text=""></asp:Label>
                        

                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Marca:</td>
                    <td class="auto-style2">
                        <asp:Label ID="LbMarca" Enabled="false"  runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Tipo de Producto:</td>
                    <td class="auto-style2">
                        <asp:Label ID="LbTipo" Enabled="false" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Stock:</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TxtStock" Enabled="false" runat="server" OnTextChanged="TxtStock_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">Manual:</td>
                    <td class="auto-style7">
                        <asp:LinkButton ID="LnkManual"  runat="server" OnClick="LinkButton1_Click">Ver Manuales</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Video</td>
                    <td class="auto-style9">
                        <asp:LinkButton ID="LnkVideo"  runat="server" OnClick="LinkButton2_Click">Ver Videos</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Link</td>
                    <td class="auto-style9">
                        <asp:Label ID="LbLink" Enabled="false" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Detalle Producto</td>
                    <td class="auto-style9">
                        <asp:Label ID="LbDetalle" Enabled="false" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Imagen</td>
                    <td class="auto-style9">
                        <asp:Image ID="Imagen" Enabled="false" runat="server" ImageUrl="" AlternateText="imagen" />
                    </td>      
            </table>
                <br />
                <asp:LinkButton class='col s2 waves-effect waves-light btn-large text-center' ID="LnkEditar" runat="server" OnClick="LnkEditar_Click">Editar</asp:LinkButton>
                <asp:LinkButton class='col s2 waves-effect waves-light btn-large text-center' ID="LnkModificarStock" runat="server" OnClick="LnkModificarStock_Click1" >Stock</asp:LinkButton>
                <asp:LinkButton class='col s2 waves-effect waves-light btn-large text-center' ID="LnkEliminar" Text="Eliminar" runat="server" OnClick="LnkEliminar_Click" />
                <div class="col s12 waves-effect waves-light btn-large text-center">
                    <asp:Button ID="BtnEditar" Enabled="false" runat="server" Text="Guardar Cambios" OnClick="BtnEditar_Click" />
                </div>
                <br />
                <asp:Label ID="LbMensaje" runat="server" Text=""></asp:Label>
                </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:UpdateProgress ID="UpdateProgressProdcuto" AssociatedUpdatePanelID="UpdatePanelProducto" runat="server">
        <ProgressTemplate>
            <div id="fondo"></div>
            <div id="imagen"></div>
        </ProgressTemplate>
    </asp:UpdateProgress>
</asp:Content>

