@ModelType GUIA_PROJECT.ADMINISTRADOR
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <div class="container mt-5 pt-5 pb-5">


        <h2>DETALLES DEL ADMINISTRADOR</h2>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                NOMBRE
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ADMIN_NOMBRE)
            </dd>

            <dt>
                APELLIDOS
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ADMIN_APELLIDO)
            </dd>

            <dt>
                TELEFONO
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ADMIN_TELEFONO)
            </dd>

            <dt>
                EMAIL
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.ADMIN_EMAIL)
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
            @Html.ActionLink("Edit", "Edit", New With {.id = Model.ADMIN_ID})
        </p>
        <p class="btn btn-block btn-dark mt-2 mb-2 text-white">
            @Html.ActionLink("Back to List", "Index")
        </p>
    </p>

</div>
