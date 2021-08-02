@ModelType IEnumerable(Of GUIA_PROJECT.ENTRENAMIENTO)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.FECHA)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CLIENTE.CLI_NOMBRE)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DIETA.NOMBRE_DIETA)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EJERCICIO.EJER_RUTINA)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ENTRENADORES.ENT_NOMBRE)
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
