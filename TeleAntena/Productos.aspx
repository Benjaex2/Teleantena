<%@ Page Title="" Language="C#" MasterPageFile="~/Teleantena.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="TeleAntena.Productos1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <div class="grid grid-cols-4 gap-4 place-items-center divide-x">
<asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
            <ItemTemplate>
                    <div class="card card-compact w-96 bg-base-100 shadow-xl">
                    <figure>
                        <img src="/Img/ImgProductos/<%#Eval("Imagen") %>" alt="Shoes" width="400" height="600" />
                    </figure>
                    <div class="card-body">
                        <h2 class="card-title"><%#Eval("NombreProducto") %></h2>
                        <p><%#Eval("Stock") %></p>
                        <div class="card-actions justify-end">
                            <button class="btn btn-primary">Buy Now</button>
                        </div>
                    </div>
                </div>
        </ItemTemplate>
        </asp:ListView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [NombreProducto], [Stock], [Imagen], FROM [Productos]"></asp:SqlDataSource>
        
    </form>

</asp:Content>
