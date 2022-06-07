﻿
namespace Serenity.Cinema {

    import fld = MovieRow.Fields;

    @Serenity.Decorators.registerClass()
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return MovieColumns.columnsKey; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            return [
                { name: "", title: "all" },
                { name: fld.Description, title: "description" },
                { name: fld.Storyline, title: "storyline" },
                { name: fld.Year, title: "year" }
            ];
        }

        protected getQuickFilters() {
            let items = super.getQuickFilters();

            const genreListFilter = Q.first(items, x =>
                x.field == MovieRow.Fields.GenreList);

            genreListFilter.handler = h => {
                const request = (h.request as MovieListRequest);
                const values = (h.widget as Serenity.LookupEditor).values;
                request.Genres = values.map(x => parseInt(x, 10));
                h.handled = true
            }

            return items;
        }
    }
}