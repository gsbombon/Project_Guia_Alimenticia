@ModelType GUIA_PROJECT.ENTRENAMIENTO
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mt-5 pt-5 pb-5">

    <h2>DETALLES DEL ENTRENAMIENTO</h2>

    <div>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                FECHA
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.FECHA)
            </dd>

            <dt>
                NOMBRE CLIENTE
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.CLIENTE.CLI_NOMBRE)
            </dd>

            <dt>
                NOMBRE DIETA
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.DIETA.NOMBRE_DIETA)
            </dd>

            <dt>
                EJERCICIO RUTINA
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.EJERCICIO.EJER_RUTINA)
            </dd>

            <dt>
                ENTRENADOR
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ENTRENADORES.ENT_NOMBRE)
            </dd>

        </dl>
    </div>

    <p>
         @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
        <p class="btn btn-block btn-dark mt-2 mb-2 text-white">
            @Html.ActionLink("Regresar a la Lista", "Index")
        </p>
    </p>
</div>