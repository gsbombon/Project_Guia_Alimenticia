@ModelType IEnumerable(Of GUIA_PROJECT.ADMINISTRADOR)
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
            @Html.DisplayNameFor(Function(model) model.ADMIN_NOMBRE)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ADMIN_TELEFONO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ADMIN_EMAIL)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ADMIN_APELLIDO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ESTABLECIMIENTO.EST_NOMBRE)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ADMIN_NOMBRE)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ADMIN_TELEFONO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ADMIN_EMAIL)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ADMIN_APELLIDO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ESTABLECIMIENTO.EST_NOMBRE)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ADMIN_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ADMIN_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ADMIN_ID })
        </td>
    </tr>
Next

</table>
