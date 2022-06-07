
namespace Serenity.MasterData {

    @Serenity.Decorators.registerClass()
    export class KegiatanDialog extends Serenity.EntityDialog<KegiatanRow, any> {
        protected getFormKey() { return KegiatanForm.formKey; }
        protected getIdProperty() { return KegiatanRow.idProperty; }
        protected getLocalTextPrefix() { return KegiatanRow.localTextPrefix; }
        protected getNameProperty() { return KegiatanRow.nameProperty; }
        protected getService() { return KegiatanService.baseUrl; }
        protected getDeletePermission() { return KegiatanRow.deletePermission; }
        protected getInsertPermission() { return KegiatanRow.insertPermission; }
        protected getUpdatePermission() { return KegiatanRow.updatePermission; }

        protected form = new KegiatanForm(this.idPrefix);

    }
}