@ModelType IEnumerable(Of GUIA_PROJECT.ADMINISTRADOR)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mt-5 pt-5 pb-5">
    <h2 class="text-center">LISTA DE ADMINISTRADOS REGISTRADOS</h2>
    <link href="~/Content/css/owl.carousel.min.css" rel="stylesheet" />
    <p class="btn btn-block btn-primary mt-2 mb-2 text-white">
        @Html.ActionLink("Agregar Administrador", "Create")
    </p>


    <table class="table table-striped">
        <thead class="thead-dark">
            <tr>
                <th>
                    NOMBRE
                </th>
                <th>
                    APELLIDO
                </th>
                <th>
                    TELEFONO
                </th>
                <th>
                    EMAIL
                </th>
                <th>
                    ESTABLECIMIENTO
                </th>
                <th></th>
            </tr>
            </thead>

            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.ADMIN_NOMBRE)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.ADMIN_APELLIDO)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.ADMIN_TELEFONO)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.ADMIN_EMAIL)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.ESTABLECIMIENTO.EST_NOMBRE)
                    </td>
                    <td>
                        <p class="btn btn-block btn-warning mt-2 mb-2 text-white">
                            @Html.ActionLink("Edit", "Edit", New With {.id = item.ADMIN_ID})
                        </p>
                        <p class="btn btn-block btn-info mt-2 mb-2 text-white">
                            @Html.ActionLink("Details", "Details", New With {.id = item.ADMIN_ID})
                        </p>
                        <p class="btn btn-block btn-danger mt-2 mb-2 text-white">
                            @Html.ActionLink("Delete", "Delete", New With {.id = item.ADMIN_ID})
                        </p>                    
                    </td>
                </tr>
            Next

    </table>
</div>