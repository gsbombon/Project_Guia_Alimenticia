@ModelType GUIA_PROJECT.ADMINISTRADOR
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mt-5 pt-5 pb-5">

    <h2>ELIMINAR CLIENTE</h2>

    <h3>Seguro desea eliminar al cliente ? </h3>
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