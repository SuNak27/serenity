
namespace Serenity.MasterData {

    @Serenity.Decorators.registerClass()
    export class PelanggaranGrid extends Serenity.EntityGrid<PelanggaranRow, any> {
        protected getColumnsKey() { return PelanggaranColumns.columnsKey; }
        protected getDialogType() { return PelanggaranDialog; }
        protected getIdProperty() { return PelanggaranRow.idProperty; }
        protected getInsertPermission() { return PelanggaranRow.insertPermission; }
        protected getLocalTextPrefix() { return PelanggaranRow.localTextPrefix; }
        protected getService() { return PelanggaranService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons(): Serenity.ToolButton[] {

            var buttons = super.getButtons();

            buttons.push(Serenity.Extensions.ExcelExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit(),
                service: SiswaService.baseUrl + '/ListExcel',
                separator: true
            }));

            buttons.push(Serenity.Extensions.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit()
            }));
            return buttons;
        }
    }
}