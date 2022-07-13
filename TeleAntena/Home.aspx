<%@ Page Title="" Language="C#" MasterPageFile="~/Teleantena.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TeleAntena.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="carousel w-full">
        <div id="slide1" class="carousel-item relative w-full">
            <img src="https://teleantena.cl/wp-content/uploads/2022/02/Banner_Teleantena_02.png" class="w-full" />
            <div class="absolute flex justify-between transform -translate-y-1/2 left-5 right-5 top-1/2">
                <a href="#slide4" class="btn btn-circle">❮</a>
                <a href="#slide2" class="btn btn-circle">❯</a>
            </div>
        </div>
        <div id="slide2" class="carousel-item relative w-full">
            <img src="https://teleantena.cl/wp-content/uploads/2022/02/Banner_Teleantena_04.png" class="w-full" />
            <div class="absolute flex justify-between transform -translate-y-1/2 left-5 right-5 top-1/2">
                <a href="#slide1" class="btn btn-circle">❮</a>
                <a href="#slide3" class="btn btn-circle">❯</a>
            </div>
        </div>
        <div id="slide3" class="carousel-item relative w-full">
            <img src="https://teleantena.cl/wp-content/uploads/2022/02/Banner_Teleantena_01.png" class="w-full" />
            <div class="absolute flex justify-between transform -translate-y-1/2 left-5 right-5 top-1/2">
                <a href="#slide2" class="btn btn-circle">❮</a>
                <a href="#slide4" class="btn btn-circle">❯</a>
            </div>
        </div>
    </div>
    <br />
    <div class="flex items-center justify-center">
        <div class="h-4 font-bold">
            <p class="text-2xl">SOMOS PARTNER</p>
        </div>
    </div>
    <br />
    <div class="flex items-center justify-center">
        <a href="https://teleantena.cl/wp-content/uploads/2022/02/Certificacion_Partner_Huawei.pdf" target="_blank">
		<img width="200" height="150" src="https://teleantena.cl/wp-content/uploads/2022/01/Logo_HuaweiI-768x406.png" class="" alt="" loading="lazy" srcset="https://teleantena.cl/wp-content/uploads/2022/01/Logo_HuaweiI-768x406.png 768w, https://teleantena.cl/wp-content/uploads/2022/01/Logo_HuaweiI-300x158.png 300w, https://teleantena.cl/wp-content/uploads/2022/01/Logo_HuaweiI.png 920w" sizes="(max-width: 640px) 100vw, 640px">
        </a>
        &nbsp;
        &nbsp;
        <img width="200" height="150" src="https://teleantena.cl/wp-content/uploads/2022/01/Logo_FurukawaI-768x406.png" alt="" loading="lazy" srcset="https://teleantena.cl/wp-content/uploads/2022/01/Logo_FurukawaI-768x406.png 768w, https://teleantena.cl/wp-content/uploads/2022/01/Logo_FurukawaI-300x158.png 300w, https://teleantena.cl/wp-content/uploads/2022/01/Logo_FurukawaI.png 920w" sizes="(max-width: 640px) 100vw, 640px">
        &nbsp;
        &nbsp;
        <img width="200" height="150" src="https://teleantena.cl/wp-content/uploads/2022/01/Logo_FortinetI-768x406.png" alt="" loading="lazy" srcset="https://teleantena.cl/wp-content/uploads/2022/01/Logo_FortinetI-768x406.png 768w, https://teleantena.cl/wp-content/uploads/2022/01/Logo_FortinetI-300x158.png 300w, https://teleantena.cl/wp-content/uploads/2022/01/Logo_FortinetI.png 920w" sizes="(max-width: 640px) 100vw, 640px">
        &nbsp;
        &nbsp;
        <img width="200" height="150" src="https://teleantena.cl/wp-content/uploads/2022/02/Logo_SophosI-768x406.png" alt="" loading="lazy" srcset="https://teleantena.cl/wp-content/uploads/2022/02/Logo_SophosI-768x406.png 768w, https://teleantena.cl/wp-content/uploads/2022/02/Logo_SophosI-300x158.png 300w, https://teleantena.cl/wp-content/uploads/2022/02/Logo_SophosI.png 920w" sizes="(max-width: 640px) 100vw, 640px">
    </div>
    <br />
</asp:Content>
