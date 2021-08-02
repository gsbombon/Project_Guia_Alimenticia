@ModelType GUIA_PROJECT.ENTRENAMIENTO
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>ENTRENAMIENTO</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FECHA)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FECHA)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CLIENTE.CLI_NOMBRE)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CLIENTE.CLI_NOMBRE)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DIETA.NOMBRE_DIETA)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DIETA.NOMBRE_DIETA)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EJERCICIO.EJER_RUTINA)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EJERCICIO.EJER_RUTINA)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ENTRENADORES.ENT_NOMBRE)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ENTRENADORES.ENT_NOMBRE)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
