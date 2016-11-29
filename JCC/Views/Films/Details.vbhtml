@ModelType JCC.Domain.Entities.Film
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Film</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nom)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nom)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.realisateur)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.realisateur)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.origine)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.origine)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.FilmId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
