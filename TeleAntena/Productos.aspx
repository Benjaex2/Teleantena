<%@ Page Title="" Language="C#" MasterPageFile="~/Teleantena.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="TeleAntena.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <div class="container">
            <div class="flex flex-wrap place-items-center divide-x">
                <asp:ListView ID="ListView" runat="server" DataSourceID="SqlDataSource1">
                    <ItemTemplate>
                        <div class="pl-14 ">
                            <div class="card card-compact w-96 bg-base-100 shadow-xl">
                                <figure>
                                    <img src="/Img/ImgProductos/<%#Eval("Imagen") %>"  width="400" height="600" />
                                </figure>
                                <div class="card-body">
                                    <h2 class="card-title"><%#Eval("NombreProducto") %></h2>
                                    <p>Stock: <%#Eval("Stock") %></p>
                                    <div class="card-actions justify-end">
                                        <button class="btn btn-primary">Ver más</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ID_Producto], [NombreProducto], [Stock], [Imagen] FROM [Productos]"></asp:SqlDataSource>
            </div>
        </div>
    </form>

</asp:Content>
