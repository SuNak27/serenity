
namespace Serenity.Cinema {

    @Serenity.Decorators.registerClass()
    export class MoviecastGrid extends Serenity.EntityGrid<MoviecastRow, any> {
        protected getColumnsKey() { return MoviecastColumns.columnsKey; }
        protected getDialogType() { return MoviecastDialog; }
        protected getIdProperty() { return MoviecastRow.idProperty; }
        protected getInsertPermission() { return MoviecastRow.insertPermission; }
        protected getLocalTextPrefix() { return MoviecastRow.localTextPrefix; }
        protected getService() { return MoviecastService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}