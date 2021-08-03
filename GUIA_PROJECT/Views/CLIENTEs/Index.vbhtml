@ModelType IEnumerable(Of GUIA_PROJECT.CLIENTE)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<div class="container mt-5 pt-5 pb-5">
    <h2 class="text-center">LISTA DE CLIENTES REGISTRADOS</h2>
    <link href="~/Content/css/owl.carousel.min.css" rel="stylesheet" />
    <p class="btn btn-block btn-primary mt-2 mb-2 text-white">
        @Html.ActionLink("Agregar Cliente", "Create")
    </p>


    <table class="table table-striped">
        <thead class="thead-dark">
            <tr>
                <th>Nombre </th>
                <th>Apellido</th>
                <th>Email</th>
                <th>Telefono</th>
                <th>Direccion</th>
                <th>Establecimiento</th>
                <th></th>
            </tr>
        </thead>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.CLI_NOMBRE)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.CLI_APELLIDO)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.CLI_EMAIL)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.CLI_TELEFONO)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.CLI_DIRECCION)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.ESTABLECIMIENTO.EST_NOMBRE)
                </td>
                <td>
                    <p class="btn btn-block btn-warning mt-2 mb-2 text-white">
                        @Html.ActionLink("Modificar", "Edit", New With {.id = item.CLI_ID})
                    </p>
                    <p class="btn btn-block btn-info mt-2 mb-2 text-white">
                        @Html.ActionLink("Detalles", "Details", New With {.id = item.CLI_ID})
                    </p>
                    <p class="btn btn-block btn-danger mt-2 mb-2 text-white">
                        @Html.ActionLink("Eliminar", "Delete", New With {.id = item.CLI_ID})
                    </p>

                    
                </td>
            </tr>
        Next

    </table>
</div>

