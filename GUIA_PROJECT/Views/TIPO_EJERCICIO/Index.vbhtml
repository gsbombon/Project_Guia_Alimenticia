@ModelType IEnumerable(Of GUIA_PROJECT.TIPO_EJERCICIO)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container mt-5 pt-5 pb-5">
    <h2 class="text-center">LISTA DE TIPOS DE EJERCICIOS</h2>
    <link href="~/Content/css/owl.carousel.min.css" rel="stylesheet" />
    <p class="btn btn-block btn-primary mt-2 mb-2 text-white">
        @Html.ActionLink("Agregar Tipo Ejercicio", "Create")
    </p>

    <table class="table">
        <tr>
            <th>
                DESCRIPCION 
            </th>
            <th>
                CALORIAS GASTADAS
            </th>
            <th>
                ENFOQUE
            </th>
            <th>
                ESTADO
            </th>
            <th>
                RUTINA
            </th>
            <th></th>
        </tr>

        @For Each item In Model
            @<tr>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.EP_EJER_DESCRIPCION)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.CALORIAS_GASTADAS)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.ENFOQUE)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.ESTADO)
                </td>
                <td>
                    @Html.DisplayFor(Function(modelItem) item.EJERCICIO.EJER_RUTINA)
                </td>
                <td>
                    <p class="btn btn-block btn-warning mt-2 mb-2 text-white">
                        @Html.ActionLink("Edit", "Edit", New With {.id = item.TIP_EJER_ID})
                    </p>
                    <p class="btn btn-block btn-info mt-2 mb-2 text-white">
                        @Html.ActionLink("Details", "Details", New With {.id = item.TIP_EJER_ID})
                    </p>
                    <p class="btn btn-block btn-danger mt-2 mb-2 text-white">
                        @Html.ActionLink("Delete", "Delete", New With {.id = item.TIP_EJER_ID})
                    </p>                    
                </td>
            </tr>
        Next

    </table>
</div>