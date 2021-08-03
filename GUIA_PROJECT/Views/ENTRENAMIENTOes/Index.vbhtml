@ModelType IEnumerable(Of GUIA_PROJECT.ENTRENAMIENTO)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mt-5 pt-5 pb-5">
    <h2 class="text-center">LISTA DE ENTRENAMIENTOS</h2>
    <link href="~/Content/css/owl.carousel.min.css" rel="stylesheet" />
    <p class="btn btn-block btn-primary mt-2 mb-2 text-white">
        @Html.ActionLink("Agregar Entrenamiento", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                FECHA
            </th>
            <th>
                NOMBRE CLIENTE
            </th>
            <th>
                NOMBRE DIETA
            </th>
            <th>
                RUTINA
            </th>
            <th>
                ENTRENADOR 
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.FECHA)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.CLIENTE.CLI_NOMBRE)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.DIETA.NOMBRE_DIETA)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.EJERCICIO.EJER_RUTINA)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.ENTRENADORES.ENT_NOMBRE)
                </td>
                <td>
                    @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
                        @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
                        @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
                </td>
            </tr>
        Next

    </table>
</div>