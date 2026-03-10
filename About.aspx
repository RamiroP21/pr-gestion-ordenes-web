<%@ Page Title="Acerca de" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="P_R_OBLIGATORIO.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="/Styles/DisAbout.css" />

    <div class="welcome-container">
        <h1 class="welcome-title">¡Bienvenido al Sistema!</h1>
        <img src="Images/banner.png" alt="Bienvenida" class="welcome-image" />
        <p class="welcome-text">
            Nos complace darte la bienvenida a nuestro sistema diseñado para facilitar tu trabajo 
            como técnico. Este sistema te permitirá gestionar tareas, clientes y reportes de manera rápida 
            y eficiente, asegurándote de que nada quede fuera de control.
        </p>
        <p class="welcome-text">
            Tu trabajo es esencial para nuestro éxito, y este sistema ha sido pensado para ayudarte a lograr 
            más con menos esfuerzo. Con herramientas modernas y accesibles, queremos asegurarnos de que cada 
            día sea más productivo para ti.
        </p>
        <p class="welcome-footer">
            ¡Gracias por tu dedicación y compromiso! Recuerda que nuestro equipo está siempre disponible para 
            apoyarte. Juntos lograremos grandes cosas.
        </p>
        <div class="links-container">
            <a href="/Pages/PagCliente.aspx" class="btn">Gestión de Clientes</a>
            <a href="/Pages/PagTecnico.aspx" class="btn">Gestión de Tecnicos</a>
            <a href="/Pages/PagOrden.aspx" class="btn">Gestión de Órdenes</a>
            <a href="/Pages/PagBuscarOrden.aspx" class="btn">Búsqueda de Órdenes</a>
            <a href="/Pages/ReporteActividad.aspx" class="btn">Gestión de Reportes</a>
        </div>
    </div>
</asp:Content>


