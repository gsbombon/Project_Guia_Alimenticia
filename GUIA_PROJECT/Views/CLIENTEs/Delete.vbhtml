@ModelType GUIA_PROJECT.CLIENTE
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
