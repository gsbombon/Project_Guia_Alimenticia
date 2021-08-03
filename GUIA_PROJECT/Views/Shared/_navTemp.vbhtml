<div class="navbar navbar-inverse navbar-fixed-top">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            @Html.ActionLink("Gui Alimenticia", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
        </div>
        <div class="navbar-collapse collapse">
            <ul class="nav navbar-nav">
                <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
                <li>@Html.ActionLink("Clientes", "Index", "CLIENTEs")</li>
                <li>@Html.ActionLink("Entrenadores", "Index", "ENTRENADORES")</li>
                <li>@Html.ActionLink("Entrenamiento", "Index", "ENTRENAMIENTOes")</li>
                <li>@Html.ActionLink("Adminis", "Index", "ADMINISTRADORs")</li>
            </ul>
        </div>
    </div>
</div>
