@ModelType GUIA_PROJECT.CLIENTE
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mt-5 pt-5 pb-5">


    <h2>DETALLES DEL CLIENTE</h2>

    <div>

        <hr />
        <dl class="dl-horizontal">
            <dt> NOMBRE </dt>
            <dd> @Html.DisplayFor(Function(model) model.CLI_NOMBRE) </dd>

            <dt>
                APELLIDO
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.CLI_APELLIDO)
            </dd>

            <dt>
                EMAIL
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.CLI_EMAIL)
            </dd>

            <dt>
                TELEFONO
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.CLI_TELEFONO)
            </dd>

            <dt>
                DIRECCION
            </dt>

            <dd>
                @Html.DisplayFor(Function(model) model.CLI_DIRECCION)
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
            @Html.ActionLink("Edit", "Edit", New With {.id = Model.CLI_ID}) 
        </p>
        <p class="btn btn-block btn-dark mt-2 mb-2 text-white">
            @Html.ActionLink("Back to List", "Index")
        </p>
    
    </p>
</div>