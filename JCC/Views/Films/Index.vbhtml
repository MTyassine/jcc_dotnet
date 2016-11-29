@ModelType IEnumerable(Of JCC.Domain.Entities.Film)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nom)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.realisateur)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.origine)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nom)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.realisateur)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.origine)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.FilmId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.FilmId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.FilmId })
        </td>
    </tr>
Next

</table>
