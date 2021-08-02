@ModelType GUIA_PROJECT.ENTRENADORES
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
