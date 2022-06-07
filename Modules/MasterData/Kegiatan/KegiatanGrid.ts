
namespace Serenity.MasterData {

    @Serenity.Decorators.registerClass()
    export class KegiatanGrid extends Serenity.EntityGrid<KegiatanRow, any> {
        protected getColumnsKey() { return KegiatanColumns.columnsKey; }
        protected getDialogType() { return KegiatanDialog; }
        protected getIdProperty() { return KegiatanRow.idProperty; }
        protected getInsertPermission() { return KegiatanRow.insertPermission; }
        protected getLocalTextPrefix() { return KegiatanRow.localTextPrefix; }
        protected getService() { return KegiatanService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}