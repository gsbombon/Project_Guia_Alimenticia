@ModelType GUIA_PROJECT.ADMINISTRADOR
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>ADMINISTRADOR</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ADMIN_NOMBRE)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ADMIN_NOMBRE)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ADMIN_TELEFONO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ADMIN_TELEFONO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ADMIN_EMAIL)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ADMIN_EMAIL)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ADMIN_APELLIDO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ADMIN_APELLIDO)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ADMIN_ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
