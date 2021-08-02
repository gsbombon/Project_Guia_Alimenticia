@ModelType IEnumerable(Of GUIA_PROJECT.ENTRENADORES)
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
            @Html.DisplayNameFor(Function(model) model.ENT_NOMBRE)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ENT_APELLIDO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ENT_TELEFONO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ENT_EMAIL)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ENT_DIRECCION)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ENT_SUELDO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ESTABLECIMIENTO.EST_NOMBRE)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ENT_NOMBRE)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ENT_APELLIDO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ENT_TELEFONO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ENT_EMAIL)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ENT_DIRECCION)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ENT_SUELDO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ESTABLECIMIENTO.EST_NOMBRE)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ENT_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ENT_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ENT_ID })
        </td>
    </tr>
Next

</table>
