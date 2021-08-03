@ModelType GUIA_PROJECT.TIPO_EJERCICIO
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<div class="container mt-5 pt-5 pb-5">

    <h2>ELIMINAR TIPO EJERCICIO</h2>

    <h3>Seguro desea eliminar el tipo de ejercicio ? </h3>
    <div>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                DESCRIPCION
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.EP_EJER_DESCRIPCION)
            </dd>

            <dt>
                CALORIAS GASTADAS
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.CALORIAS_GASTADAS)
            </dd>

            <dt>
                ENFOQUE
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ENFOQUE)
            </dd>

            <dt>
                ESTADO
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ESTADO)
            </dd>

            <dt>
                EJERCICIO RUTINAS
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.EJERCICIO.EJER_RUTINA)
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