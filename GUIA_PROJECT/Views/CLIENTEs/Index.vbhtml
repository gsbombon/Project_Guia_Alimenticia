@ModelType IEnumerable(Of GUIA_PROJECT.CLIENTE)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2 class="text-center">LISTA DE CLIENTES REGISTRADOS EN QUITO</h2>

<p>
    @Html.ActionLink("Agregar Cliente", "Create")
</p>
<table class="table">
    <tr>
        <th>Nombre </th>
        <th>Apellido</th>
        <th>Email</th>
        <th>Telefono</th>
        <th>Direccion</th>
        <th>Establecimiento</th>
        <th></th>
    </tr>

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
            @Html.ActionLink("Modificar", "Edit", New With {.id = item.CLI_ID}) |
            @Html.ActionLink("Ver Detalles", "Details", New With {.id = item.CLI_ID}) |
            @Html.ActionLink("Eliminar", "Delete", New With {.id = item.CLI_ID})
        </td>
    </tr>
Next

</table>
