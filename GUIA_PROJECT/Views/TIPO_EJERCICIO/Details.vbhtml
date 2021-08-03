@ModelType GUIA_PROJECT.TIPO_EJERCICIO
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mt-5 pt-5 pb-5">


    <h2>DETALLES DEL TIPO DE EJERCICIO</h2>

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
                RUTINA
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.EJERCICIO.EJER_RUTINA)
            </dd>

        </dl>
    </div>
        <p>
            <p class="btn btn-block btn-warning mt-2 mb-2 text-white">
                @Html.ActionLink("Editar", "Edit", New With {.id = Model.TIP_EJER_ID})
            </p>
            <p class="btn btn-block btn-dark mt-2 mb-2 text-white">
                @Html.ActionLink("Regresar a la Lista", "Index")
            </p>
        </p>

</div>