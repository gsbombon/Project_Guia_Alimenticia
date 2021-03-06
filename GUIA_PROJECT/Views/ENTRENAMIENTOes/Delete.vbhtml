@ModelType GUIA_PROJECT.ENTRENAMIENTO
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<div class="container mt-5 pt-5 pb-5">

    <h2>ELIMINAR ENTRENAMIENTO</h2>

    <h3>Seguro desea eliminar el entrenamiento ? </h3>
    <div>
        <h4>ENTRENAMIENTO</h4>
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
                DIETA
            </dt>
            <dd>
                @Html.DisplayFor(Function(model) model.DIETA.NOMBRE_DIETA)
            </dd>
            <dt>
                RUTINA
            </dt>
            <dd>
                @Html.DisplayFor(Function(model) model.EJERCICIO.EJER_RUTINA)
            </dd>
            <dt>
                NOMBRE ENTRENADOR
            </dt>
            <dd>
                @Html.DisplayFor(Function(model) model.ENTRENADORES.ENT_NOMBRE)
            </dd>

        </dl>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
            @<div class="form-actions no-color">
                <input type="submit" value="Delete" class="btn btn-block btn-danger mt-2 mb-2 text-white" />
                <p class="btn btn-block btn-dark mt-2 mb-2 text-white">
                    @Html.ActionLink("Regresar a la Lista", "Index")
                </p>
            </div>
        End Using
    </div>
</div>