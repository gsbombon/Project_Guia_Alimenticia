@ModelType GUIA_PROJECT.CLIENTE
@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mt-5 pt-5 pb-5">

    <h2>EDITAR CLIENTE</h2>

    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()
        @<div class="form-horizontal">
            <hr />
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            <div class="form-group">
                @Html.LabelFor(Function(model) model.EST_ID, "EST_ID", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.DropDownList("EST_ID", Nothing, htmlAttributes:=New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.EST_ID, "", New With {.class = "text-danger"})
                </div>
            </div>

            @Html.HiddenFor(Function(model) model.CLI_ID)

            <div class="form-group">
                @Html.LabelFor(Function(model) model.CLI_NOMBRE, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.CLI_NOMBRE, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.CLI_NOMBRE, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.CLI_APELLIDO, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.CLI_APELLIDO, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.CLI_APELLIDO, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.CLI_EMAIL, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.CLI_EMAIL, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.CLI_EMAIL, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.CLI_TELEFONO, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.CLI_TELEFONO, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.CLI_TELEFONO, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.CLI_DIRECCION, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.CLI_DIRECCION, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.CLI_DIRECCION, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Guardar" class="btn btn-block btn-success mt-2 mb-2 text-white" />
                </div>
            </div>
        </div>
    End Using

     <p class="btn btn-block btn-dark mt-2 mb-2 text-white">
            @Html.ActionLink("Regresar a la Lista", "Index")
     </p>
</div>