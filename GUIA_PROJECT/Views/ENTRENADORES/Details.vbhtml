@ModelType GUIA_PROJECT.ENTRENADORES
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code


<div class="container mt-5 pt-5 pb-5">


    <h2>DETALLES DEL CLIENTE</h2>

    <div>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                NOMBRE
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ENT_NOMBRE)
            </dd>

            <dt>
                APELLIDO
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ENT_APELLIDO)
            </dd>

            <dt>
                TELEFONO
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ENT_TELEFONO)
            </dd>

            <dt>
                EMAIL
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ENT_EMAIL)
            </dd>

            <dt>
                DIRECCION
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ENT_DIRECCION)
            </dd>

            <dt>
                SUELDO
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ENT_SUELDO)
            </dd>

            <dt>
                ESTABLECIMIENTO
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ESTABLECIMIENTO.EST_NOMBRE)
            </dd>

        </dl>
    </div>
    <p>
        <p class="btn btn-block btn-warning mt-2 mb-2 text-white">
            @Html.ActionLink("Edit", "Edit", New With {.id = Model.ENT_ID})
        </p>
        <p class="btn btn-block btn-dark mt-2 mb-2 text-white">
            @Html.ActionLink("Regresar a la Lista", "Index")
        </p>
    </p>
</div>