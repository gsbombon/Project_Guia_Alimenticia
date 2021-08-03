@ModelType GUIA_PROJECT.TIPO_EJERCICIO
@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mt-5 pt-5 pb-5">
    <h2>Añadir Nuevo Tipo Ejercicio</h2>

    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-horizontal">
            <hr />
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            <div class="form-group">
                @Html.LabelFor(Function(model) model.EJER_ID, "ID", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.DropDownList("EJER_ID", Nothing, htmlAttributes:=New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.EJER_ID, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.TIP_EJER_ID, "TIPO EJERCICIO", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.TIP_EJER_ID, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.TIP_EJER_ID, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.EP_EJER_DESCRIPCION, "DESCRIPCION", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.EP_EJER_DESCRIPCION, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.EP_EJER_DESCRIPCION, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.CALORIAS_GASTADAS, "CALORIAS GASTADAS", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.CALORIAS_GASTADAS, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.CALORIAS_GASTADAS, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.ENFOQUE, "ENFOQUE", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.ENFOQUE, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.ENFOQUE, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.ESTADO, "ESTADO", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    <div class="checkbox">
                        @Html.EditorFor(Function(model) model.ESTADO)
                        @Html.ValidationMessageFor(Function(model) model.ESTADO, "", New With {.class = "text-danger"})
                    </div>
                </div>
            </div>

            <<div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Crear" class="btn btn-block btn-success mt-2 mb-2 text-white" />
                </div>
            </div>
        </div>
    End Using

    <div class="align-items-center">
        <p class="btn btn-block btn-dark mt-2 mb-2 text-white">
            @Html.ActionLink("Regresar a la Lista", "Index")
        </p>
    </div>
</div>