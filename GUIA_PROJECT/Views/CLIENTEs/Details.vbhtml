@ModelType GUIA_PROJECT.CLIENTE
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>CLIENTE</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CLI_NOMBRE)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CLI_NOMBRE)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CLI_APELLIDO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CLI_APELLIDO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CLI_EMAIL)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CLI_EMAIL)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CLI_TELEFONO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CLI_TELEFONO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CLI_DIRECCION)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CLI_DIRECCION)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ESTABLECIMIENTO.EST_NOMBRE)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ESTABLECIMIENTO.EST_NOMBRE)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.CLI_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
