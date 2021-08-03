    <!-- Header Section Begin -->
<header class="header-section bg-dark mb-5">
    <div class="container">
        <div class="logo">
            <a href="#">
                <img src="@Url.Content("~/Content/img/logo.png")" alt="">
            </a>
        </div>

        <div class="nav-menu bg-dark">
            <nav class="mainmenu mobile-menu navbar-dark bg-dark navbar-expand-lg">
                <ul>
                    <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                    <li>@Html.ActionLink("Clientes", "Index", "CLIENTEs")</li>
                    <li>@Html.ActionLink("Administrador", "Index", "ADMINISTRADORs")</li> 
                    <li>@Html.ActionLink("Entrenamiento", "Index", "ENTRENAMIENTOes")</li>
                    <li>@Html.ActionLink("Entrenadores", "Index", "ENTRENADORES")</li>
                    <li>@Html.ActionLink("Tipo Ejercicio", "Index", "TIPO_EJERCICIO")</li>
                </ul>
            </nav>
            <a href="#" class="primary-btn signup-btn">Sign Up </a>
        </div>
        <div id="mobile-menu-wrap"></div>
    </div>
</header>
<!-- Header End -->
