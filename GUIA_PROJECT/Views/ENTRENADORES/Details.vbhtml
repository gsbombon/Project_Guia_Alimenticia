@ModelType GUIA_PROJECT.ENTRENADORES
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>ENTRENADORES</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ENT_NOMBRE)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ENT_NOMBRE)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ENT_APELLIDO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ENT_APELLIDO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ENT_TELEFONO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ENT_TELEFONO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ENT_EMAIL)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ENT_EMAIL)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ENT_DIRECCION)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ENT_DIRECCION)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ENT_SUELDO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ENT_SUELDO)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ENT_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
